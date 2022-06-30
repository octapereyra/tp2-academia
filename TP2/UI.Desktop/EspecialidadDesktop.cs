using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class frmEspecialidadDesktop : ApplicationForm
    {
        public frmEspecialidadDesktop()//1
        {
            InitializeComponent();
        }

        private Especialidad _EspecialidadActual;
        public Especialidad EspecialidadActual { get => _EspecialidadActual; set => _EspecialidadActual = value; }
        public frmEspecialidadDesktop(ModoForm modo) : this() //2
        {
            this.Modo = modo;
        }

        public frmEspecialidadDesktop(int idEspecialidad, ModoForm modo) : this() //3
        {
            this.Modo = modo;
            EspecialidadLogic espLogic = new EspecialidadLogic();
            EspecialidadActual = espLogic.GetOne(idEspecialidad);

            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
           
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            EspecialidadLogic espLogic = new EspecialidadLogic();
            Especialidad nuevoEsp = new Especialidad();
            EspecialidadActual = nuevoEsp;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                nuevoEsp.Descripcion = this.txtDescripcion.Text;
                if (Modo == ModoForm.Alta)
                {
                    nuevoEsp.State = BusinessEntity.States.New;
                    espLogic.Save(nuevoEsp);
                }
                if (Modo == ModoForm.Modificacion)
                {
                    nuevoEsp.ID = int.Parse(this.txtID.Text);
                    nuevoEsp.State = BusinessEntity.States.Modified;
                    espLogic.Save(nuevoEsp);
                }
            }
            if (Modo == ModoForm.Baja)
            {
                nuevoEsp.ID = int.Parse(this.txtID.Text);
                nuevoEsp.State = BusinessEntity.States.Deleted;
                espLogic.Save(nuevoEsp);
            }

        }
        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic espLogic = new EspecialidadLogic();
            try
            {
                espLogic.Save(EspecialidadActual);
            }
            catch (Exception exc)
            {
                DialogResult result = MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public override bool Validar()
        {
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                Notificar("Error", "No puede haber campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "especialidad").Equals(DialogResult.Yes))
                {
                    GuardarCambios();
                    this.Close();
                }
            }
            else if (Validar())
            {                              
                GuardarCambios();
                Close();                
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
