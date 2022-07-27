using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class frmCursoDesktop : ApplicationForm
    {
        public frmCursoDesktop()
        {
            InitializeComponent();
        }

        private Curso _CursoActual;
        public Curso CursoActual { get => _CursoActual; set => _CursoActual = value; }

        public frmCursoDesktop(ModoForm modo) : this() //2
        {
            this.Modo = modo;
        }

        public frmCursoDesktop(int ID, ModoForm modo) : this() //3
        {
            Modo = modo;
            CursoLogic cur = new CursoLogic();
            CursoActual = cur.GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {

            this.txtIDCurso.Text = this.CursoActual.ID.ToString();
            this.txtAnio.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.txtIDComision.Text = this.CursoActual.IDComision.ToString();
            this.txtIDMateria.Text = this.CursoActual.IDMateria.ToString();

            //q hace esta parte?
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
            }
        }
        public override void MapearADatos()
        {
            CursoLogic curLogic = new CursoLogic();
            Curso nuevoCur = new Curso();
            CursoActual = nuevoCur;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                //nuevoCur.Descripcion = this.txtDescripcion.Text;
                nuevoCur.AnioCalendario = int.Parse( this.txtAnio.Text);
                nuevoCur.Cupo = int.Parse(this.txtCupo.Text);
                nuevoCur.IDComision = int.Parse(this.txtIDComision.Text);
                nuevoCur.IDMateria = int.Parse(this.txtIDMateria.Text);
                if (Modo == ModoForm.Alta)
                {
                    nuevoCur.State = BusinessEntity.States.New;
                    curLogic.Save(nuevoCur);
                }
                if (Modo == ModoForm.Modificacion)
                {
                    nuevoCur.ID = int.Parse(this.txtIDCurso.Text);
                    nuevoCur.State = BusinessEntity.States.Modified;
                    curLogic.Save(nuevoCur);
                }
            }
            if (Modo == ModoForm.Baja)
            {
                nuevoCur.ID = int.Parse(this.txtIDCurso.Text);
                nuevoCur.State = BusinessEntity.States.Deleted;
                curLogic.Save(nuevoCur);
            }
        }
        public override bool Validar()
        {
            if (txtAnio.TextLength == 0 && txtCupo.TextLength == 0 && txtIDComision.TextLength == 0 && txtIDCurso.TextLength == 0 && txtIDMateria.TextLength == 0)
            {
                Notificar("Error", "No puede haber campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic curLogic = new CursoLogic();
            try
            {
                curLogic.Save(CursoActual);
            }
            catch (Exception exc)
            {
                DialogResult result = MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "Curso").Equals(DialogResult.Yes))
                {
                    GuardarCambios();
                    this.Close();
                }
            }
            else if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
