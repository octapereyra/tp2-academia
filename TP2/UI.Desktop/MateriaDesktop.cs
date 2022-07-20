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
    public partial class frmMateriaDesktop : ApplicationForm
    {
        public frmMateriaDesktop()
        {
            InitializeComponent();
            CargarEspecialidades();
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

        public frmMateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public frmMateriaDesktop(int idMateria, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic ml = new();
            MateriaActual = ml.GetOne(idMateria);
            MapearDeDatos();
        }

        private void CargarEspecialidades()
        {
            EspecialidadLogic el = new();
            cboEspecialidad.DataSource = el.GetAll();
            cboEspecialidad.DisplayMember = "descripcion";
        }
        private void CargarPlanes(int idEspecialidad)
        {
            cboPlan.Enabled = true;
            PlanLogic pl = new();
            cboPlan.DataSource = pl.GetPlanesByEspecialidad(idEspecialidad);
            cboPlan.DisplayMember = "descripcion";
        }

        private Materia _MateriaActual;

        public Materia MateriaActual { get => _MateriaActual; set => _MateriaActual = value; }

        public override void MapearDeDatos()
        {
            txtID.Text = MateriaActual.ID.ToString();
            txtDescripcion.Text = MateriaActual.Descripcion;
            txtHsSem.Text = MateriaActual.HSSemanales.ToString();
            txtHsTot.Text = MateriaActual.HSTotales.ToString();
            cboPlan.SelectedValue = MateriaActual.IDPlan;          
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Materia materia = new();
                MateriaActual = materia;
            }
            else
            {
                MateriaActual.ID = int.Parse(txtID.Text);
            }

            MateriaActual.Descripcion = txtDescripcion.Text;
            MateriaActual.HSSemanales = int.Parse(txtHsSem.Text);
            MateriaActual.HSTotales = int.Parse(txtHsTot.Text);
            MateriaActual.IDPlan = (int)cboPlan.SelectedValue;

            switch (Modo)
            {
                case ModoForm.Alta:
                    MateriaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    MateriaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    MateriaActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ml = new();
            try
            {
                ml.Save(MateriaActual);
            }
            catch (Exception)
            {
                Notificar("Error crítico", "Error al guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override bool Validar()
        {
            bool result = true;
            string errorString = string.Empty;

            List<TextBox> txtboxs = new();
            txtboxs.Add(txtHsSem);
            txtboxs.Add(txtDescripcion);
            txtboxs.Add(txtHsTot);

            foreach (TextBox txt in txtboxs)
            {
                if (txt.Text.Trim() == string.Empty)
                {
                    result = false;
                }
            }

            if (!result || cboPlan.SelectedIndex == -1)
            {
                errorString = "Debe completar todos los campos\n";
                result = false;
            }

            if (!(uint.TryParse(txtHsSem.Text, out _) && uint.TryParse(txtHsTot.Text, out _)) || int.Parse(txtHsTot.Text) < int.Parse(txtHsSem.Text))
            {
                errorString = errorString + "La/s hora/s ingresada/s son inválidas\n";
                result = false;
            }

            if (errorString != String.Empty) 
            {
                Notificar("Error", errorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "materia").Equals(DialogResult.Yes))
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
        private void cboEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
            cboPlan.Text = "";
            CargarPlanes(((Especialidad)cboEspecialidad.SelectedValue).ID);         
        }
    }
}
