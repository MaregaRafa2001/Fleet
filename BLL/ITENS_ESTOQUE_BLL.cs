using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BLL
{
    public class ITENS_ESTOQUE_BLL
    {
        public string strConnection;
        ITENS_ESTOQUE_DAO DAO;
        public ITENS_ESTOQUE_BLL(string conn = "")
        {
            if (string.IsNullOrEmpty(conn))
                strConnection = GLOBAL_BLL.stringConexaoBanco;
            DAO = new ITENS_ESTOQUE_DAO(strConnection);
        }

        public int Incluir(ITENS_ESTOQUE_DTO ITENS_ESTOQUE)
        {
            try
            {
                ValidarDTO(ITENS_ESTOQUE);
                return DAO.Incluir(ITENS_ESTOQUE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ITENS_ESTOQUE_DTO Seleciona(int ID)
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

        public void Alterar(ITENS_ESTOQUE_DTO ITENS_ESTOQUE)
        {
            try
            {
                ValidarDTO(ITENS_ESTOQUE);
                DAO.Alterar(ITENS_ESTOQUE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void ValidarDTO(ITENS_ESTOQUE_DTO ITENS_ESTOQUE)
        {
            if (string.IsNullOrEmpty(ITENS_ESTOQUE.SITUACAO))
                throw new ValidaException("Favor informa a situação");
            if (string.IsNullOrEmpty(ITENS_ESTOQUE.ITEM))
                throw new ValidaException("Favor informa o item");
            if (string.IsNullOrEmpty(ITENS_ESTOQUE.TIPO))
                throw new ValidaException("Favor informa o tipo");
            if (string.IsNullOrEmpty(ITENS_ESTOQUE.UNIDADE_MEDIDA))
                throw new ValidaException("Favor informa a unidade medida");
            if (ITENS_ESTOQUE.QUANTIDADE == null)
                throw new ValidaException("Favor informa a quantidade");
            if (ITENS_ESTOQUE.VALOR_UNITARIO == null)
                throw new ValidaException("Favor informa o valor unitário");
            if (ITENS_ESTOQUE.VALOR_TOTAL == null)
                throw new ValidaException("Favor informa o valor total");
        }
    }
}
