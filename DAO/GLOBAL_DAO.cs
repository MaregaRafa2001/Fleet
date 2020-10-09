using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GLOBAL_DAO
    {
        string strConnection;
        public GLOBAL_DAO(string conn)
        {
            strConnection = conn;
        }

        public DataTable Select(string Query)
        {
            using (SqlConnection scn = new SqlConnection(this.strConnection))
            {
                try
                {
                    scn.Open();

                    SqlCommand scm = scn.CreateCommand();
                    scm.CommandText = Query;
                    scm.CommandTimeout = 120;

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = scm;

                    DataTable dtt = new DataTable();
                    sda.Fill(dtt);
                    sda.Dispose();
                    return dtt;

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
    }
}
