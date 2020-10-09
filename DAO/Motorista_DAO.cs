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
    public class MOTORISTA_DAO
    {
        public string strConnection;

        public MOTORISTA_DAO(string conn)
        {
            this.strConnection = conn;
        }


        public int Incluir(MOTORISTA_DTO MOTORISTA)
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

                    sb.Append("INSERT INTO [dbo].[MOTORISTA]");
                    sb.Append("           ([SITUACAO]    ");
                    sb.Append("           ,[NOME_COMPLETO]  ");
                    sb.Append("           ,[DATA_NASCIMENTO]");
                    sb.Append("           ,[ID_ESTADO_CIVIL]");
                    sb.Append("           ,[SEXO]           ");
                    sb.Append("           ,[EMAIL]          ");
                    sb.Append("           ,[CPF]            ");
                    sb.Append("           ,[CNH]            ");
                    sb.Append("           ,[VALIDADE_CNH]   ");
                    sb.Append("           ,[CATEGORIA]      ");
                    sb.Append("           ,[OBSERVACAO])    ");
                    sb.Append("     VALUES                  ");
                    sb.Append("           (@SITUACAO     ");
                    sb.Append("           ,@NOME_COMPLETO   ");
                    sb.Append("           ,@DATA_NASCIMENTO ");
                    sb.Append("           ,@ID_ESTADO_CIVIL ");
                    sb.Append("           ,@SEXO            ");
                    sb.Append("           ,@EMAIL           ");
                    sb.Append("           ,@CPF             ");
                    sb.Append("           ,@CNH             ");
                    sb.Append("           ,@VALIDADE_CNH    ");
                    sb.Append("           ,@CATEGORIA       ");
                    sb.Append("           ,@OBSERVACAO)     ");
                    sb.Append("select Scope_Identity();");


                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(MOTORISTA, scm);

                        MOTORISTA.ID = Convert.ToInt32(scm.ExecuteScalar());

                        transaction.Commit();

                        return Convert.ToInt32(MOTORISTA.ID);
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

        public void Alterar(MOTORISTA_DTO MOTORISTA)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                try
                {
                    scn.Open();

                    SqlCommand scm = scn.CreateCommand();
                    scm.Connection = scn;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE [dbo].[MOTORISTA]             ");
                    sb.Append("SET [SITUACAO] = @SITUACAO,    ");
                    sb.Append("[NOME_COMPLETO] = @NOME_COMPLETO,    ");
                    sb.Append("[DATA_NASCIMENTO] = @DATA_NASCIMENTO,");
                    sb.Append("[ID_ESTADO_CIVIL] = @ID_ESTADO_CIVIL,");
                    sb.Append("[SEXO] = @SEXO,                      ");
                    sb.Append("[EMAIL] = @EMAIL,                    ");
                    sb.Append("[CPF] = @CPF,                        ");
                    sb.Append("[CNH] = @CNH,                        ");
                    sb.Append("[VALIDADE_CNH] = @VALIDADE_CNH,      ");
                    sb.Append("[CATEGORIA] = @CATEGORIA,            ");
                    sb.Append("[OBSERVACAO] = @OBSERVACAO           ");
                    sb.Append("WHERE                                ");
                    sb.Append("Id = @Id                             ");


                    try
                    {
                        scm.CommandText = sb.ToString();

                        Popular_Parametros(MOTORISTA, scm);

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

        void Popular_Parametros(MOTORISTA_DTO MOTORISTA, SqlCommand scm)
        {
            scm.Parameters.AddWithValue("@ID", MOTORISTA.ID);
            scm.Parameters.AddWithValue("@SITUACAO", MOTORISTA.SITUACAO);
            scm.Parameters.AddWithValue("@NOME_COMPLETO", MOTORISTA.NOME_COMPLETO);
            scm.Parameters.AddWithValue("@DATA_NASCIMENTO", MOTORISTA.DATA_NASCIMENTO);
            scm.Parameters.AddWithValue("@ID_ESTADO_CIVIL", MOTORISTA.ID_ESTADO_CIVIL);
            scm.Parameters.AddWithValue("@SEXO", MOTORISTA.SEXO);
            scm.Parameters.AddWithValue("@EMAIL", MOTORISTA.EMAIL);
            scm.Parameters.AddWithValue("@CPF", MOTORISTA.CPF);
            scm.Parameters.AddWithValue("@CNH", MOTORISTA.CNH);
            scm.Parameters.AddWithValue("@VALIDADE_CNH", MOTORISTA.VALIDADE_CNH);
            scm.Parameters.AddWithValue("@CATEGORIA", MOTORISTA.CATEGORIA);
            scm.Parameters.AddWithValue("@OBSERVACAO", MOTORISTA.OBSERVACAO);

            foreach (SqlParameter Parameter in scm.Parameters)
            {
                if (Parameter.Value == null)
                {
                    Parameter.Value = DBNull.Value;
                }
            }
        }



        public MOTORISTA_DTO Seleciona(int Id)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                SqlDataReader dtr = null;
                MOTORISTA_DTO MOTORISTA = new MOTORISTA_DTO();

                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM [dbo].[MOTORISTA] Where (ID = " + Id + ");");
                    scn.Open();
                    SqlCommand scm = new SqlCommand(sb.ToString(), scn);

                    dtr = scm.ExecuteReader();

                    if (dtr.Read())
                    {
                        Popular_DTO(MOTORISTA, dtr);
                    }

                    return MOTORISTA;
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

        public void Popular_DTO(MOTORISTA_DTO MOTORISTA, SqlDataReader dtr)
        {
            try
            {
                MOTORISTA.ID = (dtr["Id"]) == DBNull.Value ? (int?)null : Convert.ToInt32(dtr["Id"]);
                MOTORISTA.SITUACAO = Convert.ToString(dtr["SITUACAO"]);
                MOTORISTA.NOME_COMPLETO = Convert.ToString(dtr["NOME_COMPLETO"]);
                MOTORISTA.DATA_NASCIMENTO = (dtr["DATA_NASCIMENTO"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dtr["DATA_NASCIMENTO"]));
                MOTORISTA.ID_ESTADO_CIVIL = Convert.ToString(dtr["ID_ESTADO_CIVIL"]);
                MOTORISTA.SEXO = Convert.ToString(dtr["SEXO"]);
                MOTORISTA.EMAIL = Convert.ToString(dtr["EMAIL"]);
                MOTORISTA.CPF = Convert.ToString(dtr["CPF"]);
                MOTORISTA.CNH = Convert.ToString(dtr["CNH"]);
                MOTORISTA.VALIDADE_CNH = (dtr["VALIDADE_CNH"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dtr["VALIDADE_CNH"]));
                MOTORISTA.CATEGORIA = Convert.ToString(dtr["CATEGORIA"]);
                MOTORISTA.OBSERVACAO = Convert.ToString(dtr["OBSERVACAO"]);
            }
            catch
            {

            }
        }

    }
}
