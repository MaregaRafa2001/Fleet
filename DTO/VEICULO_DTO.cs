using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VEICULO_DTO
    {
        public VEICULO_DTO()
        {

        }

        public int? ID { get; set; }
        public string SITUACAO { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public byte[] IMG_VEICULO { get; set; }
        public string PLACA { get; set; }
        public string ANO_FABRICACAO { get; set; }
        public string ANO_MODELO { get; set; }
        public string CATEGORIA { get; set; }
        public string RENAVAM { get; set; }
        public string CHASSI { get; set; }
        public string COMBUSTIVEL { get; set; }
        public string COR { get; set; }
        public double? KM_ATUAL { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
