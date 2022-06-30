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
    }
}
