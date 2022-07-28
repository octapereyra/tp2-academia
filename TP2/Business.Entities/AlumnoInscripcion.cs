﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        string _Condicion;
        int _IDAlumno;
        int _IDCurso;
        int _Nota;

        public string Condicion { get => _Condicion; set => _Condicion = value; }
        public int IDAlumno { get => _IDAlumno; set => _IDAlumno = value; }
        public int IDCurso { get => _IDCurso; set => _IDCurso = value; }
        public int Nota { get => _Nota; set => _Nota = value; }
    }
}
