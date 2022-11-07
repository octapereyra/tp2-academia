using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class EspecialidadController : Controller
    {
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Especialidad esp)
        {
            string get;
            try
            {
                esp.State = BusinessEntity.States.New;
                new EspecialidadLogic().Save(esp);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Especialidades");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Especialidades", "Home");

           List<Especialidad> esps = new EspecialidadLogic().GetAll();
            Especialidad esp = esps.Where(e => e.ID == id).FirstOrDefault();

            return View(esp);
        }

        [HttpPost]
        public ActionResult Editar(Especialidad esp)
        {
            string get;
            try
            {
                esp.State = BusinessEntity.States.Modified;
                new EspecialidadLogic().Save(esp);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Especialidades");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Especialidades", "Home");

            List<Especialidad> esps = new EspecialidadLogic().GetAll();
            Especialidad esp = esps.Where(e => e.ID == id).FirstOrDefault();

            return View(esp);
        }

        [HttpPost]
        public ActionResult Eliminar(string id)
        {
            string get;
            try
            {
                new EspecialidadLogic().Delete(int.Parse(id));
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Especialidades");
            return RedirectToAction("Informacion", "Home", new { get });
        }
    }
}
