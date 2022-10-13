using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Web.Controllers
{
    public class PersonaController : Controller
    {
        public ActionResult Registrar()
        {
            
            List<Plan> planes = new PlanLogic().GetAll();
            return View(planes);
        }
        [HttpPost]
        public ActionResult Registrar(Persona per)
        {
            per.State = BusinessEntity.States.New;
            new PersonaLogic().Save(per);
            return RedirectToAction("Personas","Home");
        }

       
        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Personas", "Home");
            List<Persona> pers = new PersonaLogic().GetAll();
            Persona per = pers.Where(p => p.ID == id).FirstOrDefault();

            return View(per);
        }
        [HttpPost]
        public ActionResult Editar(Persona per)
        {
            per.State = BusinessEntity.States.Modified;
            new PersonaLogic().Save(per);

            return RedirectToAction("Personas", "Home");
        }



        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Personas", "Home");

            List<Persona> pers = new PersonaLogic().GetAll();
            Persona per = pers.Where(p => p.ID == id).FirstOrDefault();

            return View(per);
        }

        [HttpPost]
        public ActionResult Eliminar(string id)
        {
            new PersonaLogic().Delete(int.Parse(id));

            return RedirectToAction("Personas", "Home");
        }


    }
}
