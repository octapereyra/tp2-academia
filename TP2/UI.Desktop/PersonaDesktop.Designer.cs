
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblLegajo = new System.Windows.Forms.Label();
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
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tlpUsuarioDesktop.Controls.Add(this.lblID, 0, 0);
            this.tlpUsuarioDesktop.Controls.Add(this.lblApellido, 0, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.lblPlan, 0, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuarioDesktop.Controls.Add(this.txtApellido, 1, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.txtNombre, 3, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.txtDireccion, 3, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.lblNombre, 2, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.lblDireccion, 2, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.cboPlan, 1, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.lblMail, 0, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.lblTelefono, 2, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.txtMail, 1, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.txtTelefono, 3, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.btnAceptar, 2, 6);
            this.tlpUsuarioDesktop.Controls.Add(this.btnCancelar, 3, 6);
            this.tlpUsuarioDesktop.Controls.Add(this.lblLegajo, 0, 4);
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
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(3, 35);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(3, 70);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(30, 15);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan";
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
            this.txtApellido.Size = new System.Drawing.Size(183, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(643, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(643, 73);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(183, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(526, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(526, 70);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección";
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Plan 2008",
            "Plan 2023"});
            this.cboPlan.Location = new System.Drawing.Point(122, 73);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(100, 23);
            this.cboPlan.TabIndex = 3;
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
            this.lblTelefono.Location = new System.Drawing.Point(526, 106);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(122, 109);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(183, 23);
            this.txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(643, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(183, 23);
            this.txtTelefono.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(526, 246);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(643, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(3, 152);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 15);
            this.lblLegajo.TabIndex = 22;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(526, 152);
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
            this.txtLegajo.TabIndex = 7;
            // 
            // cboTipoPersona
            // 
            this.cboTipoPersona.FormattingEnabled = true;
            this.cboTipoPersona.Items.AddRange(new object[] {
            "Estudiante",
            "Docente",
            "Administrativo"});
            this.cboTipoPersona.Location = new System.Drawing.Point(122, 195);
            this.cboTipoPersona.Name = "cboTipoPersona";
            this.cboTipoPersona.Size = new System.Drawing.Size(183, 23);
            this.cboTipoPersona.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(643, 155);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(222, 23);
            this.dtpFechaNacimiento.TabIndex = 8;
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
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblTipoPers;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox cboTipoPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}