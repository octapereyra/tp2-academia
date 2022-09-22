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
                ViewData["msj"] = "Usuario no encontrado";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("userId", userLogged.ID.ToString());
                return RedirectToAction("Index", "Home");

            }

        }

        //public IActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Register(Usuario user)
        //{
        //    bool registrado;
        //    string msj;

        //    return View();
        //}
    }
}
