﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        string _Descripcion;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
