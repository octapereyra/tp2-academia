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
    public partial class frmCursos : ApplicationForm
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            CursoLogic cl = new();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cl.GetAll();
        }

        private void frmCursos_Load(object sender, EventArgs e)
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
            frmCursoDesktop formCurso = new frmCursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count > 0)
            {
                int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                frmCursoDesktop formCurso = new frmCursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formCurso.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count > 0)
            {
                int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                frmCursoDesktop formCurso = new frmCursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formCurso.ShowDialog();
                this.Listar();
            }
        }
    }
}
