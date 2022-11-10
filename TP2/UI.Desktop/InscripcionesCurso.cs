using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class frmInscripcionesCurso : ApplicationForm
    {
        public Persona Alumno { get; set; }
        public frmInscripcionesCurso()
        {
            InitializeComponent();
        }
        public frmInscripcionesCurso(Usuario usuarioActual):this()
        {
            Alumno = new PersonaLogic().GetOne(usuarioActual.IdPersona);
        }
        
        public void Listar()
        {
            IEnumerable<AlumnoInscripcion> inscripciones = new InscripcionLogic().GetAll();
            inscripciones = inscripciones.Where(i => i.IDAlumno == Alumno.ID);
            List<AlumnoInscripcion> listaInscripciones = new();
            foreach (AlumnoInscripcion ai in inscripciones)
            {
                listaInscripciones.Add(ai);
            }

            dgvInscripciones.AutoGenerateColumns = false;
            dgvInscripciones.DataSource = listaInscripciones;

            foreach (DataGridViewRow fila in dgvInscripciones.Rows)
            {
                Curso cursoActual = new CursoLogic().GetOne((int)fila.Cells["idcurso"].Value);
                fila.Cells["materia"].Value = new MateriaLogic().GetOne(cursoActual.IDMateria).Descripcion;
                fila.Cells["comision"].Value = new ComisionLogic().GetOne(cursoActual.IDComision).Descripcion;
            }
        }

        private void frmInscripcionesCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion ai = new();
            new frmInscripcionDesktop(ai,Alumno).ShowDialog();
            Listar();
            
        }

        //private void tsbEliminar_Click(object sender, EventArgs e)
        //{
        //    if (this.dgvInscripciones.SelectedRows.Count > 0)
        //    {
        //        int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
        //        frmInscripcionDesktop formInscripcion = new (ID);
        //        formInscripcion.ShowDialog();
        //        this.Listar();
        //    }
        //}
    }
}
