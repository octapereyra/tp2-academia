using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PersonaLogic
    {
        public PersonaLogic()
        {
            PersonaData = new PersonaAdapter();
        }
        PersonaAdapter _PersonaData;

        public PersonaAdapter PersonaData { get => _PersonaData; set => _PersonaData = value; }

        public DataTable GetAll()
        {
            return PersonaData.GetAll();
        }

        public Persona GetOne(int idPersona)
        {
            return PersonaData.GetOne(idPersona);
        }

        public void Save(Persona personaActual)
        {
            PersonaData.Save(personaActual);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }
    }
}
