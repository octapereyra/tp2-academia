
namespace UI.Desktop
{
    partial class frmRegistroNotas
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.dgvAlumnosInscripcion = new System.Windows.Forms.DataGridView();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.btnCargaGrilla = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(76, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(68, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Elegir curso";
            // 
            // cboCursos
            // 
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(203, 10);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(235, 23);
            this.cboCursos.TabIndex = 1;
            // 
            // dgvAlumnosInscripcion
            // 
            this.dgvAlumnosInscripcion.AllowUserToAddRows = false;
            this.dgvAlumnosInscripcion.AllowUserToDeleteRows = false;
            this.dgvAlumnosInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idalumno,
            this.alumno,
            this.idcurso,
            this.nota,
            this.condicion});
            this.dgvAlumnosInscripcion.Location = new System.Drawing.Point(13, 51);
            this.dgvAlumnosInscripcion.Name = "dgvAlumnosInscripcion";
            this.dgvAlumnosInscripcion.ReadOnly = true;
            this.dgvAlumnosInscripcion.RowTemplate.Height = 25;
            this.dgvAlumnosInscripcion.Size = new System.Drawing.Size(775, 387);
            this.dgvAlumnosInscripcion.TabIndex = 2;
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Location = new System.Drawing.Point(661, 448);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(127, 23);
            this.btnModificarNota.TabIndex = 3;
            this.btnModificarNota.Text = "Modificar nota";
            this.btnModificarNota.UseVisualStyleBackColor = true;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnCargaGrilla
            // 
            this.btnCargaGrilla.Location = new System.Drawing.Point(498, 10);
            this.btnCargaGrilla.Name = "btnCargaGrilla";
            this.btnCargaGrilla.Size = new System.Drawing.Size(118, 23);
            this.btnCargaGrilla.TabIndex = 4;
            this.btnCargaGrilla.Text = "Cargar alumnos";
            this.btnCargaGrilla.UseVisualStyleBackColor = true;
            this.btnCargaGrilla.Click += new System.EventHandler(this.btnCargaGrilla_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idalumno
            // 
            this.idalumno.DataPropertyName = "idalumno";
            this.idalumno.HeaderText = "ID Alumno";
            this.idalumno.Name = "idalumno";
            this.idalumno.ReadOnly = true;
            this.idalumno.Visible = false;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "alumno";
            this.alumno.HeaderText = "Alumno (legajo)";
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            // 
            // idcurso
            // 
            this.idcurso.DataPropertyName = "idcurso";
            this.idcurso.HeaderText = "ID Curso";
            this.idcurso.Name = "idcurso";
            this.idcurso.ReadOnly = true;
            this.idcurso.Visible = false;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "condicion";
            this.condicion.HeaderText = "Condición";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // frmRegistroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.btnCargaGrilla);
            this.Controls.Add(this.btnModificarNota);
            this.Controls.Add(this.dgvAlumnosInscripcion);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistroNotas";
            this.Text = "RegistroNotas";
            this.Load += new System.EventHandler(this.frmRegistroNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosInscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.DataGridView dgvAlumnosInscripcion;
        private System.Windows.Forms.Button btnModificarNota;
        private System.Windows.Forms.Button btnCargaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
    }
}