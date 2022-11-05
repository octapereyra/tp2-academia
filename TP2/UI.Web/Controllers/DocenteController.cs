using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

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
            dc.State = BusinessEntity.States.New;
            new DocenteCursoLogic().Save(dc);

            return RedirectToAction("Docentes", "Home");
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Docentes", "Home");

            List<DocenteCurso> docentes = new DocenteCursoLogic().GetAll();
            DocenteCurso dc = docentes.Where(d => d.ID == id).FirstOrDefault();

            return View(dc);
        }

        [HttpPost]
        public ActionResult Editar(DocenteCurso dc)
        {
            dc.State = BusinessEntity.States.Modified;
            new DocenteCursoLogic().Save(dc);

            return RedirectToAction("Docentes", "Home");
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
            new DocenteCursoLogic().Delete(int.Parse(id));

            return RedirectToAction("Docentes", "Home");
        }
    }
}
