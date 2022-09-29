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
            user.State = BusinessEntity.States.Modified;
            new UsuarioLogic().Save(user);

            return RedirectToAction("Usuarios","Home");
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
            new UsuarioLogic().Delete(int.Parse(id));
            
            return RedirectToAction("Usuarios","Home");
        }
    }
}
