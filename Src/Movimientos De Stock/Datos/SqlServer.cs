using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SqlServer
    {
        SqlConnection conn;
        SqlCommand sqlCommand;

        public SqlServer() { 
            conn = new SqlConnection();
            conn.ConnectionString = GenerarConnectionString();
        }

        public void Conectar()
        {
            conn.Open();
        }

        public void Desconectar()
        {
            sqlCommand.Dispose();
            conn.Close();
        }

        public string GenerarConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ninguno\\sql";
            builder.InitialCatalog = "Northwind";
            builder.UserID = "sa";
            builder.Password = "Axoft1988";

            return builder.ConnectionString;
        }

        public void CrearComando(string sql)
        {
            sqlCommand = conn.CreateCommand();
            sqlCommand.CommandText = sql;
        }

        public DbDataReader EjecutarConsulta()
        {
            return sqlCommand.ExecuteReader();
        }

    }
}
