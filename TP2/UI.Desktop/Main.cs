using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void mnuPersonas_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmPersonas p = new frmPersonas();
            p.MdiParent = this;
            p.WindowState = FormWindowState.Maximized;
            p.Show();
        }

        private void mnuMaterias_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmMaterias m = new frmMaterias();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmUsuarios u = new frmUsuarios();
            u.MdiParent = this;
            u.WindowState = FormWindowState.Maximized;
            u.Show();
        }

        private void mnuEspecialidades_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmEspecialidades esp = new();
            esp.MdiParent = this;
            esp.WindowState = FormWindowState.Maximized;
            esp.Show();
        }

        private void CloseForms()
        {
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                forms[i].Dispose();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmLogin login = new();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
