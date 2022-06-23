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
        }

        private void mnuPersonas_Click(object sender, EventArgs e)
        {
            frmPersonas p = new frmPersonas();
            p.ShowDialog();
        }

        private void mnuMaterias_Click(object sender, EventArgs e)
        {
            frmMaterias m = new frmMaterias();
            m.ShowDialog();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios u = new frmUsuarios();
            u.ShowDialog();
        }
    }
}
