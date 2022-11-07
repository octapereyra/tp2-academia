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
    public class CursoController : Controller
    {   
        
        public ActionResult Registrar() 
        {
            List<Materia> materias = new MateriaLogic().GetAll();
            return View(materias);
        }
        [HttpPost]
        public ActionResult Registrar(Curso cur)
        {
            string get;
            try
            {
                cur.State = BusinessEntity.States.New;
                new CursoLogic().Save(cur);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Cursos");
            return RedirectToAction("Informacion", "Home", new { get });
        }
        [HttpGet] 
        public ActionResult Editar(int? id)
        {
            if (id == null) 
                return RedirectToAction("Cursos", "Home");
            List<Curso> curs = new CursoLogic().GetAll();
            Curso cur = curs.Where(c => c.ID == id).FirstOrDefault();

            return View(cur);
        }

        [HttpPost] 
        public ActionResult Editar(Curso cur)
        {
            string get;
            try
            {
                cur.State = BusinessEntity.States.Modified;
                new CursoLogic().Save(cur);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Cursos");
            return RedirectToAction("Informacion", "Home", new { get });
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
        public ActionResult Eliminar(string id)
        {
            string get;
            try
            {
                new CursoLogic().Delete(int.Parse(id));
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Cursos");
            return RedirectToAction("Informacion", "Home", new { get });
        }
    }
}
