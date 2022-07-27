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
    public partial class frmInscripcionDesktop : ApplicationForm
    {
        public frmInscripcionDesktop()
        {
            InitializeComponent();
        }

        private AlumnoInscripcion _InscripcionActual;
        public AlumnoInscripcion InscripcionActual { get => _InscripcionActual; set => _InscripcionActual = value; }
        public frmInscripcionDesktop(ModoForm modo) : this() //2
        {
            this.Modo = modo;
        }

        public frmInscripcionDesktop(int idInscripcion, ModoForm modo) : this() //3
        {
            this.Modo = modo;
            InscripcionLogic insLogic = new InscripcionLogic();
            InscripcionActual = insLogic.GetOne(idInscripcion);

            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtIDInscripcion.Text = this.InscripcionActual.ID.ToString();
            this.txtIdAlumno.Text = this.InscripcionActual.IDAlumno.ToString();
            this.txtIdCurso.Text = "1"; //
            this.txtCondicion.Text = this.InscripcionActual.Condicion;
            this.txtNota.Text = this.InscripcionActual.Nota.ToString();

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
            InscripcionLogic insLogic = new InscripcionLogic();
            AlumnoInscripcion nuevaIns = new AlumnoInscripcion();
            InscripcionActual = nuevaIns;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                nuevaIns.IDAlumno = this.InscripcionActual.IDAlumno;
                nuevaIns.IDCurso = 1; //
                nuevaIns.Condicion = this.InscripcionActual.Condicion;
                nuevaIns.Nota= this.InscripcionActual.Nota;
                if (Modo == ModoForm.Alta)
                {
                    nuevaIns.State = BusinessEntity.States.New;
                    insLogic.Save(nuevaIns);
                }
                if (Modo == ModoForm.Modificacion)
                {
                     
                    nuevaIns.ID = int.Parse(this.txtIDInscripcion.Text);
                    nuevaIns.State = BusinessEntity.States.Modified;
                    insLogic.Save(nuevaIns);
                }
            }
            if (Modo == ModoForm.Baja)
            {
                nuevaIns.ID = int.Parse(this.txtIDInscripcion.Text);
                nuevaIns.State = BusinessEntity.States.Deleted;
                insLogic.Save(nuevaIns);
            }

        }
        public override void GuardarCambios()
        {
            MapearADatos();
            InscripcionLogic insLogic = new InscripcionLogic();
            try
            {
                insLogic.Save(InscripcionActual);
            }
            catch (Exception exc)
            {
                DialogResult result = MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public override bool Validar()
        {
            if (txtIdCurso.Text.Trim().Length == 0 || txtIdAlumno.Text.Trim().Length == 0 ||
                txtCondicion.Text.Trim().Length == 0 || txtNota.Text.Trim().Length == 0 )
            {
                Notificar("Error", "No puede haber campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Modo.Equals(ModoForm.Baja))
            {
                if (Confirmar(this.btnAceptar.Text.ToLower(), "inscripcion").Equals(DialogResult.Yes))
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
