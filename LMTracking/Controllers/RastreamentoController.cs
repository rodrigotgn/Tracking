using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LMTracking.Helpers;
using LMTracking.Models;

namespace LMTracking.Controllers
{
    public class RastreamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CarregarTodosPontosMapa()
        {
            var retorno = new AjaxRetornoModel();

            try
            {
                var dados = DadosAplicacao.ListaPontosMapa;

                retorno.Data = dados;

                retorno.Sucesso = true;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Json(retorno);
        }

        public IActionResult CarregarPontosMapa(Int32 ID)
        {
            var retorno = new AjaxRetornoModel();

            try
            {
                var dados = DadosAplicacao.ListaPontosMapa.SingleOrDefault(p => p.ID == ID);

                retorno.Data = dados;

                retorno.Sucesso = true;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return Json(retorno);
        }
    }
}