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
    public class MateriaController : Controller
    {
        public ActionResult Registrar()
        {
            List<Plan> planes = new PlanLogic().GetAll();
            return View(planes);
        }

        [HttpPost]
        public ActionResult Registrar(Materia mat)
        {
            string get;
            try
            {
                mat.State = BusinessEntity.States.New;
                new MateriaLogic().Save(mat);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Materias");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Materias", "Home");

            List<Materia> mats = new MateriaLogic().GetAll();
            Materia mat = mats.Where(u => u.ID == id).FirstOrDefault();

            return View(mat);
        }

        [HttpPost]
        public ActionResult Editar(Materia mat)
        {
            string get;
            try
            {
                mat.State = BusinessEntity.States.Modified;
                new MateriaLogic().Save(mat);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Materias");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Materias", "Home");

            List<Materia> mats = new MateriaLogic().GetAll();
            Materia mat = mats.Where(u => u.ID == id).FirstOrDefault();

            return View(mat);
        }

        [HttpPost]
        public ActionResult Eliminar(string id)
        {
            string get;
            try
            {
                new MateriaLogic().Delete(int.Parse(id));
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Materias");
            return RedirectToAction("Informacion", "Home", new { get });
        }
    }
}
