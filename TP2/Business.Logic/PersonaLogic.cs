using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
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

        public List<Persona> GetAll()
        {
            throw new NotImplementedException();
        }

        public Persona GetOne(int idPersona)
        {
            throw new NotImplementedException();
        }

        public void Save(Persona personaActual)
        {
            throw new NotImplementedException();
        }
    }
}
