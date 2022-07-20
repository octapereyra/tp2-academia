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
    public partial class frmPlanes : ApplicationForm
    {
        public frmPlanes()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            PlanLogic pl = new();
            dgvPlanes.AutoGenerateColumns = false;
            dgvPlanes.DataSource = pl.GetAll();
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
            frmPlanDesktop frmPlan = new frmPlanDesktop(ApplicationForm.ModoForm.Alta);
            frmPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count > 0)
            {
                int id = ((Plan)(dgvPlanes.SelectedRows[0].DataBoundItem)).ID;
                frmPlanDesktop frmPlan = new frmPlanDesktop(id, ApplicationForm.ModoForm.Modificacion);
                frmPlan.ShowDialog();
                this.Listar();
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count > 0)
            {
                int id = ((Plan)(dgvPlanes.SelectedRows[0].DataBoundItem)).ID;
                frmPlanDesktop frmPlan = new frmPlanDesktop(id, ApplicationForm.ModoForm.Baja);
                frmPlan.ShowDialog();
                this.Listar();
            }
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
