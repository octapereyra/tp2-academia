using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class frmInscripcionDesktop : ApplicationForm
    {
        public frmInscripcionDesktop()
        {
            InitializeComponent();          
        }

        private AlumnoInscripcion _InscripcionActual;
        private Persona _alumnoActual;
        public AlumnoInscripcion InscripcionActual { get => _InscripcionActual; set => _InscripcionActual = value; }
        public Persona AlumnoActual { get => _alumnoActual; set => _alumnoActual = value; }
        public frmInscripcionDesktop(AlumnoInscripcion inscripcion, Persona alumno) : this() 
        {
            InscripcionActual = inscripcion;
            AlumnoActual = alumno;
            CargaComboBoxMaterias();
        }

        private void CargaComboBoxMaterias()
        {
            IEnumerable<Materia> materias = new MateriaLogic().GetAll();
            materias = materias.Where(m => m.IDPlan == AlumnoActual.IDPLan);
            List<Materia> listaMaterias = new();
            foreach (Materia m in materias)
            {
                listaMaterias.Add(m);
            }

            cboMaterias.Enabled = true;
            cboMaterias.DataSource = listaMaterias;
            cboMaterias.DisplayMember = "descripcion";
        }
        private void CargaComboBoxComisiones()
        {
            int idMateria = ((Materia)cboMaterias.SelectedValue).ID;
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDMateria == idMateria  && c.Cupo > 0);
            List<Comision> comisiones = new();
            foreach (Curso curso in cursos)
            {
                comisiones.Add(new ComisionLogic().GetOne(curso.IDComision));
            }

            cboComisiones.Enabled = true;
            cboComisiones.DataSource = comisiones;
            cboComisiones.DisplayMember = "descripcion";
        }    

        //public override void MapearDeDatos()
        //{      
        //    lblIDInscripcion.Text = InscripcionActual.ID.ToString();          
        //    cboMaterias.SelectedValue = cur.IDMateria;
        //    cboComisiones.SelectedValue = cur.IDComision;
        //}

        public override void MapearADatos()
        {
            int idMateria = ((Materia)cboMaterias.SelectedValue).ID;
            int idComision = ((Comision)cboComisiones.SelectedValue).ID;
            Curso curso = new();
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDComision == idComision && c.IDMateria == idMateria);
            curso = cursos.First();
            AlumnoInscripcion inscripcion = new()
            {
                IDCurso = curso.ID,
                IDAlumno = AlumnoActual.ID,
                Condicion = "Inscripto",
                Nota = 0,
                State = BusinessEntity.States.New,
            };
            InscripcionActual = inscripcion;
        }
     
        public override void GuardarCambios()
        {          
            InscripcionLogic insLogic = new();
            try
            {
                insLogic.Save(InscripcionActual);
            }
            catch (Exception exc)
            {
                DialogResult result = MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public override bool Validar()
        {
            bool valida = true;

            if (cboComisiones.SelectedIndex == -1 || cboMaterias.SelectedIndex == -1)
            {
                Notificar("Error", "Debes seleccionar materia y comisión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valida = false;
            }

            List<AlumnoInscripcion> inscripciones = new InscripcionLogic().GetAll();
            foreach (AlumnoInscripcion ai in inscripciones)
            {
                if (AlumnoActual.ID == ai.IDAlumno && InscripcionActual.IDCurso == ai.IDCurso)
                {
                    Notificar("Error", "Ya estás inscripto a ese curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valida = false;
                }
            }
            return valida;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MapearADatos();
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMaterias_SelectedValueChanged(object sender, EventArgs e)
        {
            CargaComboBoxComisiones();
        }
    }
}
