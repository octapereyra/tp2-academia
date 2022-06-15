using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        private SqlConnection _sqlConn;
        private SqlDataAdapter _dataAdapter;

        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringExpress";
      
        public SqlDataAdapter DataAdapter { get => _dataAdapter; set => _dataAdapter = value; }
        public SqlConnection SqlConn { get => _sqlConn; set => _sqlConn = value; }

        protected void OpenConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            SqlConn = new SqlConnection(conn);
            SqlConn.Open();
        }

        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }

        /*
        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
        */
    }
}
