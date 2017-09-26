using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMTracking.Models
{
    public class AjaxRetornoModel
    {
        public bool Sucesso { get; set; }
        public int ErroCodigo { get; set; }
        public string Mensagem { get; set; }
        public object Data { get; set; }
        public string Redirect { get; set; }
        
        public AjaxRetornoModel(bool sucesso, int erroCodigo, string Mensagem, object data, string redirect = "")
        {
            this.Sucesso = sucesso;
            this.ErroCodigo = erroCodigo;
            this.Mensagem = Mensagem;
            this.Data = data;
            this.Redirect = redirect;
        }
        
        public AjaxRetornoModel()
        {
            this.Sucesso = false;
            this.ErroCodigo = 0;
            this.Mensagem = string.Empty;
            this.Data = null;
            this.Redirect = string.Empty;

        }
    }
}