using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmRegistroNotas : ApplicationForm
    {
        public frmRegistroNotas(Usuario usuarioLogueado)
        {
            InitializeComponent();
            UsuarioActual = usuarioLogueado;
        }
        public Usuario UsuarioActual { get; set; }

        private void frmRegistroNotas_Load(object sender, EventArgs e)
        {
            Persona docente = new PersonaLogic().GetOne(UsuarioActual.IdPersona);
            IEnumerable<DocenteCurso> dictados = new DocenteCursoLogic().GetAll();
            List<Curso> cursos = new CursoLogic().GetAll();
            List<Curso> cursos_docente = new();
            dictados = dictados.Where(d => d.IDDocente == docente.ID);
            foreach (DocenteCurso dictado in dictados)
            {
                foreach (Curso curso in cursos)
                {
                    if (curso.ID == dictado.IDCurso)
                    {
                        cursos_docente.Add(curso);
                    }
                }
            }
            foreach (Curso c in cursos_docente)
            {
                Comision comision = new ComisionLogic().GetOne(c.IDComision);
                Materia materia = new MateriaLogic().GetOne(c.IDMateria);                
                c.Descripcion = materia.Descripcion + " - " + comision.Descripcion;                              
            }
            cboCursos.DataSource = cursos_docente;
            cboCursos.DisplayMember = "descripcion";
            cboCursos.ValueMember = "ID";
        }

        private void btnCargaGrilla_Click(object sender, EventArgs e)
        {
            IEnumerable<AlumnoInscripcion> inscripciones = new InscripcionLogic().GetAll();
            inscripciones = inscripciones.Where(i => i.IDCurso == (int)cboCursos.SelectedValue);
            List<AlumnoInscripcion> listInscripciones = new();
            foreach (AlumnoInscripcion ai in inscripciones)
            {
                listInscripciones.Add(ai);
            }
            dgvAlumnosInscripcion.AutoGenerateColumns = false;
            dgvAlumnosInscripcion.DataSource = listInscripciones;

            foreach (DataGridViewRow fila in dgvAlumnosInscripcion.Rows)
            {
                fila.Cells["alumno"].Value = new PersonaLogic().GetOne((int)fila.Cells["idalumno"].Value).Legajo;
            }
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            if (dgvAlumnosInscripcion.SelectedRows.Count > 0)
            {
                AlumnoInscripcion inscripcion = ((AlumnoInscripcion)dgvAlumnosInscripcion.SelectedRows[0].DataBoundItem);
                new frmModificaNota(inscripcion).ShowDialog();
                btnCargaGrilla_Click(sender, e);
            }
        }
    }
}
