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
    public class TRANSACOES_DAO
    {
        public string strConnection;

        public TRANSACOES_DAO(string conn)
        {
            this.strConnection = conn;
        }


        public int Incluir(TRANSACOES_DTO TRANSACOES)
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

                    sb.Append(" INSERT INTO TRANSACOES");
                    sb.Append("       (SITUACAO    ");
                    sb.Append("       ,DESCRICAO      ");
                    sb.Append("       ,TIPO           ");
                    sb.Append("       ,CATEGORIA      ");
                    sb.Append("       ,DATA           ");
                    sb.Append("       ,VALOR          ");
                    sb.Append("       ,PARCELAMENTO   ");
                    sb.Append("       ,OBSERVACAO)    ");
                    sb.Append(" VALUES                ");
                    sb.Append("       (@SITUACAO,  ");
                    sb.Append("       @DESCRICAO,     ");
                    sb.Append("       @TIPO,          ");
                    sb.Append("       @CATEGORIA,     ");
                    sb.Append("       @DATA,          ");
                    sb.Append("       @VALOR,         ");
                    sb.Append("       @PARCELAMENTO,  ");
                    sb.Append("       @OBSERVACAO)    ");
                    sb.Append("select Scope_Identity();");


                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(TRANSACOES, scm);

                        TRANSACOES.ID = Convert.ToInt32(scm.ExecuteScalar());

                        transaction.Commit();

                        return Convert.ToInt32(TRANSACOES.ID);
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

        public void Alterar(TRANSACOES_DTO TRANSACOES)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                try
                {
                    scn.Open();

                    SqlCommand scm = scn.CreateCommand();
                    scm.Connection = scn;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE [dbo].[TRANSACOES]          ");
                    sb.Append("  SET SITUACAO = @SITUACAO,  ");
                    sb.Append("     DESCRICAO = @DESCRICAO,       ");
                    sb.Append("     TIPO = @TIPO,                 ");
                    sb.Append("     CATEGORIA = @CATEGORIA,       ");
                    sb.Append("     DATA = @DATA,                 ");
                    sb.Append("     VALOR = @VALOR,               ");
                    sb.Append("     PARCELAMENTO = @PARCELAMENTO, ");
                    sb.Append("     OBSERVACAO = @OBSERVACAO      ");
                    sb.Append("WHERE ID = @ID                     ");


                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(TRANSACOES, scm);

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

        void Popular_Parametros(TRANSACOES_DTO TRANSACOES, SqlCommand scm)
        {
            scm.Parameters.AddWithValue("@ID", TRANSACOES.ID);
            scm.Parameters.AddWithValue("@SITUACAO", TRANSACOES.SITUACAO);
            scm.Parameters.AddWithValue("@DESCRICAO", TRANSACOES.DESCRICAO);
            scm.Parameters.AddWithValue("@TIPO", TRANSACOES.TIPO);
            scm.Parameters.AddWithValue("@CATEGORIA", TRANSACOES.CATEGORIA);
            scm.Parameters.AddWithValue("@DATA", TRANSACOES.DATA);
            scm.Parameters.AddWithValue("@VALOR", TRANSACOES.VALOR);
            scm.Parameters.AddWithValue("@PARCELAMENTO", TRANSACOES.PARCELAMENTO);
            scm.Parameters.AddWithValue("@OBSERVACAO", TRANSACOES.OBSERVACAO);

            foreach (SqlParameter Parameter in scm.Parameters)
            {
                if (Parameter.Value == null)
                {
                    Parameter.Value = DBNull.Value;
                }
            }
        }



        public TRANSACOES_DTO Seleciona(int Id)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                SqlDataReader dtr = null;
                TRANSACOES_DTO TRANSACOES = new TRANSACOES_DTO();

                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM [dbo].[TRANSACOES] Where (ID = " + Id + ");");
                    scn.Open();
                    SqlCommand scm = new SqlCommand(sb.ToString(), scn);

                    dtr = scm.ExecuteReader();

                    if (dtr.Read())
                    {
                        Popular_DTO(TRANSACOES, dtr);
                    }

                    return TRANSACOES;
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

        public void Popular_DTO(TRANSACOES_DTO TRANSACOES, SqlDataReader dtr)
        {
            try
            {
                TRANSACOES.ID = (dtr["ID"]) == DBNull.Value ? (int?)null : Convert.ToInt32(dtr["ID"]);
                TRANSACOES.SITUACAO = Convert.ToString(dtr["SITUACAO"]);
                TRANSACOES.DESCRICAO = Convert.ToString(dtr["DESCRICAO"]);
                TRANSACOES.TIPO = Convert.ToString(dtr["TIPO"]);
                TRANSACOES.CATEGORIA = Convert.ToString(dtr["CATEGORIA"]);
                TRANSACOES.DATA = (dtr["DATA"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dtr["DATA"]));
                TRANSACOES.VALOR = dtr["VALOR"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(dtr["VALOR"]);
                TRANSACOES.PARCELAMENTO = dtr["PARCELAMENTO"] == DBNull.Value ? false : Convert.ToBoolean(dtr["PARCELAMENTO"]);
                TRANSACOES.OBSERVACAO = Convert.ToString(dtr["OBSERVACAO"]);
            }
            catch
            {

            }
        }

    }
}
