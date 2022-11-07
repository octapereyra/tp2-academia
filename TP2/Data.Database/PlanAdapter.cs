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
    public class PlanAdapter : Adapter
    { 
        public List<Plan> GetAll()
        {
            List<Plan> planes = new();
            try
            {
                OpenConnection();
                SqlCommand command = new("select * from planes", SqlConn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Plan plan = new()
                    {
                        ID = (int)dataReader["id_plan"],
                        Descripcion = (string)dataReader["desc_plan"],
                        IDEspecialidad = (int)dataReader["id_especialidad"]
                    };
                    planes.Add(plan);
                }              
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar lista de planes", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }

            return planes;
        }

        public void Save(Plan planActual)
        {                   
            if (planActual.State == BusinessEntity.States.Deleted)
            {
                Delete(planActual.ID);
            }
            else if (planActual.State == BusinessEntity.States.New)
            {
                Insert(planActual);
            }
            else if (planActual.State == BusinessEntity.States.Modified)
            {
                Update(planActual);
            }
            planActual.State = BusinessEntity.States.Unmodified;
            
        }

        private void Update(Plan plan)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update planes set desc_plan = @desc, id_especialidad = @idEsp " +
                                                    "where id_plan = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@idEsp", SqlDbType.Int).Value = plan.IDEspecialidad;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al modificar datos de plan", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }

        private void Insert(Plan plan)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into planes(desc_plan, id_especialidad) values (@desc, @idEsp)", SqlConn);
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@idEsp", SqlDbType.Int).Value = plan.IDEspecialidad;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al insertar datos de plan", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("delete planes where id_plan = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al insertar datos de plan", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Plan GetOne(int idPlan)
        {
            Plan plan = null;
            try
            {
                OpenConnection();
                SqlCommand command = new("select * from planes where id_plan = @id", SqlConn);
                command.Parameters.Add("@id", SqlDbType.Int).Value = idPlan;
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    plan = new()
                    {
                        ID = (int)dataReader["id_plan"],
                        Descripcion = (string)dataReader["desc_plan"],
                        IDEspecialidad = (int)dataReader["id_especialidad"]
                    };

                }
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar lista de planes", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }

            return plan;
        }

        public List<Plan> GetPlanesByEspecialidad(int idEsp)
        {
            List<Plan> planes = new();
            try
            {
                OpenConnection();
                SqlCommand command = new("select * from planes where id_especialidad = @idEsp", SqlConn);
                command.Parameters.Add("@idEsp", SqlDbType.Int).Value = idEsp;
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Plan plan = new()
                    {
                        ID = (int)dataReader["id_plan"],
                        Descripcion = (string)dataReader["desc_plan"],
                    };
                    planes.Add(plan);
                }
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar lista de planes", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }

            return planes;
        }
    }
}
