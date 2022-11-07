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
    public class ComisionController : Controller
    {
        public ActionResult Registrar()
        {
            List<Plan> planes = new PlanLogic().GetAll();
            return View(planes);
        }

        [HttpPost]
        public ActionResult Registrar(Comision com)
        {
            string get;
            try
            {
                com.State = BusinessEntity.States.New;
                new ComisionLogic().Save(com);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action","Comisiones");
            return RedirectToAction("Informacion","Home",new { get });
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Comisiones", "Home");

            List<Comision> coms = new ComisionLogic().GetAll();
            Comision com = coms.Where(c => c.ID == id).FirstOrDefault();

            return View(com);
        }

        [HttpPost]
        public ActionResult Editar(Comision com)
        {
            string get;
            try
            {               
                com.State = BusinessEntity.States.Modified;
                new ComisionLogic().Save(com);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Comisiones");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return RedirectToAction("Comisiones", "Home");

            List<Comision> coms = new ComisionLogic().GetAll();
            Comision com = coms.Where(c => c.ID == id).FirstOrDefault();

            return View(com);
        }

        [HttpPost]
        public ActionResult Eliminar(string id)
        {
            string get;
            try
            {
                new ComisionLogic().Delete(int.Parse(id));
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Comisiones");
            return RedirectToAction("Informacion", "Home", new { get });
        }
    }
}
