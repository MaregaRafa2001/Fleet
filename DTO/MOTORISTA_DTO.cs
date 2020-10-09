using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MOTORISTA_DTO
    {
        public MOTORISTA_DTO()
        {

        }

        public int? ID { get; set; }
        public string SITUACAO { get; set; }
        public string NOME_COMPLETO { get; set; }
        public DateTime? DATA_NASCIMENTO { get; set; }
        public byte[] IMG_PERFIL { get; set; }
        public string ID_ESTADO_CIVIL { get; set; }
        public string SEXO { get; set; }
        public string EMAIL { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public DateTime? VALIDADE_CNH { get; set; }
        public string CATEGORIA { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
