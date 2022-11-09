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
            CargarCombo();
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
        private void CargarCombo()
        {
            cboComision.DataSource = new ComisionLogic().GetAll();
            cboMateria.DataSource = new MateriaLogic().GetAll();
            cboComision.ValueMember = "id";
            cboComision.DisplayMember = "descripcion";
            cboMateria.ValueMember = "id";
            cboMateria.DisplayMember = "descripcion";
        }

        private Curso _CursoActual;
        public Curso CursoActual { get => _CursoActual; set => _CursoActual = value; }

        public frmCursoDesktop(ModoForm modo) : this() 
        {
            this.Modo = modo;
        }
        public frmCursoDesktop(int ID, ModoForm modo) : this() 
        {
            Modo = modo;
            CursoLogic cur = new CursoLogic();
            CursoActual = cur.GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {

            txtID.Text = CursoActual.ID.ToString();
            txtAnio.Text = CursoActual.AnioCalendario.ToString();
            txtCupo.Text = CursoActual.Cupo.ToString();
            cboComision.SelectedValue = CursoActual.IDComision;
            cboMateria.SelectedValue = CursoActual.IDMateria;
            
        }
        public override void MapearADatos()
        {
            CursoLogic curLogic = new();
            Curso nuevoCur = new();
            CursoActual = nuevoCur;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                nuevoCur.AnioCalendario = int.Parse(txtAnio.Text);
                nuevoCur.Cupo = int.Parse(txtCupo.Text);
                nuevoCur.IDComision = (int)cboComision.SelectedValue;
                nuevoCur.IDMateria = (int)cboMateria.SelectedValue;
                if (Modo == ModoForm.Alta)
                {
                    nuevoCur.State = BusinessEntity.States.New;
                    curLogic.Save(nuevoCur);
                }
                if (Modo == ModoForm.Modificacion)
                {
                    nuevoCur.ID = int.Parse(txtID.Text);
                    nuevoCur.State = BusinessEntity.States.Modified;
                    curLogic.Save(nuevoCur);
                }
            }
            if (Modo == ModoForm.Baja)
            {
                nuevoCur.ID = int.Parse(this.txtID.Text);
                nuevoCur.State = BusinessEntity.States.Deleted;
                curLogic.Save(nuevoCur);
            }
        }
        public override bool Validar()
        {
            if (txtAnio.TextLength == 0 || txtCupo.TextLength == 0)
            {
                Notificar("Error", "No puede haber campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic curLogic = new();
            try
            {
                curLogic.Save(CursoActual);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
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
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
