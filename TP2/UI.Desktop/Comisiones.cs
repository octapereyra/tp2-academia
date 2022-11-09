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
    public partial class frmComisiones : ApplicationForm
    {
        public frmComisiones()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            ComisionLogic cl = new();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.DataSource = cl.GetAll();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmComisionDesktop formComision = new(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count > 0)
            {
                int ID = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                frmComisionDesktop frmComision = new(ID, ApplicationForm.ModoForm.Modificacion);
                frmComision.ShowDialog();
                this.Listar();
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count > 0)
            {
                int ID = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                frmComisionDesktop frmComision = new(ID, ApplicationForm.ModoForm.Baja);
                frmComision.ShowDialog();
                this.Listar();
            }
        }
    }
}
