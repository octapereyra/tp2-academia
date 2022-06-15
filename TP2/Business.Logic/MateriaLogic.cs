using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        private MateriaAdapter _MateriaData;
        public MateriaAdapter MateriaData { get => _MateriaData; set => _MateriaData = value; }
        public MateriaLogic()
        {
            MateriaData = new MateriaAdapter();
        }  
        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public DataTable GetAll()
        {
            return MateriaData.GetAll();
        }

        public void Save(Materia materia)
        {
            MateriaData.Save(materia);
        }

        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }
    }
}
