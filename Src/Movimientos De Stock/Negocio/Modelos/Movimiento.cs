using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelos
{
    public class Movimiento
    {
        public string Numero {  get; set; }

        public DateTime Fecha { get; set; }

        public string Nombre { get; set; }

        public string Tipo { get;set; }
    }
}
