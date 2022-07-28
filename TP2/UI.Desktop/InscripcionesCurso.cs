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
    public partial class frmInscripcionesCurso : Form
    {
        public frmInscripcionesCurso()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            InscripcionLogic il = new();
            dgvInscripciones.AutoGenerateColumns = false;
            dgvInscripciones.DataSource = il.GetAll();
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
            frmInscripcionDesktop frmInscripcion = new frmInscripcionDesktop(ApplicationForm.ModoForm.Alta);
            frmInscripcion.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvInscripciones.SelectedRows.Count > 0)
            {
                int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                frmInscripcionDesktop formInscripcion = new frmInscripcionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formInscripcion.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvInscripciones.SelectedRows.Count > 0)
            {
                int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                frmInscripcionDesktop formInscripcion = new frmInscripcionDesktop(ID, ApplicationForm.ModoForm.Baja);
                formInscripcion.ShowDialog();
                this.Listar();
            }
        }
    }
}
