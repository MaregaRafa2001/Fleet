using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BLL
{
    public class MOTORISTA_BLL
    {
        public string strConnection;
        MOTORISTA_DAO DAO;
        public MOTORISTA_BLL(string conn = "")
        {
            if (string.IsNullOrEmpty(conn))
                strConnection = GLOBAL_BLL.stringConexaoBanco;
            DAO = new MOTORISTA_DAO(strConnection);
        }

        public int Incluir(MOTORISTA_DTO MOTORISTA)
        {
            try
            {
                ValidarDTO(MOTORISTA);
                return DAO.Incluir(MOTORISTA);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MOTORISTA_DTO Seleciona(int ID)
        {
            try
            {
                return DAO.Seleciona(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(MOTORISTA_DTO MOTORISTA)
        {
            try
            {
                ValidarDTO(MOTORISTA);
                DAO.Alterar(MOTORISTA);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void ValidarDTO(MOTORISTA_DTO MOTORISTA)
        {
            if (string.IsNullOrEmpty(MOTORISTA.SITUACAO))
                throw new ValidaException("Favor informa a situação");
            if (string.IsNullOrEmpty(MOTORISTA.NOME_COMPLETO))
                throw new ValidaException("Favor informa o nome");
            if (MOTORISTA.DATA_NASCIMENTO == null)
                throw new ValidaException("Favor informa a data de nascimento");
            if (string.IsNullOrEmpty(MOTORISTA.ID_ESTADO_CIVIL))
                throw new ValidaException("Favor informa o estado civil");
            if (string.IsNullOrEmpty(MOTORISTA.SEXO))
                throw new ValidaException("Favor informa o sexo");
            if (string.IsNullOrEmpty(MOTORISTA.EMAIL))
                throw new ValidaException("Favor informa o email");
            if (string.IsNullOrEmpty(MOTORISTA.CPF))
                throw new ValidaException("Favor informa o CPF");
            if (string.IsNullOrEmpty(MOTORISTA.CNH))
                throw new ValidaException("Favor informa o CNH");
            if (MOTORISTA.VALIDADE_CNH == null)
                throw new ValidaException("Favor informa a validade do CNH");
            if (string.IsNullOrEmpty(MOTORISTA.CATEGORIA))
                throw new ValidaException("Favor informa a categoria");
        }
    }
}
