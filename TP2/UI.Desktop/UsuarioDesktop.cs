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
    public partial class frmUsuarioDesktop : ApplicationForm 
    {
        private Usuario _UsuarioActual;
        public Usuario UsuarioActual { get => _UsuarioActual; set => _UsuarioActual = value; }
        public frmUsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public frmUsuarioDesktop(int idUsuario, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usrLogic = new UsuarioLogic();
            UsuarioActual = usrLogic.GetOne(idUsuario);

            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            cboPersona.SelectedValue = UsuarioActual.IdPersona;
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
            UsuarioLogic usrLogic = new UsuarioLogic();
            Usuario nuevoUsu = new Usuario();
            UsuarioActual = nuevoUsu;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                nuevoUsu.Nombre = this.txtNombre.Text;
                nuevoUsu.Apellido = this.txtApellido.Text;
                nuevoUsu.Clave = this.txtClave.Text;
                nuevoUsu.EMail = this.txtEmail.Text;
                nuevoUsu.NombreUsuario = this.txtUsuario.Text;
                nuevoUsu.IdPersona = (int)cboPersona.SelectedValue;
                nuevoUsu.Habilitado = this.chkHabilitado.Checked;

                if (Modo == ModoForm.Alta)
                {
                    nuevoUsu.State = BusinessEntity.States.New;
                    usrLogic.Save(nuevoUsu);
                }

                if (Modo == ModoForm.Modificacion)
                {
                    nuevoUsu.ID = int.Parse(this.txtID.Text);
                    nuevoUsu.State = BusinessEntity.States.Modified;
                    usrLogic.Save(nuevoUsu);
                }
            }

            if (Modo == ModoForm.Baja)
            {
                nuevoUsu.ID = int.Parse(this.txtID.Text);
                nuevoUsu.State = BusinessEntity.States.Deleted;
                usrLogic.Save(nuevoUsu);
            }

        }
        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            try
            {
                usuarioLogic.Save(UsuarioActual);
            }
            catch (Exception exc)
            {
                DialogResult result = MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
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
            bool rta = true;
            string errorString = string.Empty;

            if (txtUsuario.Text == String.Empty || txtNombre.Text == String.Empty
                || txtApellido.Text == String.Empty || txtClave.Text == String.Empty
                || txtConfirmarClave.Text == String.Empty || txtEmail.Text == String.Empty)
            {
                errorString += "No puede haber campos vacíos\n";
                rta = false;
            }

            if (txtClave.Text != txtConfirmarClave.Text)
            {
                errorString += "El campo Clave no coincide con el campo confirmar clave\n";
                rta = false;
            }

            if (txtClave.Text.Length >= 8)
            {
                foreach (char item in txtClave.Text)
                {
                    if (char.IsWhiteSpace(item))
                    {
                        errorString += "La contraseña no puede contener espacios en blanco\n";
                            rta = false;
                            break;
                    }
                }
            }
            else
            {
                errorString += "La contraseña debe tener al menos 8 caracteres\n";
                rta = false;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                errorString += "Revise su correo\n";
                rta = false;
            }

            if (errorString != string.Empty)
            {
                Notificar("Error", errorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rta;
        }
        public frmUsuarioDesktop()
        {
            InitializeComponent();
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            cboPersona.DataSource = new PersonaLogic().GetAll();
            cboPersona.ValueMember = "id";
            cboPersona.DisplayMember = "legajo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "usuario").Equals(DialogResult.Yes))
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
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
