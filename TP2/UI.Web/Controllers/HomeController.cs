using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI.Web.Models;
using Business.Entities;
using Business.Logic;
using UI.Web.Permisos;

namespace UI.Web.Controllers
{
    [ValidarSession]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Materias()
        {
            List<Materia> materias = new MateriaLogic().GetAll();
            return View(materias);
        }

        public IActionResult Usuarios()
        {
            List<Usuario> users = new UsuarioLogic().GetAll();          
            return View(users);
        }

        public IActionResult Comisiones()
        {
            List<Comision> comisiones = new ComisionLogic().GetAll();
            return View(comisiones);
        }
        public IActionResult Personas()
        {
            List<Persona> personas = new PersonaLogic().GetAll();
            return View(personas);
        }
        public IActionResult Especialidades()
        {
            List<Especialidad> especialidades = new EspecialidadLogic().GetAll();
            return View(especialidades);
        }

        public IActionResult Planes()
        {
            List<Plan> planes = new PlanLogic().GetAll();
            return View(planes);
        }

        public IActionResult InscribirMateria()
        {
            return View();
        }
        public IActionResult RegistrarNotas()
        {
            return View();
        }
        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
