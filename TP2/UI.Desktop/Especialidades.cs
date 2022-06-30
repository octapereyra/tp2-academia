﻿using System;
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
    public partial class frmEspecialidades : ApplicationForm
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            EspecialidadLogic el = new();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = el.GetAll();
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
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
            frmEspecialidadDesktop formEspecialidad = new frmEspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count > 0)
            {
                int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                frmEspecialidadDesktop formEspecialidad = new frmEspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formEspecialidad.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count > 0)
            {
                int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                frmEspecialidadDesktop formEspecialidad = new frmEspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
                formEspecialidad.ShowDialog();
                this.Listar();
            }
        }
    }
}
