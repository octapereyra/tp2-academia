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
            cboTipoPersona.SelectedIndex = SeleccionarTipoPersona();

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
            PersonaActual.IDPLan = cboPlan.SelectedIndex;
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

        public static bool ValidarEmail(string email)
        {
            String expresion;
            bool rta2 = false;
            expresion = @"\A(\w+.?\w*@\w+.)(com)\Z";


            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    rta2 = true;
                }
            }
            return rta2;
        }
        public override bool Validar()
        {
            bool rta = false;

            if (txtLegajo.Text != String.Empty && txtNombre.Text != String.Empty
                && txtApellido.Text != String.Empty && txtMail.Text != String.Empty
                && txtTelefono.Text != String.Empty && txtDireccion.Text != String.Empty
                && cboPlan.SelectedIndex != -1 && cboTipoPersona.SelectedIndex != -1)
            {
                if (!rta)
                {
                    rta = ValidarEmail(txtMail.Text);
                    if (!rta)
                    {
                        Notificar("Email inválido",
                                  "Revise su correo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Notificar("Ficha de persona vacía",
                          "No puede haber campos vacíos",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            }

            return rta;
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
