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
        public frmInscripcionDesktop() //Usuario usuarioLogueado
        {
            InitializeComponent();          
        }

        private AlumnoInscripcion _InscripcionActual;
        public AlumnoInscripcion InscripcionActual { get => _InscripcionActual; set => _InscripcionActual = value; }
        public frmInscripcionDesktop(AlumnoInscripcion inscripcion) : this() 
        {
            InscripcionActual = inscripcion;
            CargaComboBoxMaterias();
        }

        private void CargaComboBoxMaterias()
        {
            IEnumerable<Materia> materias = new MateriaLogic().GetAll();
            materias = materias.Where(m => m.IDPlan == new PersonaLogic().GetOne(InscripcionActual.IDAlumno).IDPLan);
            List<Materia> listaMaterias = new();
            foreach (Materia m in materias)
            {
                listaMaterias.Add(m);
            }

            cboMaterias.Enabled = true;
            cboMaterias.DataSource = listaMaterias;
            cboMaterias.ValueMember = "id";
            cboMaterias.DisplayMember = "descripcion";
        }
        private void CargaComboBoxComisiones()
        {
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDMateria == (int)cboMaterias.SelectedValue && c.Cupo > 0);
            List<Comision> comisiones = new();
            foreach (Curso curso in cursos)
            {
                comisiones.Add(new ComisionLogic().GetOne(curso.IDComision));
            }

            cboComisiones.Enabled = true;
            cboComisiones.DataSource = comisiones;
            cboComisiones.ValueMember = "id";
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
            Curso curso = new CursoLogic().GetOne(InscripcionActual.IDCurso);
            IEnumerable<Curso> cursos = new CursoLogic().GetAll();
            cursos = cursos.Where(c => c.IDComision == curso.IDComision && c.IDMateria == curso.IDMateria);
            curso = cursos.First();
            AlumnoInscripcion inscripcion = new()
            {
                IDCurso = curso.ID,
                IDAlumno = InscripcionActual.IDAlumno,
                Condicion = "Inscripto",
                Nota = 0,
                State = BusinessEntity.States.New,
            };
            InscripcionActual = inscripcion;
        }
     
        public override void GuardarCambios()
        {
            MapearADatos();
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

        //public override bool Validar()
        //{
        //    if (this.cboMaterias.SelectedIndex == -1 || this.cboComisiones.SelectedIndex==-1 )
        //    {
        //        Notificar("Error", "No puede haber campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    else return true;   
        //}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (true)//Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaterias_SelectedValueChanged(object sender, EventArgs e)
        {
            CargaComboBoxComisiones();
        }
    }
}
