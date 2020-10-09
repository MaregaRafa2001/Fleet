using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BLL
{
    public class VEICULO_BLL
    {
        public string strConnection;
        VEICULO_DAO DAO;
        public VEICULO_BLL(string conn = "")
        {
            if (string.IsNullOrEmpty(conn))
                strConnection = GLOBAL_BLL.stringConexaoBanco;
            DAO = new VEICULO_DAO(strConnection);
        }

        public int Incluir(VEICULO_DTO VEICULO)
        {
            try
            {
                ValidarDTO(VEICULO);
                return DAO.Incluir(VEICULO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VEICULO_DTO Seleciona(int ID)
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
        public void Alterar(VEICULO_DTO VEICULO)
        {
            try
            {
                ValidarDTO(VEICULO);
                DAO.Alterar(VEICULO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void ValidarDTO(VEICULO_DTO VEICULO_DTO)
        {
            if (string.IsNullOrEmpty(VEICULO_DTO.SITUACAO))
                throw new ValidaException("Favor informa a situação");
            if (string.IsNullOrEmpty(VEICULO_DTO.MARCA))
                throw new ValidaException("Favor informa a marca");
            if (string.IsNullOrEmpty(VEICULO_DTO.MODELO))
                throw new ValidaException("Favor informa o modelo");
            if (string.IsNullOrEmpty(VEICULO_DTO.PLACA))
                throw new ValidaException("Favor informa a placa");
            if (string.IsNullOrEmpty(VEICULO_DTO.CATEGORIA))
                throw new ValidaException("Favor informa a categoria");
            if (string.IsNullOrEmpty(VEICULO_DTO.RENAVAM))
                throw new ValidaException("Favor informa o renavam");
            if (string.IsNullOrEmpty(VEICULO_DTO.CHASSI))
                throw new ValidaException("Favor informa o chassi");
            if (string.IsNullOrEmpty(VEICULO_DTO.COMBUSTIVEL))
                throw new ValidaException("Favor informa o combustivel");
            if (string.IsNullOrEmpty(VEICULO_DTO.COR))
                throw new ValidaException("Favor informa a cor");
            if (VEICULO_DTO.KM_ATUAL == null)
                throw new ValidaException("Favor informa os km");
        }
    }
}
