using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;

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
            string get;
            try
            {
                user.State = BusinessEntity.States.New;
                new UsuarioLogic().Save(user);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Usuarios");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            return RedirectToAction("Usuarios", "Home");           

            List<Usuario> users = new UsuarioLogic().GetAll();
            Usuario user = users.Where(u => u.ID == id).FirstOrDefault();

            return View(user);
        }

        [HttpPost]
        public ActionResult Editar(Usuario user)
        {
            string get;
            try
            {
                user.State = BusinessEntity.States.Modified;
                new UsuarioLogic().Save(user);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Usuarios");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Usuarios", "Home");

            List<Usuario> users = new UsuarioLogic().GetAll();
            Usuario user = users.Where(u => u.ID == id).FirstOrDefault();

            return View(user);
        }

        [HttpPost]
        public ActionResult Eliminar(string id)
        {
            string get;
            try
            {
                new UsuarioLogic().Delete(int.Parse(id));
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Usuarios");
            return RedirectToAction("Informacion", "Home", new { get });
        }
    }
}
