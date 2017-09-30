﻿using LMTracking.Models;
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
            new PontosMapa(){ ID= 1, Latitude= -23.530831, Longitude= -46.731016, TipoPonto= 1, Descricao= "Roberto Carlos" },
            new PontosMapa(){ ID= 2, Latitude= -23.526452, Longitude= -46.735209, TipoPonto= 1, Descricao= "Juliana Couto" },
            new PontosMapa(){ ID= 3, Latitude= -23.537384, Longitude= -46.720805, TipoPonto= 1, Descricao= "Fernando Coutinho" },
            new PontosMapa(){ ID= 4, Latitude= -23.526327, Longitude= -46.713252, TipoPonto= 1, Descricao= "Julio Pereira" },
            new PontosMapa(){ ID= 5, Latitude= -23.548065, Longitude= -46.748652, TipoPonto= 1, Descricao= "Fatima Bernardes" },
            new PontosMapa(){ ID= 6, Latitude= -23.525142, Longitude= -46.765459, TipoPonto= 2, Descricao= "CVT - 4494" },
            new PontosMapa(){ ID= 7, Latitude= -23.528604, Longitude= -46.773870, TipoPonto= 2, Descricao= "DUS - 4668" },
            new PontosMapa(){ ID= 8, Latitude= -23.532736, Longitude= -46.763956, TipoPonto= 2, Descricao= "AAI - 7984" },
            new PontosMapa(){ ID= 9, Latitude= -23.514832, Longitude= -46.753356, TipoPonto= 2, Descricao= "PPA - 1150" },
            new PontosMapa(){ ID= 10, Latitude= -23.540260, Longitude= -46.719487, TipoPonto= 2, Descricao= "FUJ - 6657" }
        };

        public static List<ProgramacaoEntrega> ListaProgramacaoEntrega = new List<ProgramacaoEntrega>
        {
            new ProgramacaoEntrega(){
                ID = 1,
                Apelido = "Teste 1",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 1, Latitude= -23.528743, TipoPonto= 4, Longitude= -46.739711, Endereco= "Avenida João Rodrigues Ruiz", Cliente= "Anthony Alexandre Oliveira" },
                    new ProgramacaoEntregaEndereco() { ID= 2, Latitude= -23.526452, TipoPonto= 4, Longitude= -46.735209, Endereco= "Travessa Eugênio Hostos", Cliente= "Marcelo Kaique dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 3, Latitude= -23.537384, TipoPonto= 3, Longitude= -46.720805, Endereco= "Rua Manuel Acosta", Cliente= "Rafael Isaac Alves" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 2,
                Apelido = "Teste 2",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 4, Latitude= -23.526327, TipoPonto= 4, Longitude= -46.713252, Endereco= "Rua Primavera", Cliente= "Lucas César Ribeiro" },
                    new ProgramacaoEntregaEndereco() { ID= 5, Latitude= -23.525142, TipoPonto= 4, Longitude= -46.765459, Endereco= "Rua Elói Porteli", Cliente= "Enrico Yuri" },
                    new ProgramacaoEntregaEndereco() { ID= 6, Latitude= -23.537888, TipoPonto= 4, Longitude= -46.772961, Endereco= "Rua Doutor Raymundo Gomes", Cliente= "João Lucca" },
                    new ProgramacaoEntregaEndereco() { ID= 7, Latitude= -23.548065, TipoPonto= 3, Longitude= -46.748652, Endereco= "Rua Trapoeraba", Cliente= "Carlos Eduardo" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 3,
                Apelido = "Teste 3",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 8, Latitude= -23.532736, TipoPonto= 4, Longitude= -46.763956, Endereco= "Rua Maria Cristina", Cliente= "Julio Otávio Rodrigues" },
                    new ProgramacaoEntregaEndereco() { ID= 9, Latitude= -23.514832, TipoPonto= 4, Longitude= -46.753356, Endereco= "Alameda das Perobas", Cliente= "Vitor André dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 10, Latitude= -23.540260, TipoPonto= 3, Longitude= -46.719487, Endereco= "Rua Cuiabano", Cliente= "Vitor Theo Moura" }
                }
            },
                        new ProgramacaoEntrega(){
                ID = 1,
                Apelido = "Teste 4",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 1, Latitude= -23.528743, TipoPonto= 4, Longitude= -46.739711, Endereco= "Avenida João Rodrigues Ruiz", Cliente= "Anthony Alexandre Oliveira" },
                    new ProgramacaoEntregaEndereco() { ID= 2, Latitude= -23.526452, TipoPonto= 4, Longitude= -46.735209, Endereco= "Travessa Eugênio Hostos", Cliente= "Marcelo Kaique dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 3, Latitude= -23.537384, TipoPonto= 3, Longitude= -46.720805, Endereco= "Rua Manuel Acosta", Cliente= "Rafael Isaac Alves" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 2,
                Apelido = "Teste 5",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 4, Latitude= -23.526327, TipoPonto= 4, Longitude= -46.713252, Endereco= "Rua Primavera", Cliente= "Lucas César Ribeiro" },
                    new ProgramacaoEntregaEndereco() { ID= 5, Latitude= -23.548065, TipoPonto= 4, Longitude= -46.748652, Endereco= "Rua Trapoeraba", Cliente= "Carlos Eduardo" },
                    new ProgramacaoEntregaEndereco() { ID= 6, Latitude= -23.525142, TipoPonto= 4, Longitude= -46.765459, Endereco= "Rua Elói Porteli", Cliente= "Enrico Yuri" },
                    new ProgramacaoEntregaEndereco() { ID= 7, Latitude= -23.528604, TipoPonto= 4, Longitude= -46.773870, Endereco= "Rua Doutor Raymundo Gomes", Cliente= "João Lucca" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 3,
                Apelido = "Teste 6",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 8, Latitude= -23.532736, TipoPonto= 4, Longitude= -46.763956, Endereco= "Rua Maria Cristina", Cliente= "Julio Otávio Rodrigues" },
                    new ProgramacaoEntregaEndereco() { ID= 9, Latitude= -23.514832, TipoPonto= 4, Longitude= -46.753356, Endereco= "Alameda das Perobas", Cliente= "Vitor André dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 10, Latitude= -23.540260, TipoPonto= 4, Longitude= -46.719487, Endereco= "Rua Cuiabano", Cliente= "Vitor Theo Moura" }
                }
            },
                        new ProgramacaoEntrega(){
                ID = 1,
                Apelido = "Teste 7",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 1, Latitude= -23.528743, TipoPonto= 4, Longitude= -46.739711, Endereco= "Avenida João Rodrigues Ruiz", Cliente= "Anthony Alexandre Oliveira" },
                    new ProgramacaoEntregaEndereco() { ID= 2, Latitude= -23.526452, TipoPonto= 4, Longitude= -46.735209, Endereco= "Travessa Eugênio Hostos", Cliente= "Marcelo Kaique dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 3, Latitude= -23.537384, TipoPonto= 4, Longitude= -46.720805, Endereco= "Rua Manuel Acosta", Cliente= "Rafael Isaac Alves" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 2,
                Apelido = "Teste 8",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 4, Latitude= -23.526327, TipoPonto= 4, Longitude= -46.713252, Endereco= "Rua Primavera", Cliente= "Lucas César Ribeiro" },
                    new ProgramacaoEntregaEndereco() { ID= 5, Latitude= -23.548065, TipoPonto= 4, Longitude= -46.748652, Endereco= "Rua Trapoeraba", Cliente= "Carlos Eduardo" },
                    new ProgramacaoEntregaEndereco() { ID= 6, Latitude= -23.525142, TipoPonto= 4, Longitude= -46.765459, Endereco= "Rua Elói Porteli", Cliente= "Enrico Yuri" },
                    new ProgramacaoEntregaEndereco() { ID= 7, Latitude= -23.528604, TipoPonto= 4, Longitude= -46.773870, Endereco= "Rua Doutor Raymundo Gomes", Cliente= "João Lucca" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 3,
                Apelido = "Teste 9",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 8, Latitude= -23.532736, TipoPonto= 4, Longitude= -46.763956, Endereco= "Rua Maria Cristina", Cliente= "Julio Otávio Rodrigues" },
                    new ProgramacaoEntregaEndereco() { ID= 9, Latitude= -23.514832, TipoPonto= 4, Longitude= -46.753356, Endereco= "Alameda das Perobas", Cliente= "Vitor André dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 10, Latitude= -23.540260, TipoPonto= 4, Longitude= -46.719487, Endereco= "Rua Cuiabano", Cliente= "Vitor Theo Moura" }
                }
            },
            new ProgramacaoEntrega(){
                ID = 3,
                Apelido = "Teste 10",
                Trechos = new List<ProgramacaoEntregaEndereco>(){
                    new ProgramacaoEntregaEndereco() { ID= 8, Latitude= -23.532736, TipoPonto= 4, Longitude= -46.763956, Endereco= "Rua Maria Cristina", Cliente= "Julio Otávio Rodrigues" },
                    new ProgramacaoEntregaEndereco() { ID= 9, Latitude= -23.514832, TipoPonto= 4, Longitude= -46.753356, Endereco= "Alameda das Perobas", Cliente= "Vitor André dos Santos" },
                    new ProgramacaoEntregaEndereco() { ID= 10, Latitude= -23.540260, TipoPonto= 4, Longitude= -46.719487, Endereco= "Rua Cuiabano", Cliente= "Vitor Theo Moura" }
                }
            }
        };
    }
}
