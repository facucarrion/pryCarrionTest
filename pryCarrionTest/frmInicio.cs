using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionTest
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmCargaProducto frmCargaProducto = new frmCargaProducto();
            this.Hide();
            frmCargaProducto.ShowDialog();
            this.Close();
        }
    }
}
