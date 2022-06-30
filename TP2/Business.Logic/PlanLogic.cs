using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic
    {
        public PlanLogic()
        {
            PlanData = new PlanAdapter();
        }

        PlanAdapter _PlanData;
        public PlanAdapter PlanData { get => _PlanData; set => _PlanData = value; }
        public List<Plan> GetAll()
        {         
            return PlanData.GetAll();
        }

        public Plan GetOne()
        {
            throw new NotImplementedException();
        }



    }
}
