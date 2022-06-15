
namespace UI.Desktop
{
    partial class frmMateriaDesktop
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHsSem = new System.Windows.Forms.TextBox();
            this.txtHsTot = new System.Windows.Forms.TextBox();
            this.lblHsSem = new System.Windows.Forms.Label();
            this.lblHsTot = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.tlpUsuarioDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarioDesktop
            // 
            this.tlpUsuarioDesktop.ColumnCount = 4;
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.74368F));
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.25632F));
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpUsuarioDesktop.Controls.Add(this.lblId, 0, 0);
            this.tlpUsuarioDesktop.Controls.Add(this.lblNombre, 0, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.lblEmail, 0, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuarioDesktop.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.txtHsSem, 3, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.txtHsTot, 3, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.lblHsSem, 2, 1);
            this.tlpUsuarioDesktop.Controls.Add(this.lblHsTot, 2, 2);
            this.tlpUsuarioDesktop.Controls.Add(this.btnAceptar, 2, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.btnCancelar, 3, 3);
            this.tlpUsuarioDesktop.Controls.Add(this.cboPlan, 1, 2);
            this.tlpUsuarioDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarioDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarioDesktop.Name = "tlpUsuarioDesktop";
            this.tlpUsuarioDesktop.RowCount = 4;
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.55556F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpUsuarioDesktop.Size = new System.Drawing.Size(946, 143);
            this.tlpUsuarioDesktop.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Descripción";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Plan";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(123, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(167, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtHsSem
            // 
            this.txtHsSem.Location = new System.Drawing.Point(647, 37);
            this.txtHsSem.Name = "txtHsSem";
            this.txtHsSem.Size = new System.Drawing.Size(88, 23);
            this.txtHsSem.TabIndex = 2;
            // 
            // txtHsTot
            // 
            this.txtHsTot.Location = new System.Drawing.Point(647, 76);
            this.txtHsTot.Name = "txtHsTot";
            this.txtHsTot.Size = new System.Drawing.Size(88, 23);
            this.txtHsTot.TabIndex = 4;
            // 
            // lblHsSem
            // 
            this.lblHsSem.AutoSize = true;
            this.lblHsSem.Location = new System.Drawing.Point(530, 34);
            this.lblHsSem.Name = "lblHsSem";
            this.lblHsSem.Size = new System.Drawing.Size(97, 15);
            this.lblHsSem.TabIndex = 12;
            this.lblHsSem.Text = "Horas Semanales";
            // 
            // lblHsTot
            // 
            this.lblHsTot.AutoSize = true;
            this.lblHsTot.Location = new System.Drawing.Point(530, 73);
            this.lblHsTot.Name = "lblHsTot";
            this.lblHsTot.Size = new System.Drawing.Size(77, 15);
            this.lblHsTot.TabIndex = 13;
            this.lblHsTot.Text = "Horas Totales";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(530, 115);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(647, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
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
            this.cboPlan.Location = new System.Drawing.Point(123, 76);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 23);
            this.cboPlan.TabIndex = 3;
            // 
            // frmMateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 143);
            this.Controls.Add(this.tlpUsuarioDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMateriaDesktop";
            this.Text = "MateriaDesktop";
            this.tlpUsuarioDesktop.ResumeLayout(false);
            this.tlpUsuarioDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarioDesktop;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHsSem;
        private System.Windows.Forms.TextBox txtHsTot;
        private System.Windows.Forms.Label lblHsSem;
        private System.Windows.Forms.Label lblHsTot;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboPlan;
    }
}