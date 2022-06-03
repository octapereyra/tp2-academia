using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        string _Descripcion;
        int _HSSemanales;
        int _HSTotales;
        int _IDPlan;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int HSSemanales { get => _HSSemanales; set => _HSSemanales = value; }
        public int HSTotales { get => _HSTotales; set => _HSTotales = value; }
        public int IDPlan { get => _IDPlan; set => _IDPlan = value; }
    }
}
