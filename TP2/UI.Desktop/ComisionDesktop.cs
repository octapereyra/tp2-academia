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
    public partial class frmComisionDesktop : ApplicationForm
    {
        private Comision _ComisionActual;

        public Comision ComisionActual { get => _ComisionActual; set => _ComisionActual = value; }
        public frmComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public frmComisionDesktop(int idComision, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic comLogic = new ComisionLogic();
            ComisionActual = comLogic.GetOne(idComision);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescComision.Text = this.ComisionActual.Descripcion;
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            cboPlan.SelectedValue = this.ComisionActual.IDPlan.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            ComisionLogic comLogic = new ComisionLogic();
            Comision nuevaComi = new Comision();
            ComisionActual = nuevaComi;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                nuevaComi.Descripcion = this.txtDescComision.Text;
                nuevaComi.AnioEspecialidad = int.Parse(txtAnioEspecialidad.Text);
                nuevaComi.IDPlan = (int)cboPlan.SelectedValue;

                if (Modo == ModoForm.Alta)
                {
                    nuevaComi.State = BusinessEntity.States.New;
                    comLogic.Save(nuevaComi);
                }
                if (Modo == ModoForm.Modificacion)
                {
                    nuevaComi.ID = int.Parse(txtID.Text);
                    nuevaComi.State = BusinessEntity.States.Modified;
                    comLogic.Save(nuevaComi);
                }              
            }
            if (Modo == ModoForm.Baja)
            {
                nuevaComi.ID = int.Parse(txtID.Text);
                nuevaComi.State = BusinessEntity.States.Deleted;
                comLogic.Save(nuevaComi);
            }
        }

        public override bool Validar()
        {
            Boolean rta = true;
            string errorString = String.Empty;

            if (txtDescComision.Text == String.Empty || txtAnioEspecialidad.Text == String.Empty || cboPlan.SelectedIndex == -1 ) 
            { 
                rta = false;
            }

            if(!rta)
            {
                errorString = "No puede haber campos vaíos\n";
            }

            if (errorString != String.Empty)
            {
                Notificar("Error", errorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rta;
        }

        public frmComisionDesktop()
        {
            InitializeComponent();
            CargarPlanes();
        }

        private void CargarPlanes()
        {
            cboPlan.DataSource = new PlanLogic().GetAll();
            cboPlan.ValueMember = "id";
            cboPlan.DisplayMember = "descripcion";
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic comLogic = new ComisionLogic();
            
            try
            {
                comLogic.Save(ComisionActual);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "comision").Equals(DialogResult.Yes))
                {
                    GuardarCambios();
                    this.Close();
                }
            }

            else
            {
                if (Validar())
                {
                    GuardarCambios();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
