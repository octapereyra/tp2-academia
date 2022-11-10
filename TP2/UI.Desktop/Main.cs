using Business.Entities;
using Business.Logic;
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
        public Usuario UsuarioLogueado { get; set; }
        //permisos
        private void OcultarElementos(Persona personaActual)
        {
            switch (personaActual.TipoPersona)
            {
                case Persona.TiposPersonas.Estudiante:
                    mnuDatos.Visible = false;
                    mnuRegistroNotas.Visible = false;
                    mnuInscripcionCurso.Visible = true;
                    mnuReportes.Visible = false;
                    break;
                case Persona.TiposPersonas.Docente:
                    mnuDatos.Visible = false;
                    mnuInscripcionCurso.Visible = false;
                    mnuRegistroNotas.Visible = true;
                    break;
                case Persona.TiposPersonas.Administrativo:
                    mnuRegistros.Visible = false;
                    mnuReportes.Visible = false;
                    mnuDatos.Visible = true;
                    break;
                default:
                    break;
            }
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
        private void mnuPlanes_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmPlanes plan = new();
            plan.MdiParent = this;
            plan.WindowState = FormWindowState.Maximized;
            plan.Show();
        }
        private void mnuCursos_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmCursos cursos = new();
            cursos.MdiParent = this;
            cursos.WindowState = FormWindowState.Maximized;
            cursos.Show();
        }
        private void mnuComisiones_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmComisiones comisiones = new();
            comisiones.MdiParent = this;
            comisiones.WindowState = FormWindowState.Maximized;
            comisiones.Show();
        }
        private void mnuDocentes_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmDocentesCursos docentes = new();
            docentes.MdiParent = this;
            docentes.WindowState = FormWindowState.Maximized;
            docentes.Show();

        }
        private void CloseForms()
        {
            pbLogo.Visible = false;
            lblBienvenido.Visible = false;
            Form[] forms = this.MdiChildren;
            for (int i = 0; i < forms.Length; i++)
            {
                forms[i].Dispose();
            }
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            pbLogo.Visible = true;
            lblBienvenido.Visible = true;
            frmLogin login = new();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {
                PersonaLogic pl = new();              
                OcultarElementos(pl.GetOne(login.UsuarioActual.IdPersona));
                UsuarioLogueado = login.UsuarioActual;
            }
        }
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            UsuarioLogueado = null;
            CloseForms();
            frmMain_Shown(sender, e);
        }
        private void mnuRegistroNotas_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmRegistroNotas rn = new(UsuarioLogueado);
            rn.MdiParent = this;
            rn.WindowState = FormWindowState.Maximized;
            rn.Show();
        }
        private void mnuReporteCursos_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new();
            save.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss" + ".pdf");
            save.ShowDialog();
        }

        private void mnuInscripcionCurso_Click(object sender, EventArgs e)
        {
            CloseForms();
            frmInscripcionesCurso ic = new(UsuarioLogueado);
            ic.MdiParent = this;
            ic.WindowState = FormWindowState.Maximized;
            ic.Show();
        }
    }
}
