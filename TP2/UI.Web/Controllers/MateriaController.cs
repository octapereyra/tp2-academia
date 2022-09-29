using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

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
            mat.State = BusinessEntity.States.New;
            new MateriaLogic().Save(mat);

            return RedirectToAction("Materias", "Home");
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
            mat.State = BusinessEntity.States.Modified;
            new MateriaLogic().Save(mat);

            return RedirectToAction("Materias", "Home");
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
            new MateriaLogic().Delete(int.Parse(id));

            return RedirectToAction("Materias", "Home");
        }
    }
}
