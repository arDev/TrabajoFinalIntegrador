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
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            Procesos procesos = new Procesos();
            if(procesos.ProbarConexion())
            {
                MessageBox.Show("Conexion exitosa!");
            }
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            Procesos procesos = new Procesos();
            List<Cliente> clientes = procesos.TraerClientes();
            dgvClientes.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procesos procesos = new Procesos();
            DataTable clientes = procesos.TraerClientesDataTable();
            dgvClientes.DataSource = clientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNuevo fNuevo = new FrmNuevo("Nuevo parametro");
            fNuevo.Param = "algo";
            fNuevo.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saludos desde el menu de ayuda");
        }
    }
}
