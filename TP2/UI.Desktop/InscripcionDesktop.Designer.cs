
namespace UI.Desktop
{
    partial class frmInscripcionDesktop
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.cboComisiones = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblIDInscripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(342, 198);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Inscribir";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(457, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comision";
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(212, 80);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(178, 23);
            this.cboMaterias.TabIndex = 12;
            this.cboMaterias.SelectedValueChanged += new System.EventHandler(this.cboMaterias_SelectedValueChanged);
            // 
            // cboComisiones
            // 
            this.cboComisiones.FormattingEnabled = true;
            this.cboComisiones.Location = new System.Drawing.Point(212, 131);
            this.cboComisiones.Name = "cboComisiones";
            this.cboComisiones.Size = new System.Drawing.Size(178, 23);
            this.cboComisiones.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(81, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(377, 30);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Completá el formulario para inscribirte a cursar la materia que desees. \r\nSi el c" +
    "urso que deseas no aparece es porque se quedó sin cupo";
            // 
            // lblIDInscripcion
            // 
            this.lblIDInscripcion.AutoSize = true;
            this.lblIDInscripcion.Location = new System.Drawing.Point(29, 66);
            this.lblIDInscripcion.Name = "lblIDInscripcion";
            this.lblIDInscripcion.Size = new System.Drawing.Size(0, 15);
            this.lblIDInscripcion.TabIndex = 15;
            this.lblIDInscripcion.Visible = false;
            // 
            // frmInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 240);
            this.Controls.Add(this.lblIDInscripcion);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cboComisiones);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmInscripcionDesktop";
            this.Text = "Inscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.ComboBox cboComisiones;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblIDInscripcion;
    }
}