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
    public partial class frmPlanDesktop : ApplicationForm
    {
        public frmPlanDesktop()
        {
            InitializeComponent();
            CargarCombo();         
        }
        public frmPlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;          
        }

        public frmPlanDesktop(int idPlan, ModoForm modo) : this()
        {
            this.Modo = modo;          
            PlanLogic pl = new();
            PlanActual = pl.GetOne(idPlan);
            MapearDeDatos();
        }

        private Plan _PlanActual;

        public Plan PlanActual { get => _PlanActual; set => _PlanActual = value; }

        private void CargarCombo()
        {
            EspecialidadLogic el = new();
            cboEspecialidad.DataSource = el.GetAll();
            cboEspecialidad.DisplayMember = "descripcion";
            cboEspecialidad.ValueMember = "ID";
        }

        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;          
            cboEspecialidad.SelectedValue = PlanActual.IDEspecialidad;
            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Plan plan = new();
                PlanActual = plan;
            }
            else
            {
                PlanActual.ID = int.Parse(txtID.Text);
            }

            PlanActual.Descripcion = txtDescripcion.Text.Trim();
            PlanActual.IDEspecialidad = (int)cboEspecialidad.SelectedValue;

            switch (Modo)
            {
                case ModoForm.Alta:
                    PlanActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    PlanActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    PlanActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    PlanActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic pl = new();
            try
            {
                pl.Save(PlanActual);
            }
            catch (Exception)
            {
                Notificar("Error crítico", "Error al guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override bool Validar()
        {
            bool validate = true;
            string errorMsg = string.Empty;

            if (txtDescripcion.Text.Trim() == string.Empty)
            {
                errorMsg += "Debe ingresar una descripción";
                validate = false;
            }
            if (cboEspecialidad.SelectedIndex == -1)
            {
                errorMsg += "Debe seleccionar una especialidad";
                validate = false;
            }
            if (errorMsg != String.Empty)
            {
                Notificar("Error", errorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return validate;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "plan").Equals(DialogResult.Yes))
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
            Close();
        }
    }
}
