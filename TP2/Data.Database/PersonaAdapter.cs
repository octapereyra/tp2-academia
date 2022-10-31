using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand("select * from personas", SqlConn);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Persona p = new()
                    {
                        ID = (int)dataReader["id_persona"],
                        Apellido = dataReader["apellido"].ToString(),
                        Direccion = dataReader["direccion"].ToString(),
                        Nombre = dataReader["nombre"].ToString(),
                        Email = dataReader["email"].ToString(),
                        FechaNacimiento = (DateTime)dataReader["fecha_nac"],
                        Telefono = dataReader["telefono"].ToString(),
                        Legajo = (int)dataReader["legajo"],
                        IDPLan = (int)dataReader["id_plan"],                       
                    };
                    p.SetTipoPersonaById((int)dataReader["tipo_persona"]);
                    personas.Add(p);                  
                }
                dataReader.Close();             
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar lista de personas", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }

            return personas;
        }

        public Persona GetOne(int id)
        {
            Persona persona = new();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand("select * from personas where id_persona = @id", SqlConn);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    persona = new()
                    {
                        ID = (int)dataReader["id_persona"],
                        Apellido = dataReader["apellido"].ToString(),
                        Direccion = dataReader["direccion"].ToString(),
                        Nombre = dataReader["nombre"].ToString(),
                        Email = dataReader["email"].ToString(),
                        FechaNacimiento = (DateTime)dataReader["fecha_nac"],
                        Telefono = dataReader["telefono"].ToString(),
                        Legajo = (int)dataReader["legajo"],
                        IDPLan = (int)dataReader["id_plan"],
                    };
                    persona.SetTipoPersonaById((int)dataReader["tipo_persona"]);
                }
                dataReader.Close();               
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar datos de persona", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
            return persona;
        }
        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al eliminar persona", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(Persona persona)
        {      
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update personas set nombre = @nombre, apellido = @apellido, direccion = @dir, email = @email, telefono = @tel, fecha_nac = @fn, legajo = @leg, " +
                                                    "tipo_persona = @tp, id_plan = @idplan " +
                                                    "where id_persona = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@dir", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@tel", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fn", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@leg", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tp", SqlDbType.Int).Value = persona.GetIDTipoPersona();
                cmdSave.Parameters.Add("@idplan", SqlDbType.Int).Value = persona.IDPLan;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al modificar datos de persona", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
           
        }

        protected void Insert(Persona persona)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new("insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) " +
                                            "values (@nombre, @apellido, @dir, @email, @tel, @fn, @leg, @tp, @idplan)", SqlConn);
                command.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                command.Parameters.Add("@dir", SqlDbType.VarChar, 50).Value = persona.Direccion;
                command.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                command.Parameters.Add("@tel", SqlDbType.VarChar, 50).Value = persona.Telefono;
                command.Parameters.Add("@fn", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                command.Parameters.Add("@leg", SqlDbType.Int).Value = persona.Legajo;
                command.Parameters.Add("@tp", SqlDbType.Int).Value = persona.GetIDTipoPersona();
                command.Parameters.Add("@idplan", SqlDbType.Int).Value = persona.IDPLan;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al crear persona", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

    }
}
