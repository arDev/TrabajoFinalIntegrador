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
    public partial class FrmNuevo : Form
    {
        public string Param;
        string _parametro;
        public FrmNuevo(string parametro)
        {
            _parametro = parametro;
            InitializeComponent();
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_parametro);
            MessageBox.Show(Param);
        }
    }
}
