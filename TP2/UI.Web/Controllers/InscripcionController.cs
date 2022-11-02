using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class InscripcionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetComisiones(int id_materia)
        {
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDMateria == id_materia && c.Cupo > 0);
            List<Comision> comisiones = new(); 
            foreach (Curso curso in cursos)
            {
                comisiones.Add(new ComisionLogic().GetOne(curso.IDComision));
            }

            return Json(comisiones);
        }

        [HttpGet]
        public ActionResult ListarInscripciones(int? id)
        {
            IEnumerable<AlumnoInscripcion> inscripciones = new InscripcionLogic().GetAll();
            inscripciones = inscripciones.Where(i => i.IDAlumno == id);        
            return View(inscripciones);        
        }

    }
}
