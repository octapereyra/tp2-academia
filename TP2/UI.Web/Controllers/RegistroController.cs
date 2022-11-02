using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    public class RegistroController : Controller
    {
        [HttpPost]
        public ActionResult Inscribir(Curso curso)
        {
            try
            {
            Usuario alumno = new UsuarioLogic().GetOne((int)HttpContext.Session.GetInt32("userId"));
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDComision == curso.IDComision && c.IDMateria == curso.IDMateria);
            curso = cursos.First();
            AlumnoInscripcion inscripcion = new()
            {
                IDCurso = curso.ID,
                IDAlumno = alumno.IdPersona,
                Condicion = "Inscripto",
                Nota = 0,
                State = BusinessEntity.States.New,
            }; 
                if (ValidarInscripcion(alumno.IdPersona, curso.ID))
                {
                    new InscripcionLogic().Save(inscripcion);
                    curso.Cupo -= 1;
                    curso.State = BusinessEntity.States.Modified;
                    new CursoLogic().Save(curso);
                    Comision com = new ComisionLogic().GetOne(curso.IDComision);
                    Materia mat = new MateriaLogic().GetOne(curso.IDMateria);
                    ViewData["msj"] = "Inscripción realizada con éxito. Te inscribiste en la materia " + mat.Descripcion + " en la comisión " + com.Descripcion;
                }
                else
                {
                    throw new Exception("Error. Ya estas inscripto en esa materia");
                }           
            }
            catch(Exception ex)
            {
                ViewData["msj"] = ex.Message;
            }

            return View();
        }

        [HttpPost]
        public ActionResult RegistrarNota(int? IDCurso)
        {
            IEnumerable<AlumnoInscripcion> inscripciones = new InscripcionLogic().GetAll();
            inscripciones = inscripciones.Where(i => i.IDCurso == IDCurso);
            ViewData["curso"] = "Curso "+IDCurso;
            return View(inscripciones);
        }

        [HttpGet]
        public ActionResult EditarNota(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");
            List<AlumnoInscripcion> alumnos = new InscripcionLogic().GetAll();
            AlumnoInscripcion alu = alumnos.Where(a => a.ID == id).FirstOrDefault();

            return View(alu);
        }

        [HttpPost]
        public ActionResult EditarNota(AlumnoInscripcion alumno)
        {
            alumno.State = BusinessEntity.States.Modified;
            new InscripcionLogic().Save(alumno);

            return RedirectToAction("RegistrarNotas","Home");
        }

        private bool ValidarInscripcion(int idAlumno, int idCurso)
        {
            bool valida = true;
            List<AlumnoInscripcion> inscripciones = new InscripcionLogic().GetAll();
            foreach (AlumnoInscripcion ai in inscripciones)
            {
                if (idAlumno == ai.IDAlumno && idCurso == ai.IDCurso)
                {
                    valida = false;
                }               
            }
            return valida;
        }
    }
}
