
namespace UI.Desktop
{
    partial class frmCursoDesktop
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
            this.tlpCursoDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblComision = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.tlpCursoDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCursoDesktop
            // 
            this.tlpCursoDesktop.ColumnCount = 4;
            this.tlpCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.74368F));
            this.tlpCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.25632F));
            this.tlpCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpCursoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tlpCursoDesktop.Controls.Add(this.lblId, 0, 0);
            this.tlpCursoDesktop.Controls.Add(this.lblMateria, 0, 1);
            this.tlpCursoDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlpCursoDesktop.Controls.Add(this.txtCupo, 3, 1);
            this.tlpCursoDesktop.Controls.Add(this.txtAnio, 3, 2);
            this.tlpCursoDesktop.Controls.Add(this.lblCupo, 2, 1);
            this.tlpCursoDesktop.Controls.Add(this.lblAnio, 2, 2);
            this.tlpCursoDesktop.Controls.Add(this.btnAceptar, 2, 4);
            this.tlpCursoDesktop.Controls.Add(this.btnCancelar, 3, 4);
            this.tlpCursoDesktop.Controls.Add(this.lblComision, 0, 2);
            this.tlpCursoDesktop.Controls.Add(this.cboComision, 1, 2);
            this.tlpCursoDesktop.Controls.Add(this.cboMateria, 1, 1);
            this.tlpCursoDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCursoDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlpCursoDesktop.Name = "tlpCursoDesktop";
            this.tlpCursoDesktop.RowCount = 5;
            this.tlpCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.55556F));
            this.tlpCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpCursoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpCursoDesktop.Size = new System.Drawing.Size(863, 199);
            this.tlpCursoDesktop.TabIndex = 1;
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
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(3, 45);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(47, 15);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 4;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(558, 48);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(88, 23);
            this.txtCupo.TabIndex = 2;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(558, 88);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(88, 23);
            this.txtAnio.TabIndex = 4;
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(441, 45);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(36, 15);
            this.lblCupo.TabIndex = 12;
            this.lblCupo.Text = "Cupo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(441, 85);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 15);
            this.lblAnio.TabIndex = 13;
            this.lblAnio.Text = "Año";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(441, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(558, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 85);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(58, 15);
            this.lblComision.TabIndex = 14;
            this.lblComision.Text = "Comisión";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(102, 88);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(161, 23);
            this.cboComision.TabIndex = 15;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(102, 48);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(161, 23);
            this.cboMateria.TabIndex = 3;
            // 
            // frmCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 199);
            this.Controls.Add(this.tlpCursoDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCursoDesktop";
            this.Text = "Curso";
            this.tlpCursoDesktop.ResumeLayout(false);
            this.tlpCursoDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCursoDesktop;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cboComision;
    }
}