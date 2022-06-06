
namespace UI.Desktop
{
    partial class frmPersonaDesktop
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
            this.tlpUsuarioDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.Legajo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblTipoPers = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.cboTipoPersona = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tlpUsuarioDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarioDesktop
            // 
            this.tlpUsuarioDesktop.ColumnCount = 4;
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.74368F));
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.25632F));
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tlpUsuarioDesktop.Controls.Add(this.lblID, 0, 0);
            this.tlpUsuarioDesktop.Controls.Add(this.lbApellido, 0, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.lblEmail, 0, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuarioDesktop.Controls.Add(this.txtApellido, 1, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.txtNombre, 3, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.txtDireccion, 3, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.lbNombre, 2, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.lblDireccion, 2, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.cboPlan, 1, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.lblMail, 0, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.lblTelefono, 2, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.txtMail, 1, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.txtTelefono, 3, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.btnAceptar, 2, 6);
            this.tlpUsuarioDesktop.Controls.Add(this.btnCancelar, 3, 6);
            this.tlpUsuarioDesktop.Controls.Add(this.Legajo, 0, 4);
            this.tlpUsuarioDesktop.Controls.Add(this.lblFechaNac, 2, 4);
            this.tlpUsuarioDesktop.Controls.Add(this.lblTipoPers, 0, 5);
            this.tlpUsuarioDesktop.Controls.Add(this.txtLegajo, 1, 4);
            this.tlpUsuarioDesktop.Controls.Add(this.cboTipoPersona, 1, 5);
            this.tlpUsuarioDesktop.Controls.Add(this.dtpFechaNacimiento, 3, 4);
            this.tlpUsuarioDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarioDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarioDesktop.Name = "tlpUsuarioDesktop";
            this.tlpUsuarioDesktop.RowCount = 7;
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.55556F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpUsuarioDesktop.Size = new System.Drawing.Size(946, 297);
            this.tlpUsuarioDesktop.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(3, 35);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(51, 15);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Plan";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(122, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 23);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(646, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 23);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(646, 73);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(183, 23);
            this.txtDireccion.TabIndex = 9;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(529, 35);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(529, 70);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(529, 246);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(646, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Plan 2008",
            "Plan 2023"});
            this.cboPlan.Location = new System.Drawing.Point(122, 73);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 23);
            this.cboPlan.TabIndex = 17;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(3, 106);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 15);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(529, 106);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(122, 109);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 23);
            this.txtMail.TabIndex = 20;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(646, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(183, 23);
            this.txtTelefono.TabIndex = 21;
            // 
            // Legajo
            // 
            this.Legajo.AutoSize = true;
            this.Legajo.Location = new System.Drawing.Point(3, 152);
            this.Legajo.Name = "Legajo";
            this.Legajo.Size = new System.Drawing.Size(42, 15);
            this.Legajo.TabIndex = 22;
            this.Legajo.Text = "Legajo";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(529, 152);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(101, 15);
            this.lblFechaNac.TabIndex = 23;
            this.lblFechaNac.Text = "Fecha nacimiento";
            // 
            // lblTipoPers
            // 
            this.lblTipoPers.AutoSize = true;
            this.lblTipoPers.Location = new System.Drawing.Point(3, 192);
            this.lblTipoPers.Name = "lblTipoPers";
            this.lblTipoPers.Size = new System.Drawing.Size(91, 15);
            this.lblTipoPers.TabIndex = 24;
            this.lblTipoPers.Text = "Tipo de persona";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(122, 155);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 23);
            this.txtLegajo.TabIndex = 26;
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Items.AddRange(new object[] {
            "Administrativo",
            "Docente",
            "Estudiante"});
            this.cboTipoPersona.Location = new System.Drawing.Point(122, 195);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(121, 23);
            this.cboTipoPersona.TabIndex = 28;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(646, 155);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(222, 23);
            this.dtpFechaNacimiento.TabIndex = 29;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 6, 6, 16, 36, 7, 0);
            // 
            // frmPersonaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 297);
            this.Controls.Add(this.tlpUsuarioDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPersonaDesktop";
            this.Text = "PersonaDesktop";
            this.tlpUsuarioDesktop.ResumeLayout(false);
            this.tlpUsuarioDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarioDesktop;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label Legajo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblTipoPers;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox cboTipoPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}