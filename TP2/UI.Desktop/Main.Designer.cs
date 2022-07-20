
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
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.datosToolStripMenuItem});
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
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuPersonas,
            this.mnuMaterias,
            this.mnuEspecialidades,
            this.mnuPlanes});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(180, 22);
            this.mnuPersonas.Text = "Personas";
            this.mnuPersonas.Click += new System.EventHandler(this.mnuPersonas_Click);
            // 
            // mnuMaterias
            // 
            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Size = new System.Drawing.Size(180, 22);
            this.mnuMaterias.Text = "Materias";
            this.mnuMaterias.Click += new System.EventHandler(this.mnuMaterias_Click);
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(180, 22);
            this.mnuEspecialidades.Text = "Especialidades";
            this.mnuEspecialidades.Click += new System.EventHandler(this.mnuEspecialidades_Click);
            // 
            // mnuPlanes
            // 
            this.mnuPlanes.Name = "mnuPlanes";
            this.mnuPlanes.Size = new System.Drawing.Size(180, 22);
            this.mnuPlanes.Text = "Planes";
            this.mnuPlanes.Click += new System.EventHandler(this.mnuPlanes_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1279, 558);
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
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanes;
    }
}