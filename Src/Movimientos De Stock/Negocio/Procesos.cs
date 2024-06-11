using Datos;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Procesos
    {
        public bool ProbarConexion()
        {
            SqlServer sqlServer = new SqlServer();

            sqlServer.Conectar();

            return true;
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlServer sqlConex = new SqlServer();

            sqlConex.Conectar();

            string sql = @"SELECT    [CustomerID]
                                    ,[CompanyName]
                                    ,[ContactName]
                                    ,[ContactTitle]
                                    ,[Phone]
                                    FROM [Northwind].[dbo].[Customers]";


            sqlConex.CrearComando(sql);
            DbDataReader reader = sqlConex.EjecutarConsulta();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.CustomerID = reader.GetString(0);
                cliente.CompanyName = reader.GetString(1);
                cliente.ContactName = reader.GetString(2);
                cliente.ContactTitle = reader.GetString(3);
                cliente.Phone = reader.GetString(4);
                clientes.Add(cliente);
            }

            sqlConex.Desconectar();

            return clientes;
        }

        public DataTable TraerClientesDataTable()
        {
            SqlServer sqlConex = new SqlServer();

            sqlConex.Conectar();

            string sql = @"SELECT    [CustomerID]
                                    ,[CompanyName]
                                    ,[ContactName]
                                    ,[ContactTitle]
                                    ,[Phone]
                                    FROM [Northwind].[dbo].[Customers]";


            sqlConex.CrearComando(sql);
            DbDataReader reader = sqlConex.EjecutarConsulta();

            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt;
        }
    }
}
