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
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmComisionDesktop formComision = new frmComisionDesktop(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();
            this.Listar();
        }
    }
}
