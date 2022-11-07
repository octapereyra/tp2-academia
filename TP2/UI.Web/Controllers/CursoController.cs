using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class CursoController : Controller
    {   
        //4º
        public ActionResult Registrar() //crear cada vista con razor?
        {
            List<Materia> materias = new MateriaLogic().GetAll();
            return View(materias); //a donde y xq pasar  materias? y comisiones?
        }
        [HttpPost]
        public ActionResult Registrar(Curso cur)
        {
            cur.State = BusinessEntity.States.New;
            new CursoLogic().Save(cur);
            return RedirectToAction("Cursos", "Home");
        }
        [HttpGet] //retorno el curso en el q hago la edicion?
        public ActionResult Editar(int? id)
        {
            if (id == null) // se puede poner un cartel?
                return RedirectToAction("Cursos", "Home");
            List<Curso> curs = new CursoLogic().GetAll();
            Curso cur = curs.Where(c => c.ID == id).FirstOrDefault();

            return View(cur);
        }

        [HttpPost] //edito el curso
        public ActionResult Editar(Curso cur)
        {
            cur.State = BusinessEntity.States.Modified;
            new CursoLogic().Save(cur);

            return RedirectToAction("Cursos", "Home");
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Cursos", "Home");

            List<Curso> curs = new CursoLogic().GetAll();
            Curso cur = curs.Where(c => c.ID == id).FirstOrDefault();

            return View(cur);
        }

        [HttpPost]
        public ActionResult Eliminar(string id) //xq string?
        {
            new CursoLogic().Delete(int.Parse(id));

            return RedirectToAction("Cursos", "Home");
        }
    }
}
