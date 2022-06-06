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

        private Materia _MateriaActual;

        public Materia MateriaActual { get => _MateriaActual; set => _MateriaActual = value; }

        public override void MapearDeDatos()
        {
            txtID.Text = MateriaActual.ID.ToString();
            txtDescripcion.Text = MateriaActual.Descripcion;
            txtHsSem.Text = MateriaActual.HSSemanales.ToString();
            txtHsTot.Text = MateriaActual.HSTotales.ToString();
            cboPlan.SelectedIndex = MateriaActual.IDPlan - 1; //revisar esto

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
            MateriaActual.IDPlan = cboPlan.SelectedIndex + 1;

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
            ml.Save(MateriaActual);
        }
        public override bool Validar()
        {
            bool result = true;

            List<TextBox> txtboxs = new();
            txtboxs.Add(txtHsSem);
            txtboxs.Add(txtDescripcion);
            txtboxs.Add(txtHsTot);

            foreach (TextBox txt in txtboxs)
            {
                if(txt.Text.Trim() == string.Empty)
                {
                    result = false;
                }
            }

            if (!result)
            {
                Notificar("Debe completar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(int.TryParse(txtHsSem.Text, out _) || int.TryParse(txtHsTot.Text, out _)))
            {
                Notificar("La/s hora/s ingresada/s son inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }


            if (cboPlan.SelectedIndex == -1)
            {
                result = false;
                Notificar("Debe elegir un plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            return result;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
