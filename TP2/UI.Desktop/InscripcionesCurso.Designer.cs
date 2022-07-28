
namespace UI.Desktop
{
    partial class frmInscripcionesCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcionesCurso));
            this.tcInsripciones = new System.Windows.Forms.ToolStripContainer();
            this.tLInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsInscripciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcInsripciones.ContentPanel.SuspendLayout();
            this.tcInsripciones.TopToolStripPanel.SuspendLayout();
            this.tcInsripciones.SuspendLayout();
            this.tLInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.tsInscripciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcInsripciones
            // 
            // 
            // tcInsripciones.ContentPanel
            // 
            this.tcInsripciones.ContentPanel.Controls.Add(this.tLInscripciones);
            this.tcInsripciones.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tcInsripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInsripciones.Location = new System.Drawing.Point(0, 0);
            this.tcInsripciones.Name = "tcInsripciones";
            this.tcInsripciones.Size = new System.Drawing.Size(800, 450);
            this.tcInsripciones.TabIndex = 0;
            this.tcInsripciones.Text = "toolStripContainer1";
            // 
            // tcInsripciones.TopToolStripPanel
            // 
            this.tcInsripciones.TopToolStripPanel.Controls.Add(this.tsInscripciones);
            // 
            // tLInscripciones
            // 
            this.tLInscripciones.ColumnCount = 2;
            this.tLInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLInscripciones.Controls.Add(this.dgvInscripciones, 0, 0);
            this.tLInscripciones.Controls.Add(this.btnActualizar, 0, 1);
            this.tLInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tLInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tLInscripciones.Name = "tLInscripciones";
            this.tLInscripciones.RowCount = 2;
            this.tLInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLInscripciones.Size = new System.Drawing.Size(800, 425);
            this.tLInscripciones.TabIndex = 0;
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tLInscripciones.SetColumnSpan(this.dgvInscripciones, 2);
            this.dgvInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripciones.Location = new System.Drawing.Point(3, 3);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.RowTemplate.Height = 25;
            this.dgvInscripciones.Size = new System.Drawing.Size(794, 390);
            this.dgvInscripciones.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsInscripciones
            // 
            this.tsInscripciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsInscripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsInscripciones.Location = new System.Drawing.Point(3, 0);
            this.tsInscripciones.Name = "tsInscripciones";
            this.tsInscripciones.Size = new System.Drawing.Size(112, 25);
            this.tsInscripciones.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // frmInscripcionesCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcInsripciones);
            this.Name = "frmInscripcionesCurso";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.frmInscripcionesCurso_Load);
            this.tcInsripciones.ContentPanel.ResumeLayout(false);
            this.tcInsripciones.TopToolStripPanel.ResumeLayout(false);
            this.tcInsripciones.TopToolStripPanel.PerformLayout();
            this.tcInsripciones.ResumeLayout(false);
            this.tcInsripciones.PerformLayout();
            this.tLInscripciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.tsInscripciones.ResumeLayout(false);
            this.tsInscripciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcInsripciones;
        private System.Windows.Forms.TableLayoutPanel tLInscripciones;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsInscripciones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}