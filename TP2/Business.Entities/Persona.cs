using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private string _Apellido;
        private string _Direccion;
        private string _Email;
        private DateTime _FechaNacimiento;
        private int _IDPLan;
        private int _Legajo;
        private string _Nombre;
        private string _Telefono;
        private TiposPersonas _TipoPersona;

        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public int IDPLan { get => _IDPLan; set => _IDPLan = value; }
        public int Legajo { get => _Legajo; set => _Legajo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public TiposPersonas TipoPersona { get => _TipoPersona; set => _TipoPersona = value; }

        public enum TiposPersonas { Estudiante, Docente, Administrativo }

        public void SetTipoPersonaById(int id)
        {
            switch (id)
            {
                case (int)TiposPersonas.Estudiante:
                    this.TipoPersona = TiposPersonas.Estudiante;
                    break;
                case (int)TiposPersonas.Docente:
                    this.TipoPersona = TiposPersonas.Docente;
                    break;
                case (int)TiposPersonas.Administrativo:
                    this.TipoPersona = TiposPersonas.Administrativo;
                    break;
                default:
                    throw new Exception("No existe el tipo persona especificado: " + id.ToString());
            }
        }

        public int GetIDTipoPersona()
        {
            switch (this.TipoPersona)
            {
                case TiposPersonas.Estudiante:
                    return 0;
                case TiposPersonas.Docente:
                    return 1;
                case TiposPersonas.Administrativo:
                    return 2;
                default:
                    throw new Exception("No existe el tipo persona especificado: " + this.TipoPersona.ToString());
            }
        }
    }

}
