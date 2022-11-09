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
    public partial class frmDocentesCursos : ApplicationForm
    {
        public frmDocentesCursos()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new();
            dgvDocentes.AutoGenerateColumns = false;
            dgvDocentes.DataSource = dcl.GetAll();
        }

        private void frmDocentesCursos_Load(object sender, EventArgs e)
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
            frmDocenteCursoDesktop formDocenteCurso = new frmDocenteCursoDesktop(ApplicationForm.ModoForm.Alta);
            formDocenteCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocentes.SelectedRows.Count > 0)
            {
                int ID = ((DocenteCurso)this.dgvDocentes.SelectedRows[0].DataBoundItem).ID;
                frmDocenteCursoDesktop formDocenteCurso = new frmDocenteCursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formDocenteCurso.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocentes.SelectedRows.Count > 0)
            {
                int ID = ((DocenteCurso)this.dgvDocentes.SelectedRows[0].DataBoundItem).ID;
                frmDocenteCursoDesktop formDocenteCurso = new frmDocenteCursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formDocenteCurso.ShowDialog();
                this.Listar();
            }
        }
    }
}
