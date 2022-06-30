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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select * from materias", SqlConn);
                SqlDataReader dataReader = cmdMaterias.ExecuteReader();

                while (dataReader.Read())
                {
                    Materia mat = new()
                    {
                        Descripcion = (string)dataReader["desc_materia"],
                        ID = (int)dataReader["id_materia"],
                        HSSemanales = (int)dataReader["hs_semanales"],
                        HSTotales = (int)dataReader["hs_totales"],
                        IDPlan = (int)dataReader["id_plan"],
                    };
                    materias.Add(mat);
               }
                          
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar lista de materias", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }

            return materias;
        }

        public Materia GetOne(int id)
        {
            Materia materia = new();
            try
            {
                OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select * from materias where id_materia = @id", SqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                if (drMaterias.Read())
                {
                    materia.ID = (int)drMaterias["id_materia"];
                    materia.Descripcion = (string)drMaterias["desc_materia"];
                    materia.HSSemanales = (int)drMaterias["hs_semanales"];
                    materia.HSTotales = (int)drMaterias["hs_totales"];
                    materia.IDPlan = (int)drMaterias["id_plan"];
                }
                drMaterias.Close();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al recuperar datos de materia", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
                        
            return materia;
        }

        public void Delete(int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al eliminar materia", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Materia materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("update materias set desc_materia = @desc_materia, hs_semanales = @hs_semanales, hs_totales = @hs_totales, id_plan = @id_plan " +
                                                    "where id_materia = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al modificar datos de materia", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Insert(Materia materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into materias(desc_materia,hs_semanales,hs_totales,id_plan) " +
                                                    "values (@desc_materia, @hs_semanales, @hs_totales, @id_plan) " +
                                                    "select @@identity", SqlConn);               
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                materia.ID = decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception handledException = new Exception("Error al crear materia", ex);
                throw handledException;
            }
            finally
            {
                CloseConnection();
            }
        }


        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.New)
            {
                Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
