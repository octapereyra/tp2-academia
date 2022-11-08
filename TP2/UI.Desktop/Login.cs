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
    public partial class frmLogin : ApplicationForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private Usuario _UsuarioActual;
        public Usuario UsuarioActual
        {
            get => _UsuarioActual; set => _UsuarioActual = value;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginLogic ll = new();
                UsuarioActual = ll.GetUsuario(txtUsuario.Text.Trim(), txtPass.Text.Trim());
                if (UsuarioActual != null)
                {
                    if (UsuarioActual.Habilitado)
                    {                       
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no esta habilitado para ingresar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception exe)
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo mas tarde.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

    }
}
