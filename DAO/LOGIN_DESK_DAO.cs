using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LOGIN_DESK_DAO
    {
        public string strConnection;

        public LOGIN_DESK_DAO(string conn)
        {
            this.strConnection = conn;

        }

        public LOGIN_DESK_DTO LogarDesk(string LoginUsuario, string Senha)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                SqlDataReader dtr = null;
                try
                {
                    LOGIN_DESK_DTO login = new LOGIN_DESK_DTO();

                    string sql = "SELECT * FROM LOGIN_DESK WHERE LOGIN = @LOGIN AND SENHA = @SENHA";

                    scn.Open();
                    SqlCommand scm = new SqlCommand(sql, scn);
                    scm.Parameters.AddWithValue("@LOGIN", LoginUsuario);
                    scm.Parameters.AddWithValue("@SENHA", Senha);

                    dtr = scm.ExecuteReader();

                    if (dtr.Read())
                    {
                        login.ID = Convert.ToInt32(dtr["id"]);
                        login.LOGIN = dtr["LOGIN"].ToString();
                        login.SENHA = dtr["SENHA"].ToString();
                        login.ID_PERFIL = Convert.ToInt32(dtr["ID_PERFIL"]);
                        login.NOME_COMPLETO = dtr["NOME_COMPLETO"].ToString();
                        login.CARGO = dtr["CARGO"].ToString();
                        login.EMAIL = dtr["EMAIL"].ToString();
                        login.CPF = dtr["CPF"].ToString();
                    }
                    return login;
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

    }
}
