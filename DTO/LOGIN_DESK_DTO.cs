using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LOGIN_DESK_DTO
    {
        public int? ID { get; set; }
        public string NOME_COMPLETO { get; set; }
        public string EMAIL { get; set; }
        public int ID_PERFIL { get; set; }
        public string CPF { get; set; }
        public string CARGO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
        public string CONFIRMAR_SENHA { get; set; }
    }
}
