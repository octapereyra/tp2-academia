﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Plan : BusinessEntity
    {
        string _Descripcion;
        int _IDEspecialidad;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int IDEspecialidad { get => _IDEspecialidad; set => _IDEspecialidad = value; }
    }
}
