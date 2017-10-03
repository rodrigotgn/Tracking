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
        public List<ProgramacaoEntregaEndereco> Trechos { get; set; }
    }

    public class ProgramacaoEntregaEndereco
    {
        public Int32 ID { get; set; }
        public String Cliente { get; set; }
        public String Endereco { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public Int16 TipoPonto { get; set; }
        public Int32 Ordem { get; set; }
        public String HoraEntrega { get; set; }
    }
}