using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ITENS_ESTOQUE_DAO
    {
        public string strConnection;

        public ITENS_ESTOQUE_DAO(string conn)
        {
            this.strConnection = conn;
        }


        public int Incluir(ITENS_ESTOQUE_DTO ITENS_ESTOQUE)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                try
                {
                    scn.Open();
                    SqlCommand scm = scn.CreateCommand();
                    SqlTransaction transaction;
                    transaction = scn.BeginTransaction(IsolationLevel.ReadCommitted);
                    scm.Connection = scn;
                    scm.Transaction = transaction;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("");

                    sb.Append("INSERT INTO [ITENS_ESTOQUE]");
                    sb.Append("      ([SITUACAO]             ");
                    sb.Append("      ,[ITEM]                    ");
                    sb.Append("      ,[TIPO]                    ");
                    sb.Append("      ,[UNIDADE_MEDIDA]          ");
                    sb.Append("      ,[QUANTIDADE]              ");
                    sb.Append("      ,[VALOR_UNITARIO]          ");
                    sb.Append("      ,[VALOR_TOTAL]             ");
                    sb.Append("      ,[OBSERVACAO])             ");
                    sb.Append("VALUES                           ");
                    sb.Append("      (@SITUACAO,             ");
                    sb.Append("      @ITEM,                     ");
                    sb.Append("      @TIPO,                     ");
                    sb.Append("      @UNIDADE_MEDIDA,           ");
                    sb.Append("      @QUANTIDADE,               ");
                    sb.Append("      @VALOR_UNITARIO,           ");
                    sb.Append("      @VALOR_TOTAL,              ");
                    sb.Append("      @OBSERVACAO)               ");
                    sb.Append("select Scope_Identity();");


                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(ITENS_ESTOQUE, scm);

                        ITENS_ESTOQUE.ID = Convert.ToInt32(scm.ExecuteScalar());

                        transaction.Commit();

                        return Convert.ToInt32(ITENS_ESTOQUE.ID);
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            transaction.Rollback();
                            throw e;
                        }
                        catch (SqlException ex)
                        {
                            if (transaction == null || transaction.Connection == null)
                            {
                                throw ex;
                            }
                            else
                            {
                                throw new Exception("Erro ao gravar dados do registro atual: " + e.Message + " não foi possível reverter transação,motivo: " + ex.Message);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    scn.Close();
                }

            }
        }

        public void Alterar(ITENS_ESTOQUE_DTO ITENS_ESTOQUE)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                try
                {
                    scn.Open();

                    SqlCommand scm = scn.CreateCommand();
                    scm.Connection = scn;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE ITENS_ESTOQUE                   ");
                    sb.Append("   SET SITUACAO = @SITUACAO            ");
                    sb.Append("      ,ITEM = @ITEM                    ");
                    sb.Append("      ,TIPO = @TIPO                    ");
                    sb.Append("      ,UNIDADE_MEDIDA = @UNIDADE_MEDIDA");
                    sb.Append("      ,QUANTIDADE = @QUANTIDADE        ");
                    sb.Append("      ,VALOR_UNITARIO = @VALOR_UNITARIO");
                    sb.Append("      ,VALOR_TOTAL = @VALOR_TOTAL      ");
                    sb.Append("      ,OBSERVACAO = @OBSERVACAO        ");
                    sb.Append(" WHERE ID = @ID                        ");

                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(ITENS_ESTOQUE, scm);

                        scm.ExecuteNonQuery();

                        //RegistrarDependente(Cliente);

                    }
                    catch (Exception e)
                    {
                        try
                        {
                            throw e;
                        }
                        catch (SqlException ex)
                        {
                            throw new Exception("Erro ao gravar dados do registro atual: " + e.Message + " não foi possível reverter transação,motivo: " + ex.Message);
                        }
                    }

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    scn.Close();
                }
            }
        }

        void Popular_Parametros(ITENS_ESTOQUE_DTO ITENS_ESTOQUE, SqlCommand scm)
        {
            scm.Parameters.AddWithValue("@ID", ITENS_ESTOQUE.ID);
            scm.Parameters.AddWithValue("@SITUACAO", ITENS_ESTOQUE.SITUACAO);
            scm.Parameters.AddWithValue("@ITEM", ITENS_ESTOQUE.ITEM);
            scm.Parameters.AddWithValue("@TIPO", ITENS_ESTOQUE.TIPO);
            scm.Parameters.AddWithValue("@UNIDADE_MEDIDA", ITENS_ESTOQUE.UNIDADE_MEDIDA);
            scm.Parameters.AddWithValue("@QUANTIDADE", ITENS_ESTOQUE.QUANTIDADE);
            scm.Parameters.AddWithValue("@VALOR_UNITARIO", ITENS_ESTOQUE.VALOR_UNITARIO);
            scm.Parameters.AddWithValue("@VALOR_TOTAL", ITENS_ESTOQUE.VALOR_TOTAL);
            scm.Parameters.AddWithValue("@OBSERVACAO", ITENS_ESTOQUE.OBSERVACAO);

            foreach (SqlParameter Parameter in scm.Parameters)
            {
                if (Parameter.Value == null)
                {
                    Parameter.Value = DBNull.Value;
                }
            }
        }



        public ITENS_ESTOQUE_DTO Seleciona(int Id)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                SqlDataReader dtr = null;
                ITENS_ESTOQUE_DTO ITENS_ESTOQUE = new ITENS_ESTOQUE_DTO();

                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM [dbo].[ITENS_ESTOQUE] Where (ID = " + Id + ");");
                    scn.Open();
                    SqlCommand scm = new SqlCommand(sb.ToString(), scn);

                    dtr = scm.ExecuteReader();

                    if (dtr.Read())
                    {
                        Popular_DTO(ITENS_ESTOQUE, dtr);
                    }

                    return ITENS_ESTOQUE;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (dtr != null) { dtr.Close(); }
                    scn.Close();
                }
            }
        }

        public void Popular_DTO(ITENS_ESTOQUE_DTO ITENS_ESTOQUE, SqlDataReader dtr)
        {
            try
            {
                ITENS_ESTOQUE.ID = (dtr["Id"]) == DBNull.Value ? (int?)null : Convert.ToInt32(dtr["Id"]);
                ITENS_ESTOQUE.SITUACAO = Convert.ToString(dtr["SITUACAO"]);
                ITENS_ESTOQUE.ITEM = Convert.ToString(dtr["ITEM"]);
                ITENS_ESTOQUE.TIPO = Convert.ToString(dtr["TIPO"]);
                ITENS_ESTOQUE.UNIDADE_MEDIDA = Convert.ToString(dtr["UNIDADE_MEDIDA"]);
                ITENS_ESTOQUE.QUANTIDADE = (dtr["QUANTIDADE"]) == DBNull.Value ? (int?)null : Convert.ToInt32(dtr["QUANTIDADE"]);
                ITENS_ESTOQUE.VALOR_UNITARIO = dtr["VALOR_UNITARIO"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dtr["VALOR_UNITARIO"]);
                ITENS_ESTOQUE.VALOR_TOTAL = dtr["VALOR_TOTAL"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dtr["VALOR_TOTAL"]);
                ITENS_ESTOQUE.OBSERVACAO = Convert.ToString(dtr["OBSERVACAO"]);
            }
            catch
            {

            }
        }

    }
}
