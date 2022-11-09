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
    public partial class frmDocenteCursoDesktop : ApplicationForm
    {
        public frmDocenteCursoDesktop() 
        {
            InitializeComponent();
        }
        private DocenteCurso _DocenteEnCursoActual;
        public DocenteCurso DocenteCursoActual { get => _DocenteEnCursoActual; set => _DocenteEnCursoActual = value; }

        public frmDocenteCursoDesktop(ModoForm modo) : this() 
        {
            this.Modo = modo;
        }

        public frmDocenteCursoDesktop(int ID, ModoForm modo) : this() 
        {
            Modo = modo;
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            DocenteCursoActual = dcl.GetOne(ID);
            MapearDeDatos();
        }

        private void frmDocenteCursoDesktop_Load(object sender, EventArgs e)
        {
            CargaComboBoxDocentes();
            CargaComboBoxCargos();
            CargaComboBoxCursos();
        }
        private void CargaComboBoxDocentes()
        {
            try
            {
                cbDocentes.Enabled = true;
                PersonaLogic pl = new();
                List<Persona> listaPersonas = pl.GetAll();
                Dictionary<int, int> comboSourceDocente = new Dictionary<int, int>();

                foreach (Persona doc in listaPersonas)
                {
                    if (((int)doc.TipoPersona) == 1)
                    {
                        comboSourceDocente.Add(doc.ID, doc.Legajo);
                    }
                }

                cbDocentes.DataSource = new BindingSource(comboSourceDocente, null);
                cbDocentes.DisplayMember = "Value";
                cbDocentes.ValueMember = "Key";
                cbDocentes.Text = "...";
            }
            catch (Exception)
            {

                MessageBox.Show("Deben existir Docentes");
            }

        }
        private void CargaComboBoxCargos()
        {
            Dictionary<int, string> comboSourceCargo = new Dictionary<int, string>();

            comboSourceCargo.Add(0, "Ayudante");  
            comboSourceCargo.Add(1, "JTP");
            comboSourceCargo.Add(2, "Profesor_Adjunto");
            comboSourceCargo.Add(3, "Profesor_Titular"); 

            cbCargos.DataSource = new BindingSource(comboSourceCargo, null);
            
            cbCargos.DisplayMember = "Value";
            cbCargos.ValueMember = "Key";
            cbCargos.Text = "...";
        }

        private void CargaComboBoxCursos()
        {
            try
            {
                CursoLogic cl = new CursoLogic();
                List<Curso> listaCursos = cl.GetAll();
                Dictionary<int, int> comboSourceCurso = new Dictionary<int, int>();

                foreach (Curso c in listaCursos)
                {
                    comboSourceCurso.Add(c.ID, c.ID);
                }
                cbCursos.DataSource = new BindingSource(comboSourceCurso, null);
                cbCursos.DisplayMember = "Value";
                cbCursos.ValueMember = "Key";
                cbCursos.Text = "...";
            }
            catch (Exception)
            {
                MessageBox.Show("Deben existir Cursos");
            }

        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = DocenteCursoActual.ID.ToString();
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
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            DocenteCurso nuevoDocCur = new DocenteCurso();
            DocenteCursoActual = nuevoDocCur;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                DocenteCursoActual.IDCurso = ((KeyValuePair<int, int>)cbCursos.SelectedItem).Key;
                DocenteCursoActual.IDDocente = ((KeyValuePair<int, int>)cbDocentes.SelectedItem).Key;
                DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)((KeyValuePair<int, string>)cbCargos.SelectedItem).Key;

                if (Modo == ModoForm.Alta)
                {
                    nuevoDocCur.State = BusinessEntity.States.New;
                    dcl.Save(nuevoDocCur);
                }
                if (Modo == ModoForm.Modificacion)
                {
                    DocenteCursoActual.ID = int.Parse(this.txtID.Text);
                    DocenteCursoActual.State = BusinessEntity.States.Modified;
                    dcl.Save(nuevoDocCur);
                }
            }
            if (Modo == ModoForm.Baja)
            {
                DocenteCursoActual.ID = int.Parse(this.txtID.Text);
                nuevoDocCur.State = BusinessEntity.States.Deleted;
                dcl.Save(nuevoDocCur);
            }
        }

        public override bool Validar()
        {
            bool result = true;
            string errorString = string.Empty;

            if (!result || cbDocentes.SelectedIndex == -1 )
            {
                errorString = "Debe seleccionar todos los campos\n";
                result = false;
            }

            if (errorString != String.Empty)
            {
                Notificar("Error", errorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            try
            {
                dcl.Save(DocenteCursoActual);
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
                if (Confirmar(this.btnAceptar.Text.ToLower(), "DocenteCurso").Equals(DialogResult.Yes))
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
