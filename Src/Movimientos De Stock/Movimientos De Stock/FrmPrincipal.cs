using Negocio;
using Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimientos_De_Stock
{
    public partial class FrmPrincipal : Form
    {
        List<Detalle> detalles
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movimiento movi = new Movimiento();
            movi.Nombre = textBox1.Text;
            movi.Nombre = textBox1.Text;
            movi.Nnumero = textBox1.Text;
            movi.detalles = detalles;
            Procesos p = new Procesos();
            p.GuardarMovimiento(movi);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Procesos p = new Procesos();
            List<string> nombre = p.TraerNombres();
        }
    }
}
