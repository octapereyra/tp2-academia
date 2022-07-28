using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic: BusinessLogic
    {
        private CursoAdapter _CursoData;

        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }

      
        public CursoAdapter CursoData { get => _CursoData; set => _CursoData = value; }


        public Business.Entities.Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public void Save(Curso obj)
        {
            CursoData.Save(obj);
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
    }
}
