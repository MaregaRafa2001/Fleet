using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BLL
{
    public class TRANSACOES_BLL
    {
        public string strConnection;
        TRANSACOES_DAO DAO;
        public TRANSACOES_BLL(string conn = "")
        {
            if (string.IsNullOrEmpty(conn))
                strConnection = GLOBAL_BLL.stringConexaoBanco;
            DAO = new TRANSACOES_DAO(strConnection);
        }

        public int Incluir(TRANSACOES_DTO TRANSACOES)
        {
            try
            {
                ValidarDTO(TRANSACOES);
                return DAO.Incluir(TRANSACOES);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TRANSACOES_DTO Seleciona(int ID)
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

        public void Alterar(TRANSACOES_DTO TRANSACOES)
        {
            try
            {
                ValidarDTO(TRANSACOES);
                DAO.Alterar(TRANSACOES);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void ValidarDTO(TRANSACOES_DTO TRANSACOES)
        {
            if (string.IsNullOrEmpty(TRANSACOES.SITUACAO))
                throw new ValidaException("Favor informa a situação");
            if (string.IsNullOrEmpty(TRANSACOES.DESCRICAO))
                throw new ValidaException("Favor informa a descrição");
            if (string.IsNullOrEmpty(TRANSACOES.TIPO))
                throw new ValidaException("Favor informa a tipo");
            if (string.IsNullOrEmpty(TRANSACOES.CATEGORIA))
                throw new ValidaException("Favor informa a categoria");
            if (TRANSACOES.DATA == null)
                throw new ValidaException("Favor informa a data");
            if (TRANSACOES.VALOR == null)
                throw new ValidaException("Favor informa o valor");
            if (TRANSACOES.PARCELAMENTO == null)
                TRANSACOES.PARCELAMENTO = false;
        }
    }
}
