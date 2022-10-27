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

        public JsonResult GetPlanes(int id_especialidad)
        {
            IEnumerable<Plan> planes = new PlanLogic().GetAll();
            planes = planes.Where(p => p.IDEspecialidad == id_especialidad);

            return Json(planes);
        }
        public JsonResult GetMaterias(int id_plan)
        {
            IEnumerable<Materia> materias = new MateriaLogic().GetAll();
            materias = materias.Where(m => m.IDPlan == id_plan);

            return Json(materias);
        }

        public JsonResult GetCursos(int id_materia)
        {
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDMateria == id_materia && c.Cupo > 0);

            return Json(cursos);
        }
    }
}
