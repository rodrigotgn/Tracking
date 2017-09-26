using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LMTracking.Helpers;

namespace LMTracking.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string usuario, string senha)
        {
            var user = DadosAplicacao.ListaUsuarios.Find(p => p.Login == usuario.Trim() && p.Senha == senha.Trim());

            if (user != null)
            {
                UsuarioLogado.NovoUsuarioLogado(HttpContext, user);

                return RedirectToAction("Index", "Home");
            }

            
            
            return View();
        }
    }
}