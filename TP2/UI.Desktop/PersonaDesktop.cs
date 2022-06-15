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
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class frmPersonaDesktop : ApplicationForm
    {
        public frmPersonaDesktop()
        {
            InitializeComponent();
        }

        public frmPersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public frmPersonaDesktop(int idPersona, ModoForm modo) : this()
        {
            this.Modo = modo;
            PersonaLogic pl = new();
            PersonaActual = pl.GetOne(idPersona);
            MapearDeDatos();
        }

        private Persona _PersonaActual;

        public Persona PersonaActual { get => _PersonaActual; set => _PersonaActual = value; }

        private int SeleccionarTipoPersona()
        {
            for (int i = 0; i < this.cboTipoPersona.Items.Count; i++)
            {
                if ((this.cboTipoPersona.Items[i] as dynamic).Value == this.PersonaActual.GetIDTipoPersona().ToString())
                {
                    return i;
                }
            };

            return -1;
        }
        public override void MapearDeDatos()
        {
            txtID.Text = PersonaActual.ID.ToString();
            txtApellido.Text = PersonaActual.Apellido;
            txtNombre.Text = PersonaActual.Nombre;
            txtDireccion.Text = PersonaActual.Direccion;
            txtLegajo.Text = PersonaActual.Legajo.ToString();
            txtMail.Text = PersonaActual.Email;
            dtpFechaNacimiento.Value = PersonaActual.FechaNacimiento;
            txtTelefono.Text = PersonaActual.Telefono;
            cboPlan.SelectedIndex = PersonaActual.IDPLan - 1;
            cboTipoPersona.SelectedIndex = PersonaActual.GetIDTipoPersona();

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
                Persona persona = new();
                PersonaActual = persona;
            }
            else
            {
                PersonaActual.ID = int.Parse(txtID.Text);
            }

            PersonaActual.Apellido = txtApellido.Text;
            PersonaActual.Nombre = txtNombre.Text;
            PersonaActual.Direccion = txtDireccion.Text;
            PersonaActual.Legajo = int.Parse(txtLegajo.Text);
            PersonaActual.Email = txtMail.Text;
            PersonaActual.FechaNacimiento = dtpFechaNacimiento.Value;
            PersonaActual.Telefono = txtTelefono.Text;
            PersonaActual.IDPLan = cboPlan.SelectedIndex + 1;
            PersonaActual.SetTipoPersonaById(cboTipoPersona.SelectedIndex);

            switch (Modo)
            {
                case ModoForm.Alta:
                    PersonaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    PersonaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    PersonaActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            PersonaLogic pl = new();
            pl.Save(PersonaActual);
        }

        private static bool ValidarEmail(string email)
        {
            String expresion;
            bool rta = false;
            expresion = @"\A(\w+.?\w*@\w+.)(com)\Z";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    rta = true;
                }
            }
            return rta;
        }

        private bool ValidarCamposVacios()
        {
            bool rta = false;
            List<TextBox> txtboxs = new();
            txtboxs.Add(txtApellido);
            txtboxs.Add(txtDireccion);
            txtboxs.Add(txtLegajo);
            txtboxs.Add(txtMail);
            txtboxs.Add(txtNombre);
            txtboxs.Add(txtTelefono);

            foreach (TextBox txtbox in txtboxs) //compruebo textboxs
            {
                if (txtbox.Text.Trim().Equals(string.Empty))
                {
                    rta = true;
                }
            }

            if (cboPlan.SelectedIndex == -1 || cboTipoPersona.SelectedIndex == -1) //compruebo combos
            {
                rta = true;
            }

            return rta;
        }
    
        public override bool Validar()
        {
            bool rta = true;

            if (ValidarCamposVacios())
            {
                Notificar("Ficha de persona vacía", "No puede haber campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rta = false;
            }
            if (rta)
            {
                if (!ValidarEmail(txtMail.Text))
                {
                    Notificar("Email incorrecto", "El email ingresado no tiene el formato correcto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rta = false;
                }
                if (!int.TryParse(txtLegajo.Text, out int _))
                {
                    Notificar("Legajo incorrecto", "El legajo debe ser un número", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rta = false;
                }
            }
            
            return rta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "persona").Equals(DialogResult.Yes))
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
