using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;
using Microsoft.AspNetCore.Http;

namespace UI.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            Usuario userLogged = new LoginLogic().GetUsuario(user.NombreUsuario, user.Clave);

            if (userLogged == null)
            {
                ViewData["msj"] = "Usuario y/o clave incorrectos";
                return View();
            }
            if (!userLogged.Habilitado)
            {
                ViewData["msj"] = "Usuario no habilitado";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("userId", userLogged.ID.ToString());
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
