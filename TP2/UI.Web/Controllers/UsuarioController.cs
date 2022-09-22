using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Usuario user)
        {
            user.State = BusinessEntity.States.New;
            new UsuarioLogic().Save(user);

            return RedirectToAction("Usuarios","Home");
        }
    }
}
