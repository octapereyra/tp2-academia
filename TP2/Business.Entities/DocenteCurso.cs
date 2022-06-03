using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso : BusinessEntity
    {
        TiposCargos _Cargo;
        int _IDCurso;
        int _IDDocente;

        public int IDCurso { get => _IDCurso; set => _IDCurso = value; }
        public int IDDocente { get => _IDDocente; set => _IDDocente = value; }
        private TiposCargos Cargo { get => _Cargo; set => _Cargo = value; }

        private class TiposCargos
        {
        }
    }
}
