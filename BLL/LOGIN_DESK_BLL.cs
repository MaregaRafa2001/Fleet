using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BLL
{
    public class LOGIN_DESK_BLL
    {
        string strConnection;
        LOGIN_DESK_DAO DAO;
        public LOGIN_DESK_BLL(string strConnection = "")
        {
            if (strConnection == "")
            {
                strConnection = GLOBAL_BLL.stringConexaoBanco;
            }
            DAO = new LOGIN_DESK_DAO(strConnection);
        }

        public LOGIN_DESK_DTO logarDesk(string LoginUsuario, string Senha)
        {
            try
            {
                return DAO.LogarDesk(LoginUsuario, Senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
