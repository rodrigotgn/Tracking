using LMTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMTracking.Helpers
{
    public static class DadosAplicacao
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>
        {
            new Usuario(){ ID = 1, Login = "admin", Nome= "Administrador", Senha= "123456"},
            new Usuario(){ ID = 2, Login = "rodrigo.torres", Nome= "Rodrigo Torres", Senha= "123456"},
            new Usuario(){ ID = 3, Login = "marcelo.martins", Nome= "Marcelo Martins", Senha= "123456"},
            new Usuario(){ ID = 4, Login = "rafael.magalhaes", Nome= "Rodrigo Torres", Senha= "123456"}
        };

        public static List<PontosMapa> ListaPontosMapa = new List<PontosMapa>
        {
            new PontosMapa(){ ID= 1, Latitude= -23.528743, Longitude= -46.739711, TipoPonto= 1, Descricao= "Roberto Carlos" },
            new PontosMapa(){ ID= 2, Latitude= -23.526452, Longitude= -46.735209, TipoPonto= 1, Descricao= "Julio Pereira" },
            new PontosMapa(){ ID= 3, Latitude= -23.537384, Longitude= -46.720805, TipoPonto= 1, Descricao= "Fernando Coutinho" },
            new PontosMapa(){ ID= 4, Latitude= -23.526327, Longitude= -46.713252, TipoPonto= 1, Descricao= "Juliana Couto" },
            new PontosMapa(){ ID= 5, Latitude= -23.548065, Longitude= -46.748652, TipoPonto= 1, Descricao= "Fatima Bernardes" },
            new PontosMapa(){ ID= 6, Latitude= -23.525142, Longitude= -46.765459, TipoPonto= 1, Descricao= "CVT - 4494" },
            new PontosMapa(){ ID= 7, Latitude= -23.528604, Longitude= -46.773870, TipoPonto= 1, Descricao= "DUS - 4668" },
            new PontosMapa(){ ID= 8, Latitude= -23.532736, Longitude= -46.763956, TipoPonto= 1, Descricao= "AAI - 7984" },
            new PontosMapa(){ ID= 9, Latitude= -23.514832, Longitude= -46.753356, TipoPonto= 2, Descricao= "PPA - 1150" },
            new PontosMapa(){ ID= 0, Latitude= -23.540260, Longitude= -46.719487, TipoPonto= 2, Descricao= "FUJ - 6657" }
        };
    }
}
