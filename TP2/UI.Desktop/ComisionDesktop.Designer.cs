namespace UI.Desktop
{
    partial class frmComisionDesktop
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
            this.txtDescComision = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            this.lblAnioEspecialidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.tlpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 4;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.53156F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.46844F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tlpUsuarios.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuarios.Controls.Add(this.txtDescComision, 1, 1);
            this.tlpUsuarios.Controls.Add(this.lbID, 0, 0);
            this.tlpUsuarios.Controls.Add(this.lblNombre, 0, 1);
            this.tlpUsuarios.Controls.Add(this.lblIDPlan, 2, 1);
            this.tlpUsuarios.Controls.Add(this.txtAnioEspecialidad, 3, 0);
            this.tlpUsuarios.Controls.Add(this.lblAnioEspecialidad, 2, 0);
            this.tlpUsuarios.Controls.Add(this.btnAceptar, 2, 2);
            this.tlpUsuarios.Controls.Add(this.btnCancelar, 3, 2);
            this.tlpUsuarios.Controls.Add(this.cboPlan, 3, 1);
            this.tlpUsuarios.Location = new System.Drawing.Point(0, 12);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 5;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tlpUsuarios.Size = new System.Drawing.Size(593, 302);
            this.tlpUsuarios.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 0;
            // 
            // txtDescComision
            // 
            this.txtDescComision.Location = new System.Drawing.Point(76, 47);
            this.txtDescComision.Name = "txtDescComision";
            this.txtDescComision.Size = new System.Drawing.Size(102, 23);
            this.txtDescComision.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbID.Enabled = false;
            this.lbID.Location = new System.Drawing.Point(3, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(67, 44);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(3, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 47);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Comision";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombre.UseMnemonic = false;
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIDPlan.Location = new System.Drawing.Point(272, 44);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(30, 47);
            this.lblIDPlan.TabIndex = 8;
            this.lblIDPlan.Text = "Plan";
            // 
            // txtAnioEspecialidad
            // 
            this.txtAnioEspecialidad.Location = new System.Drawing.Point(308, 3);
            this.txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            this.txtAnioEspecialidad.Size = new System.Drawing.Size(136, 23);
            this.txtAnioEspecialidad.TabIndex = 16;
            // 
            // lblAnioEspecialidad
            // 
            this.lblAnioEspecialidad.AutoSize = true;
            this.lblAnioEspecialidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAnioEspecialidad.Location = new System.Drawing.Point(205, 0);
            this.lblAnioEspecialidad.Name = "lblAnioEspecialidad";
            this.lblAnioEspecialidad.Size = new System.Drawing.Size(97, 44);
            this.lblAnioEspecialidad.TabIndex = 17;
            this.lblAnioEspecialidad.Text = "Año Especialidad";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(184, 94);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(308, 94);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(308, 47);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 23);
            this.cboPlan.TabIndex = 18;
            // 
            // frmComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 155);
            this.Controls.Add(this.tlpUsuarios);
            this.Name = "frmComisionDesktop";
            this.Text = "ComisionDesktop";
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescComision;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtAnioEspecialidad;
        private System.Windows.Forms.Label lblAnioEspecialidad;
        private System.Windows.Forms.ComboBox cboPlan;
    }
}