using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class InscripcionLogic : BusinessLogic
    {
       
        private InscripcionCursoAdapter _InscripcionData;
        public InscripcionLogic()
        {
            InscripcionData = new InscripcionCursoAdapter();
        }

   
        public InscripcionCursoAdapter InscripcionData { get => _InscripcionData; set => _InscripcionData = value; }

        public AlumnoInscripcion GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return InscripcionData.GetAll();
        }

        public void Save(AlumnoInscripcion aluInscri)
        {
            InscripcionData.Save(aluInscri);
        }

        public void Delete(int id)
        {
            InscripcionData.Delete(id);
        }
    }
}
