using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _idUsuario;
        private int _idModulo;
        private bool _permiteAlta;
        private bool _permiteBaja;
        private bool _permiteModificacion;
        private bool _permiteConsulta;

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int IdModulo { get => _idModulo; set => _idModulo = value; }
        public bool PermiteAlta { get => _permiteAlta; set => _permiteAlta = value; }
        public bool PermiteBaja { get => _permiteBaja; set => _permiteBaja = value; }
        public bool PermiteModificacion { get => _permiteModificacion; set => _permiteModificacion = value; }
        public bool PermiteConsulta { get => _permiteConsulta; set => _permiteConsulta = value; }
    }
}
