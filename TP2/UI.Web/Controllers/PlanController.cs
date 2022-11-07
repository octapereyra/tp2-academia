﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;

namespace UI.Web.Controllers
{
    public class PlanController : Controller
    {
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Plan plan)
        {
            string get;
            try
            {
                plan.State = BusinessEntity.States.New;
                new PlanLogic().Save(plan);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Planes");
            return RedirectToAction("Informacion", "Home", new { get });
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Planes", "Home");

            List<Plan> plans = new PlanLogic().GetAll();
            Plan plan = plans.Where(u => u.ID == id).FirstOrDefault();

            return View(plan);
        }

        [HttpPost]
        public ActionResult Editar(Plan plan)
        {
            string get;
            try
            {
                plan.State = BusinessEntity.States.Modified;
                new PlanLogic().Save(plan);
                get = "success";
            }
            catch (Exception ex)
            {
                get = "error";
                HttpContext.Session.SetString("errorMsj", ex.Message);
            }
            HttpContext.Session.SetString("action", "Planes");
            return RedirectToAction("Informacion", "Home", new { get });
        }

    }
}
