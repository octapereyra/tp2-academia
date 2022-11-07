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
    public class DocenteController : Controller
    {
        public ActionResult Registrar()
        {
            IEnumerable<Persona> docentes = new PersonaLogic().GetAll();
            docentes = docentes.Where(d => d.TipoPersona == Persona.TiposPersonas.Docente);
            return View(docentes);
        }

        [HttpPost]
        public ActionResult Registrar(DocenteCurso dc)
        {
            string get;
            try
            {
                dc.State = BusinessEntity.States.New;
                new DocenteCursoLogic().Save(dc);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Docentes");
            return RedirectToAction("Informacion", "Home", new { get });
        }     

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Docentes", "Home");

            List<DocenteCurso> docentes = new DocenteCursoLogic().GetAll();
            DocenteCurso dc = docentes.Where(d => d.ID == id).FirstOrDefault();

            return View(dc);
        }

        [HttpPost]
        public ActionResult Eliminar(string id)
        {
            string get;
            try
            {
                new DocenteCursoLogic().Delete(int.Parse(id));
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Docentes");
            return RedirectToAction("Informacion", "Home", new { get });
        }
    }
}
