using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LMTracking.Helpers;

namespace LMTracking.Controllers
{
    public class PlanoViagemController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.RetornaUsuarioLogado() == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }


    }
}