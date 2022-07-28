using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Data.Database
{
    public class InscripcionCursoAdapter:Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("select * from alumnos_inscripciones", SqlConn);
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();

                while (drInscripciones.Read())
                {
                    AlumnoInscripcion inscripcion = new AlumnoInscripcion();
                    inscripcion.ID = (int)drInscripciones["id_inscripcion"];
                    inscripcion.IDAlumno = (int)drInscripciones["id_alumno"];
                    inscripcion.IDCurso = (int)drInscripciones["id_curso"];
                    inscripcion.Condicion= (string)drInscripciones["condicion"];
                    inscripcion.Nota = (int)drInscripciones["nota"];

                    inscripciones.Add(inscripcion);
                }
                drInscripciones.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de alumnos inscripciones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return inscripciones;
        }

        public AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion inscripcion = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion = @id", SqlConn);
                cmdInscripciones.Parameters.Add("@id", SqlDbType.Int).Value = ID; //?
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();

                if (drInscripciones.Read())
                {
                    inscripcion.ID = (int)drInscripciones["id_inscripcion"]; //?
                    inscripcion.IDAlumno = (int)drInscripciones["id_alumno"];
                    inscripcion.IDCurso = (int)drInscripciones["id_curso"];
                    inscripcion.Condicion = (string)drInscripciones["condicion"];
                    inscripcion.Nota = (int)drInscripciones["nota"];
                }
                drInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de alumnos inscripciones", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return inscripcion;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion = @id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar registro en inscripcionesCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(AlumnoInscripcion insc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE alumnos_inscripciones SET " +
                    "id_alumno = @id_alumno, " +
                    "id_curso = @id_curso, " +
                    "condicion = @condicion, " +
                    "nota = @nota" +
                    "WHERE id_inscripcion = @id", SqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = insc.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = insc.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = insc.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar).Value = insc.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = insc.Nota;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar registro de inscripcionesCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(AlumnoInscripcion insc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO alumnos_inscripciones (id_alumno, id_curso, condicion, nota)" +
                    "values(@id_alumno, @id_curso, @condicion, @nota)" +
                    "select @@identity", SqlConn);

                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = insc.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = insc.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar).Value = insc.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = insc.Nota;

                insc.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar registro en inscripcionesCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void Save(AlumnoInscripcion insc)
        {
            if (insc.State == BusinessEntity.States.New)
            {
                this.Insert(insc);
            }
            else if (insc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(insc.ID);
            }
            else if (insc.State == BusinessEntity.States.Modified)
            {
                this.Update(insc);
            }
            insc.State = BusinessEntity.States.Unmodified;
        }
    }
}
