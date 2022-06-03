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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            MateriaLogic ml = new();
            dgvMaterias.DataSource = ml.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
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

        private void tabNuevo_Click(object sender, EventArgs e)
        {
            frmMateriaDesktop md = new(ApplicationForm.ModoForm.Alta);
            md.ShowDialog();
            Listar();
        }

        private void tabEditar_Click(object sender, EventArgs e)
        {
            int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            frmMateriaDesktop md = new(id, ApplicationForm.ModoForm.Modificacion);
            md.ShowDialog();
            Listar();
        }

        private void tabEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            frmMateriaDesktop md = new(id, ApplicationForm.ModoForm.Baja);
            md.ShowDialog();
            Listar();
        }
    }
}
