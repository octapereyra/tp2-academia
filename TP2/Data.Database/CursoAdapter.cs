using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Data.Database
{
    public class CursoAdapter:Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cur = new Curso();
                    cur.ID= (int)drCursos["id_curso"];
                    cur.IDComision= (int)drCursos["id_comision"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.AnioCalendario= (int)drCursos["anio_calendario"];
                    cur.Cupo= (int)drCursos["cupo"];

                    cursos.Add(cur);
                }
                drCursos.Close();

            }
            catch (Exception  ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos", ex);
                throw ExcepcionManejada;
               
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos where id_curso=@id", SqlConn); //quien es cursos, cuando apenas creo el metodo
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                if (drCursos.Read()) //q hace??
                {
                    cur.ID = (int)drCursos["id_curso"];
                    //cur.Descripcion = (string)drCursos["desc_especialidad"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                }

                drCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso = @id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID; //q hace esta linea?

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "WHERE id_curso=@id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO cursos (id_materia,id_comision, anio_calendario,cupo)" +
                    "values(@id_materia,@id_comision,@anio_calendario,@cupo)" +
                    "select @@identity", SqlConn);

                //cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;

                curso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar()); // q diferencia hay con la primer linea
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void Save(Curso cur)
        {
            if (cur.State == BusinessEntity.States.New)
            {
                this.Insert(cur);
            }
            else if (cur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cur.ID);
            }
            else if (cur.State == BusinessEntity.States.Modified)
            {
                this.Update(cur);
            }
            cur.State = BusinessEntity.States.Unmodified;
        }




    }
}
