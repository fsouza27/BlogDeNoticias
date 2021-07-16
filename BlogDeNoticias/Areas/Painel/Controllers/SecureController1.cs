using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDeNoticias.Areas.Painel.Controllers
{
    public class SecureController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
