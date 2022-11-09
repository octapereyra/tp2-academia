
namespace UI.Desktop
{
    partial class frmMain
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInscripcionCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistroNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportePlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuDatos,
            this.mnuRegistros,
            this.mnuReportes});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1279, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogout});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(142, 22);
            this.mnuLogout.Text = "Cerrar sesión";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuDatos
            // 
            this.mnuDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuPersonas,
            this.mnuMaterias,
            this.mnuEspecialidades,
            this.mnuPlanes,
            this.mnuCursos,
            this.mnuComisiones,
            this.mnuDocentes});
            this.mnuDatos.Name = "mnuDatos";
            this.mnuDatos.Size = new System.Drawing.Size(49, 20);
            this.mnuDatos.Text = "Datos";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(150, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(150, 22);
            this.mnuPersonas.Text = "Personas";
            this.mnuPersonas.Click += new System.EventHandler(this.mnuPersonas_Click);
            // 
            // mnuMaterias
            // 
            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Size = new System.Drawing.Size(150, 22);
            this.mnuMaterias.Text = "Materias";
            this.mnuMaterias.Click += new System.EventHandler(this.mnuMaterias_Click);
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(150, 22);
            this.mnuEspecialidades.Text = "Especialidades";
            this.mnuEspecialidades.Click += new System.EventHandler(this.mnuEspecialidades_Click);
            // 
            // mnuPlanes
            // 
            this.mnuPlanes.Name = "mnuPlanes";
            this.mnuPlanes.Size = new System.Drawing.Size(150, 22);
            this.mnuPlanes.Text = "Planes";
            this.mnuPlanes.Click += new System.EventHandler(this.mnuPlanes_Click);
            // 
            // mnuCursos
            // 
            this.mnuCursos.Name = "mnuCursos";
            this.mnuCursos.Size = new System.Drawing.Size(150, 22);
            this.mnuCursos.Text = "Cursos";
            this.mnuCursos.Click += new System.EventHandler(this.mnuCursos_Click);
            // 
            // mnuComisiones
            // 
            this.mnuComisiones.Name = "mnuComisiones";
            this.mnuComisiones.Size = new System.Drawing.Size(150, 22);
            this.mnuComisiones.Text = "Comisiones";
            this.mnuComisiones.Click += new System.EventHandler(this.mnuComisiones_Click);
            // 
            // mnuDocentes
            // 
            this.mnuDocentes.Name = "mnuDocentes";
            this.mnuDocentes.Size = new System.Drawing.Size(150, 22);
            this.mnuDocentes.Text = "Docentes";
            this.mnuDocentes.Click += new System.EventHandler(this.mnuDocentes_Click);
            // 
            // mnuRegistros
            // 
            this.mnuRegistros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInscripcionCurso,
            this.mnuRegistroNotas});
            this.mnuRegistros.Name = "mnuRegistros";
            this.mnuRegistros.Size = new System.Drawing.Size(148, 20);
            this.mnuRegistros.Text = "Registros e inscripciones";
            // 
            // mnuInscripcionCurso
            // 
            this.mnuInscripcionCurso.Name = "mnuInscripcionCurso";
            this.mnuInscripcionCurso.Size = new System.Drawing.Size(173, 22);
            this.mnuInscripcionCurso.Text = "Inscripción a curso";
            // 
            // mnuRegistroNotas
            // 
            this.mnuRegistroNotas.Name = "mnuRegistroNotas";
            this.mnuRegistroNotas.Size = new System.Drawing.Size(173, 22);
            this.mnuRegistroNotas.Text = "Registro de notas";
            this.mnuRegistroNotas.Click += new System.EventHandler(this.mnuRegistroNotas_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReporteCursos,
            this.mnuReportePlanes});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // mnuReporteCursos
            // 
            this.mnuReporteCursos.Name = "mnuReporteCursos";
            this.mnuReporteCursos.Size = new System.Drawing.Size(110, 22);
            this.mnuReporteCursos.Text = "Cursos";
            this.mnuReporteCursos.Click += new System.EventHandler(this.mnuReporteCursos_Click);
            // 
            // mnuReportePlanes
            // 
            this.mnuReportePlanes.Name = "mnuReportePlanes";
            this.mnuReportePlanes.Size = new System.Drawing.Size(110, 22);
            this.mnuReportePlanes.Text = "Planes";
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::UI.Desktop.Properties.Resources.utn1;
            this.pbLogo.Location = new System.Drawing.Point(0, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1279, 130);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(435, 157);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(406, 36);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Bienvenido al sistema académico";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1279, 558);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Academia";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MnuMaterias_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuDatos;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanes;
        private System.Windows.Forms.ToolStripMenuItem mnuCursos;
        private System.Windows.Forms.ToolStripMenuItem mnuComisiones;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistros;
        private System.Windows.Forms.ToolStripMenuItem mnuInscripcionCurso;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistroNotas;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteCursos;
        private System.Windows.Forms.ToolStripMenuItem mnuReportePlanes;
        private System.Windows.Forms.ToolStripMenuItem mnuDocentes;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblBienvenido;
    }
}