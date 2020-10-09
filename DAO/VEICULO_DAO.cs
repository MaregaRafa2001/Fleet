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
    public class VEICULO_DAO
    {
        public string strConnection;

        public VEICULO_DAO(string conn)
        {
            this.strConnection = conn;
        }


        public int Incluir(VEICULO_DTO VEICULO)
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

                    sb.Append("INSERT INTO dbo.VEICULO   ");
                    sb.Append("           (SITUACAO   ");
                    sb.Append("           ,MARCA         ");
                    sb.Append("           ,MODELO        ");
                    sb.Append("           ,PLACA         ");
                    sb.Append("           ,ANO_FABRICACAO");
                    sb.Append("           ,ANO_MODELO    ");
                    sb.Append("           ,CATEGORIA     ");
                    sb.Append("           ,RENAVAM       ");
                    sb.Append("           ,CHASSI        ");
                    sb.Append("           ,COMBUSTIVEL   ");
                    sb.Append("           ,COR           ");
                    sb.Append("           ,KM_ATUAL      ");
                    sb.Append("           ,OBSERVACAO)   ");
                    sb.Append("VALUES                    ");
                    sb.Append("      (                   ");
                    sb.Append("	     @SITUACAO,       ");
                    sb.Append("      @MARCA,             ");
                    sb.Append("      @MODELO,            ");
                    sb.Append("      @PLACA,             ");
                    sb.Append("      @ANO_FABRICACAO,    ");
                    sb.Append("      @ANO_MODELO,        ");
                    sb.Append("      @CATEGORIA,         ");
                    sb.Append("      @RENAVAM,           ");
                    sb.Append("      @CHASSI,            ");
                    sb.Append("      @COMBUSTIVEL,       ");
                    sb.Append("      @COR,               ");
                    sb.Append("      @KM_ATUAL,          ");
                    sb.Append("      @OBSERVACAO         ");
                    sb.Append("	     )                   ");
                    sb.Append("select Scope_Identity();");


                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(VEICULO, scm);

                        VEICULO.ID = Convert.ToInt32(scm.ExecuteScalar());

                        transaction.Commit();

                        return Convert.ToInt32(VEICULO.ID);
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

        public void Alterar(VEICULO_DTO VEICULO)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                try
                {
                    scn.Open();

                    SqlCommand scm = scn.CreateCommand();
                    scm.Connection = scn;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE VEICULO                          ");
                    sb.Append("   SET SITUACAO = @SITUACAO,      ");
                    sb.Append("      MARCA = @MARCA,                   ");
                    sb.Append("      MODELO = @MODELO,                 ");
                    sb.Append("      PLACA = @PLACA,                   ");
                    sb.Append("      ANO_FABRICACAO = @ANO_FABRICACAO, ");
                    sb.Append("      ANO_MODELO = @ANO_MODELO,         ");
                    sb.Append("      CATEGORIA = @CATEGORIA,           ");
                    sb.Append("      RENAVAM = @RENAVAM,               ");
                    sb.Append("      CHASSI = @CHASSI,                 ");
                    sb.Append("      COMBUSTIVEL = @COMBUSTIVEL,       ");
                    sb.Append("      COR = @COR,                       ");
                    sb.Append("      KM_ATUAL = @KM_ATUAL,             ");
                    sb.Append("      OBSERVACAO = @OBSERVACAO          ");
                    sb.Append(" WHERE ID =ID                           ");

                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(VEICULO, scm);

                        scm.ExecuteNonQuery();

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

        void Popular_Parametros(VEICULO_DTO VEICULO, SqlCommand scm)
        {
            scm.Parameters.AddWithValue("@ID", VEICULO.ID);
            scm.Parameters.AddWithValue("@SITUACAO", VEICULO.SITUACAO);
            scm.Parameters.AddWithValue("@MARCA", VEICULO.MARCA);
            scm.Parameters.AddWithValue("@MODELO", VEICULO.MODELO);
            scm.Parameters.AddWithValue("@PLACA", VEICULO.PLACA);
            scm.Parameters.AddWithValue("@ANO_FABRICACAO", VEICULO.ANO_FABRICACAO);
            scm.Parameters.AddWithValue("@ANO_MODELO", VEICULO.ANO_MODELO);
            scm.Parameters.AddWithValue("@CATEGORIA", VEICULO.CATEGORIA);
            scm.Parameters.AddWithValue("@RENAVAM", VEICULO.RENAVAM);
            scm.Parameters.AddWithValue("@CHASSI", VEICULO.CHASSI);
            scm.Parameters.AddWithValue("@COMBUSTIVEL", VEICULO.COMBUSTIVEL);
            scm.Parameters.AddWithValue("@COR", VEICULO.COR);
            scm.Parameters.AddWithValue("@KM_ATUAL", VEICULO.KM_ATUAL);
            scm.Parameters.AddWithValue("@OBSERVACAO", VEICULO.OBSERVACAO);

            foreach (SqlParameter Parameter in scm.Parameters)
            {
                if (Parameter.Value == null)
                {
                    Parameter.Value = DBNull.Value;
                }
            }
        }



        public VEICULO_DTO Seleciona(int Id)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                SqlDataReader dtr = null;
                VEICULO_DTO VEICULO = new VEICULO_DTO();

                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM [dbo].[VEICULO] Where (ID = " + Id + ");");
                    scn.Open();
                    SqlCommand scm = new SqlCommand(sb.ToString(), scn);

                    dtr = scm.ExecuteReader();

                    if (dtr.Read())
                    {
                        Popular_DTO(VEICULO, dtr);
                    }

                    return VEICULO;
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

        public void Popular_DTO(VEICULO_DTO VEICULO, SqlDataReader dtr)
        {
            try
            {
                VEICULO.ID = (dtr["Id"]) == DBNull.Value ? (int?)null : Convert.ToInt32(dtr["Id"]);
                VEICULO.SITUACAO = Convert.ToString(dtr["SITUACAO"]);
                VEICULO.MARCA = Convert.ToString(dtr["MARCA"]);
                VEICULO.MODELO = Convert.ToString(dtr["MODELO"]);
                VEICULO.PLACA = Convert.ToString(dtr["PLACA"]);
                VEICULO.ANO_FABRICACAO = Convert.ToString(dtr["ANO_FABRICACAO"]);
                VEICULO.ANO_MODELO = Convert.ToString(dtr["ANO_MODELO"]);
                VEICULO.CATEGORIA = Convert.ToString(dtr["CATEGORIA"]);
                VEICULO.RENAVAM = Convert.ToString(dtr["RENAVAM"]);
                VEICULO.CHASSI = Convert.ToString(dtr["CHASSI"]);
                VEICULO.COMBUSTIVEL = Convert.ToString(dtr["COMBUSTIVEL"]);
                VEICULO.COR = Convert.ToString(dtr["COR"]);
                VEICULO.KM_ATUAL = dtr["KM_ATUAL"] == DBNull.Value? (double?)null : Convert.ToDouble(dtr["KM_ATUAL"]);
                VEICULO.OBSERVACAO = Convert.ToString(dtr["OBSERVACAO"]);
            }
            catch
            {

            }
        }
    }
}
