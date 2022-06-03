using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Personas : BusinessEntity
    {
        string _Apellido;
        string _Direccion;
        string _Email;
        DateTime _FechaNacimiento;
        int _IDPLan;
        int _Legajo;
        string _Nombre;
        string _Telefono;
        TipoPersonas _TipoPersona;

        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public int IDPLan { get => _IDPLan; set => _IDPLan = value; }
        public int Legajo { get => _Legajo; set => _Legajo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        private TipoPersonas TipoPersona { get => _TipoPersona; set => _TipoPersona = value; }

        private class TipoPersonas
        {
        }
    }

}
