using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class RegistroController : Controller
    {
        [HttpPost]
        public IActionResult Inscribir()
        {
            return View();
        }
    }
}
