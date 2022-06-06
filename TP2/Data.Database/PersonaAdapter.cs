using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class PersonaAdapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Persona> _Personas;

        private static List<Persona> Personas
        {
            get
            {
                if (_Personas == null)
                {
                    _Personas = new List<Persona>();
                    Business.Entities.Persona usr;
                    usr = new Business.Entities.Persona();

                    _Personas.Add(usr);

                    usr = new Business.Entities.Persona();

                    _Personas.Add(usr);

                    usr = new Business.Entities.Persona();

                    _Personas.Add(usr);

                }
                return _Personas;
            }
        }
        #endregion

        public List<Persona> GetAll()
        {
            return new List<Persona>(Personas);
        }

        public Business.Entities.Persona GetOne(int ID)
        {
            return Personas.Find(delegate (Persona u) { return u.ID == ID; });
        }

        public void Delete(int ID)
        {
            Personas.Remove(this.GetOne(ID));
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Persona usr in Personas)
                {
                    if (usr.ID > NextID)
                    {
                        NextID = usr.ID;
                    }
                }
                persona.ID = NextID + 1;
                Personas.Add(persona);
            }
            else if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Personas[Personas.FindIndex(delegate (Persona u) { return u.ID == persona.ID; })] = persona;
            }
            persona.State = BusinessEntity.States.Unmodified;
        }
    }
}
