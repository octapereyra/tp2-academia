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
    public partial class frmPersonas : ApplicationForm
    {
        public frmPersonas()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            PersonaLogic pl = new();
            dgvPersonas.DataSource = pl.GetAll();
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
                frmPersonaDesktop frmPersona = new frmPersonaDesktop(ApplicationForm.ModoForm.Alta);
                frmPersona.ShowDialog();
                this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonas.SelectedRows.Count > 0)
            {
                int id = (int)dgvPersonas.SelectedRows[0].Cells[0].Value;
                frmPersonaDesktop frmPersona = new frmPersonaDesktop(id, ApplicationForm.ModoForm.Modificacion);
                frmPersona.ShowDialog();
                this.Listar();
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonas.SelectedRows.Count > 0)
            {
                int id = (int)dgvPersonas.SelectedRows[0].Cells[0].Value;
                frmPersonaDesktop frmPersona = new frmPersonaDesktop(id, ApplicationForm.ModoForm.Baja);
                frmPersona.ShowDialog();
                this.Listar();
            }
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
