using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LMTracking.Controllers
{
    public class ProgramacaoEntregaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Incluir()
        {
            return View();
        }
    }
}