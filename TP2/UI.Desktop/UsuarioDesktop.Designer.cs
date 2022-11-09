
namespace UI.Desktop
{
    partial class frmUsuarioDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfClave = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPersona = new System.Windows.Forms.Label();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.tlpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 4;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.53156F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.46844F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tlpUsuarios.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuarios.Controls.Add(this.txtNombre, 1, 1);
            this.tlpUsuarios.Controls.Add(this.txtEmail, 1, 2);
            this.tlpUsuarios.Controls.Add(this.txtClave, 1, 3);
            this.tlpUsuarios.Controls.Add(this.lbID, 0, 0);
            this.tlpUsuarios.Controls.Add(this.lblNombre, 0, 1);
            this.tlpUsuarios.Controls.Add(this.lblEmail, 0, 2);
            this.tlpUsuarios.Controls.Add(this.lblClave, 0, 3);
            this.tlpUsuarios.Controls.Add(this.lblApellido, 2, 1);
            this.tlpUsuarios.Controls.Add(this.lblUsuario, 2, 2);
            this.tlpUsuarios.Controls.Add(this.lblConfClave, 2, 3);
            this.tlpUsuarios.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlpUsuarios.Controls.Add(this.txtApellido, 3, 1);
            this.tlpUsuarios.Controls.Add(this.txtUsuario, 3, 2);
            this.tlpUsuarios.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlpUsuarios.Controls.Add(this.btnAceptar, 2, 5);
            this.tlpUsuarios.Controls.Add(this.btnCancelar, 3, 5);
            this.tlpUsuarios.Controls.Add(this.lblPersona, 2, 4);
            this.tlpUsuarios.Controls.Add(this.cboPersona, 3, 4);
            this.tlpUsuarios.Location = new System.Drawing.Point(1, 2);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 6;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.12644F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.87356F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpUsuarios.Size = new System.Drawing.Size(824, 340);
            this.tlpUsuarios.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(172, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(172, 149);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(137, 23);
            this.txtClave.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(3, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(163, 49);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(3, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(163, 54);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombre.UseMnemonic = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(3, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 43);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClave.Location = new System.Drawing.Point(3, 146);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(163, 44);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApellido.Location = new System.Drawing.Point(419, 49);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(118, 54);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Location = new System.Drawing.Point(419, 103);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(118, 43);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConfClave
            // 
            this.lblConfClave.AutoSize = true;
            this.lblConfClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfClave.Location = new System.Drawing.Point(419, 146);
            this.lblConfClave.Name = "lblConfClave";
            this.lblConfClave.Size = new System.Drawing.Size(118, 44);
            this.lblConfClave.TabIndex = 10;
            this.lblConfClave.Text = "Confirmar Clave";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(419, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(81, 19);
            this.chkHabilitado.TabIndex = 13;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(543, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(136, 23);
            this.txtApellido.TabIndex = 14;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(543, 106);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 23);
            this.txtUsuario.TabIndex = 15;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(543, 149);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(136, 23);
            this.txtConfirmarClave.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(419, 232);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(543, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(419, 190);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(92, 15);
            this.lblPersona.TabIndex = 17;
            this.lblPersona.Text = "Persona (legajo)";
            // 
            // cboPersona
            // 
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(543, 193);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(136, 23);
            this.cboPersona.TabIndex = 18;
            // 
            // frmUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 270);
            this.Controls.Add(this.tlpUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsuarioDesktop";
            this.Text = "Usuario";
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfClave;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ComboBox cboPersona;
    }
}