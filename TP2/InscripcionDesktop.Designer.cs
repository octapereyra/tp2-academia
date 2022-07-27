
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
            this.lbIDInscripcion = new System.Windows.Forms.Label();
            this.txtIDInscripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAlumno = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIDInscripcion
            // 
            this.lbIDInscripcion.AutoSize = true;
            this.lbIDInscripcion.Location = new System.Drawing.Point(109, 68);
            this.lbIDInscripcion.Name = "lbIDInscripcion";
            this.lbIDInscripcion.Size = new System.Drawing.Size(18, 15);
            this.lbIDInscripcion.TabIndex = 0;
            this.lbIDInscripcion.Text = "ID";
            // 
            // txtIDInscripcion
            // 
            this.txtIDInscripcion.Location = new System.Drawing.Point(260, 60);
            this.txtIDInscripcion.Name = "txtIDInscripcion";
            this.txtIDInscripcion.ReadOnly = true;
            this.txtIDInscripcion.Size = new System.Drawing.Size(100, 23);
            this.txtIDInscripcion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(83, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 387);
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
            this.label1.Location = new System.Drawing.Point(109, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "IDAlumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "IDCurso";
            // 
            // txtIdAlumno
            // 
            this.txtIdAlumno.Location = new System.Drawing.Point(260, 130);
            this.txtIdAlumno.Name = "txtIdAlumno";
            this.txtIdAlumno.Size = new System.Drawing.Size(100, 23);
            this.txtIdAlumno.TabIndex = 6;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(260, 203);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(100, 23);
            this.txtIdCurso.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Condicion";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(260, 266);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 23);
            this.txtCondicion.TabIndex = 9;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(260, 325);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 23);
            this.txtNota.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nota";
            // 
            // frmInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.txtIdAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIDInscripcion);
            this.Controls.Add(this.lbIDInscripcion);
            this.Name = "frmInscripcionDesktop";
            this.Text = "Inscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDInscripcion;
        private System.Windows.Forms.TextBox txtIDInscripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAlumno;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label4;
    }
}