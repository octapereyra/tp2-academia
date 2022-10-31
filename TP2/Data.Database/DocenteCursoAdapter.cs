using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docentes = new List<DocenteCurso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdDocentes = new SqlCommand("select * from docentes_cursos", SqlConn);
                SqlDataReader drDocentes = cmdDocentes.ExecuteReader();

                while (drDocentes.Read())
                {
                    DocenteCurso docente = new DocenteCurso();
                    docente.ID = (int)drDocentes["id_dictado"];
                    docente.IDCurso = (int)drDocentes["id_curso"];
                    docente.IDDocente = (int)drDocentes["id_docente"];
                    docente.SetTipoCargoById((int)drDocentes["cargo"]);

                    docentes.Add(docente);
                }
                drDocentes.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de docentes", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentes;
        }

        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso docente = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocentes = new SqlCommand("select * from docentes_cursos where id_dictado = @id", SqlConn);
                cmdDocentes.Parameters.Add("@id", SqlDbType.Int).Value = ID; //?
                SqlDataReader drDocentes = cmdDocentes.ExecuteReader();

                if (drDocentes.Read())
                {
                    docente.ID = (int)drDocentes["id_dictado"];
                    docente.IDCurso = (int)drDocentes["id_curso"];
                    docente.IDDocente = (int)drDocentes["id_docente"];
                    docente.SetTipoCargoById((int)drDocentes["cargo"]);
                }
                drDocentes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de docentes", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return docente;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado = @id", SqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar registro en docentesCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(DocenteCurso doc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docentes_cursos SET " +
                    "id_curso = @id_curso, " +
                    "id_docente = @id_docente, " +
                    "cargo = @cargo, " +
                    "WHERE id_dictado = @id", SqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = doc.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = doc.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = doc.GetIDTipoCargo();

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar registro de docentesCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(DocenteCurso doc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO docentes_cursos (id_curso, id_docente, cargo)" +
                    "values(@id_curso, @id_docente, @cargo)" +
                    "select @@identity", SqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = doc.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = doc.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = doc.GetIDTipoCargo();

                doc.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar registro en docentesCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void Save(DocenteCurso doc)
        {
            if (doc.State == BusinessEntity.States.New)
            {
                this.Insert(doc);
            }
            else if (doc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(doc.ID);
            }
            else if (doc.State == BusinessEntity.States.Modified)
            {
                this.Update(doc);
            }
            doc.State = BusinessEntity.States.Unmodified;
        }
    }
}
