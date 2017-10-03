using LMTracking.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMTracking.Models
{
    public class PontosMapa
    {
        public Int32 ID { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public Int16 TipoPonto { get; set; }
        public String Descricao { get; set; }

        public Condutor condutor { get; set; }

        public ProgramacaoEntrega Rota
        {
            get
            {
                return DadosAplicacao.ListaProgramacaoEntrega.Find(p => p.ID == this.ID);
            }
        }
    }
}