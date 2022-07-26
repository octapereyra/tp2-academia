using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        public ComisionLogic()
        {
            ComisionData = new ComisionAdapter();
        }

        ComisionAdapter _ComisionData;

        public ComisionAdapter ComisionData { get => _ComisionData; set => _ComisionData = value; }

        public Comision GetOne(int ID)
        {
            return ComisionData.GetOne(ID);
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public void Save(Comision com)
        {
            ComisionData.Save(com);
        }

        public void Delete(int ID)
        {
            ComisionData.Delete(ID);
        }
    }
}
