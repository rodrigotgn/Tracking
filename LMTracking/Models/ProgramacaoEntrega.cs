using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMTracking.Models
{
    public class ProgramacaoEntrega
    {
        public Int32 ID { get; set; }
        public String Apelido { get; set; }
        public List<ProgramacaoEntregaEndereco> Endereco { get; set; }
    }

    public class ProgramacaoEntregaEndereco
    {
        public Int32 ID { get; set; }
        public String Cliente { get; set; }
        public String Endereco { get; set; }
    }
}
