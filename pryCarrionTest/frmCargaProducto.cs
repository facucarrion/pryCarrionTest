using System;
using System.Collections;
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
    public partial class frmCargaProducto : Form
    {
        ArrayList arrProductos = new ArrayList();

        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void lblListaProductos_Click(object sender, EventArgs e)
        {

        }

        private void txtCargaProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtCargaProducto.Text.Length > 0)
            {
                btnCargaProducto.Enabled = true;
            } else
            {
                btnCargaProducto.Enabled = false;
            }
        }

        private void btnCargaProducto_Click(object sender, EventArgs e)
        {
            arrProductos.Add(txtCargaProducto.Text);
            lstProductos.Items.Add(txtCargaProducto.Text);
            txtCargaProducto.Clear();
            btnCargaProducto.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panAdicional.Visible = true;
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                btnProductos.Enabled = true;
            } else
            {
                btnProductos.Enabled = false;
            }
        }
    }
}
