﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Comision : BusinessEntity
    {
        int _AnioEspecialidad;
        string _Descripcion;
        int _IDPlan;

        public int AnioEspecialidad { get => _AnioEspecialidad; set => _AnioEspecialidad = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int IDPlan { get => _IDPlan; set => _IDPlan = value; }
    }
}
