using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LMTracking.Helpers;

namespace LMTracking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Adiciona o Usuario na sessão.
            var user = DadosAplicacao.ListaUsuarios.Find(p => p.ID == 2);
            HttpContext.NovoUsuarioLogado(user);
            
            if (HttpContext.RetornaUsuarioLogado() == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
