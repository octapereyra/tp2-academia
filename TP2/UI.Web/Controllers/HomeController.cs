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
using Microsoft.AspNetCore.Http;

namespace UI.Web.Controllers
{
    [ValidarSession]
    public class HomeController : Controller
    {       
        public IActionResult Index() 
        {
            return View();
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Materias()
        {
            List<Materia> materias = new MateriaLogic().GetAll();
            return View(materias);
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Usuarios()
        {
            List<Usuario> users = new UsuarioLogic().GetAll();          
            return View(users);
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Comisiones()
        {
            List<Comision> comisiones = new ComisionLogic().GetAll();
            return View(comisiones);
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Personas()
        {
            List<Persona> personas = new PersonaLogic().GetAll();
            return View(personas);
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Especialidades()
        {
            List<Especialidad> especialidades = new EspecialidadLogic().GetAll();
            return View(especialidades);
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Planes()
        {
            List<Plan> planes = new PlanLogic().GetAll();
            return View(planes);
        }
        [PermisosRol(Persona.TiposPersonas.Estudiante)]
        public IActionResult InscribirMateria()
        {
            return View();
        }
        [PermisosRol(Persona.TiposPersonas.Docente)]
        public IActionResult RegistrarNotas() 
        {
            return View();
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Cursos()
        {
            List<Curso> cursos = new CursoLogic().GetAll();
            return View(cursos); 
        }
        [PermisosRol(Persona.TiposPersonas.Administrativo)]
        public IActionResult Docentes()
        {
            List<DocenteCurso> docentes = new DocenteCursoLogic().GetAll();
            return View(docentes);
        }
        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
        public IActionResult Informacion(string get)
        {
            if (get == "success")
            {
                ViewData["msj"] = "La acción se realizó con éxito";
            }
            if (get == "error")
            {
                ViewData["msj"] = HttpContext.Session.GetString("errorMsj");             
            }

            ViewData["action"] = HttpContext.Session.GetString("action");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() 
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
