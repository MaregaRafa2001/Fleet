using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TRANSACOES_DTO
    {
        public TRANSACOES_DTO()
        {

        }

        public int? ID { get; set; }
        public byte[]  IMG{ get; set; }
        public string SITUACAO { get; set; }
        public string DESCRICAO { get; set; }
        public string TIPO { get; set; }
        public string CATEGORIA { get; set; }
        public DateTime? DATA { get; set; }
        public decimal? VALOR { get; set; }
        public bool? PARCELAMENTO { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
