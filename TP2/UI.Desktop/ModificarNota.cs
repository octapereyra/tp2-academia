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
    public partial class frmModificaNota : ApplicationForm
    {
        public AlumnoInscripcion InscripcionActual { get; set; }
        public Persona AlumnoActual { get; set; }
        public frmModificaNota()
        {
            InitializeComponent();
        }

        public frmModificaNota(AlumnoInscripcion ai) : this()
        {
            InscripcionActual = ai;
            AlumnoActual = new PersonaLogic().GetOne(ai.IDAlumno);
            lblAlumno.Text = AlumnoActual.Legajo + " - " + AlumnoActual.Apellido + " " + AlumnoActual.Nombre;
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtCondicion.Text = InscripcionActual.Condicion;
            txtNota.Text = InscripcionActual.Nota.ToString();
        }
        public override void MapearADatos()
        {
            InscripcionActual.Condicion = txtCondicion.Text.Trim();
            InscripcionActual.Nota = int.Parse(txtNota.Text.Trim());           
        }
        public override bool Validar()
        {
            bool valida = true;
            if (String.IsNullOrWhiteSpace(txtCondicion.Text) || !uint.TryParse(txtNota.Text, out _))
            {
                valida = false;
                Notificar("Error", "Ingrese los datos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtNota.Text) > 10)
            {
                valida = false;
                Notificar("Error", "La nota no puede ser superior a 10", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valida;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            try
            {
                InscripcionActual.State = BusinessEntity.States.Modified;
                new InscripcionLogic().Save(InscripcionActual);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }
    }
}
