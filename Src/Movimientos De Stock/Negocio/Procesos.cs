using Datos;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Procesos
    {
        public void Guardar(string nombre)
        {
            SqlServer sqlConex = new SqlServer();

            string sql = $"insert into Nombres (nombre) values ('{nombre}')";

            sqlConex.CrearComando(sql);
            sqlConex.Ejecutarcomando();
        }

        public void GuardarMovimiento(Movimiento movimiento)
        {
            SqlServer sqlConex = new SqlServer();

            string sql = $"insert into Movimientos (fecha,numero) values ('{movimiento.Fecha}','{movimiento.Numero}')";

            sqlConex.CrearComando(sql);
            sqlConex.Ejecutarcomando();

            foreach(Detalle d in movimiento.detalles)
            {
                string sql = $"insert into detalles (numero,CodigoArticulo,cantidad) " +
                    $"               values ('{d.numero}','{d.Codgio}','{d.Cantidad}')";

                sqlConex.CrearComando(sql);
                sqlConex.Ejecutarcomando();
            }
        }

        public List<string> TraerNombres()
        {
            List<string> nombres = new List<string>();

            SqlServer sqlConex = new SqlServer();

            string sql = $"select nombre from nombres";

            sqlConex.CrearComando(sql);
            DbDataReader reader = sqlConex.EjecutarConsulta();

            while(reader.Read())
            {
                nombres.Add(dr.GetString(0));
            }
            return nombres;
        }


    }
}
