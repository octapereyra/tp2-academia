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

        public void Save(Plan planActual)
        {
            PlanData.Save(planActual);
        }

        public Plan GetOne(int idPlan)
        {
            return PlanData.GetOne(idPlan);
        }

        public List<Plan> GetPlanesByEspecialidad(int idEspecialidad)
        {
            return PlanData.GetPlanesByEspecialidad(idEspecialidad);
        }
    }
}
