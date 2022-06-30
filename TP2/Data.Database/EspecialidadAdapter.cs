using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class EspecialidadAdapter:Adapter
    {
        public List<Especialidad> GetAll()
        {
            //instanciamos el objeto lista a retornar
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                //abrimos la conexion a la base de datos con el metodo que creamos antes
                this.OpenConnection();

                //creamos un obj sqlcommand que sera la sentencia SQL 
                // que vamos a ejecutar contra la base de datos 
                //los daos de la BD usuario,contraseña,servidor,etc.
                //estan en el connection string 
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", SqlConn);
                //instanciamos un objeto dataReader que sera
                // el q recuperara los datos de la BD
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                //read() lee una fila de las devueltas por el comando sql
                //carga los datos en drUsuarios para poder accederlos, 
                //devuelve verdadero mientras haya podido leer datos
                // y avanza a la fila siguiente para el proximo read
                while (drEspecialidades.Read())
                {
                    //creamos un objeto Usuario de la capa de entidades para copiar
                    //los datos de la fila del dataReader al objeto de entidades
                    Especialidad esp = new Especialidad();
                    //ahora copiamos los datos de la fila al objeto
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    

                    //agregamos el objeto con datos a la lista que devolveremos
                   especialidades.Add(esp);
                }

                //cerramos el datareader y la conexion a la BD
                drEspecialidades.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de especialidades", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }


            return especialidades;
        }

        public Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades where id_especialidad=@id", SqlConn);
                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                if (drEspecialidades.Read())
                {
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                }

                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }

        public void Delete(int ID)
        {
            
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar una especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO especialidades(desc_especialidad)" +
                    " VALUES (@desc_especialidad)" +
                    " SELECT @@identity", SqlConn);// esta línea es para recuperar el ID que asignó el sql automáticamente

                cmdInsert.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                // cmdInsert.Parameters.Add("@id", SqlDbType.Int).Value = Especialidad.ID;
                esp.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
                // así se obtiene el ID que asigno la BD automaticamente
                // cmdInsert.ExecuteNonQuery(); (tendriá q estar?)
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al insertar la especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET " +
                    "desc_especialidad=@desc_especialidad WHERE id_especialidad=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = esp.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad esp)
        {

            if (esp.State == BusinessEntity.States.Deleted)
            {
                this.Delete(esp.ID);
            }
            else if (esp.State == BusinessEntity.States.New)
            {
                this.Insert(esp);
            }
            else if (esp.State == BusinessEntity.States.Modified)
            {
                this.Update(esp);
            }
            esp.State = BusinessEntity.States.Unmodified;
        }
    }
}
