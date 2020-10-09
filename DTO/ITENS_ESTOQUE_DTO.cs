using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ITENS_ESTOQUE_DTO
    {
        public ITENS_ESTOQUE_DTO()
        {

        }

        public int? ID { get; set; }
        public byte[] IMG { get; set; }
        public string SITUACAO { get; set; }
        public string ITEM { get; set; }
        public string TIPO { get; set; }
        public string UNIDADE_MEDIDA { get; set; }
        public int? QUANTIDADE { get; set; }
        public decimal? VALOR_UNITARIO { get; set; }
        public decimal? VALOR_TOTAL { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
