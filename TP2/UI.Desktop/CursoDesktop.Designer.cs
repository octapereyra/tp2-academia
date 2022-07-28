
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.lbCupo = new System.Windows.Forms.Label();
            this.lbMateria = new System.Windows.Forms.Label();
            this.lbComision = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.txtIDComision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.19463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(424, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(134, 364);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(488, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(48, 66);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 15);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(41, 109);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(87, 15);
            this.lbAnio.TabIndex = 4;
            this.lbAnio.Text = "Año calendario";
            // 
            // lbCupo
            // 
            this.lbCupo.AutoSize = true;
            this.lbCupo.Location = new System.Drawing.Point(41, 149);
            this.lbCupo.Name = "lbCupo";
            this.lbCupo.Size = new System.Drawing.Size(36, 15);
            this.lbCupo.TabIndex = 5;
            this.lbCupo.Text = "Cupo";
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(41, 190);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(61, 15);
            this.lbMateria.TabIndex = 6;
            this.lbMateria.Text = "ID Materia";
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(41, 234);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(72, 15);
            this.lbComision.TabIndex = 7;
            this.lbComision.Text = "ID Comision";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Location = new System.Drawing.Point(134, 63);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.ReadOnly = true;
            this.txtIDCurso.Size = new System.Drawing.Size(100, 23);
            this.txtIDCurso.TabIndex = 8;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(134, 106);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 23);
            this.txtAnio.TabIndex = 9;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(134, 146);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(100, 23);
            this.txtCupo.TabIndex = 10;
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(134, 190);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.Size = new System.Drawing.Size(100, 23);
            this.txtIDMateria.TabIndex = 11;
            // 
            // txtIDComision
            // 
            this.txtIDComision.Location = new System.Drawing.Point(134, 226);
            this.txtIDComision.Name = "txtIDComision";
            this.txtIDComision.Size = new System.Drawing.Size(100, 23);
            this.txtIDComision.TabIndex = 12;
            // 
            // frmCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDComision);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.txtCupo);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtIDCurso);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.lbCupo);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCursoDesktop";
            this.Text = "Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.Label lbCupo;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.TextBox txtIDComision;
    }
}