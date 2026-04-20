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
    public partial class frmResumen : Form
    {
        private string producto;
        private string tipo;
        private string adicional;

        public frmResumen(string productoRecibido, string tipoRecibido, string adicionalRecibido)
        {
            InitializeComponent();
            producto = productoRecibido;
            tipo = tipoRecibido;
            adicional = adicionalRecibido;
        }

        private void frmResumen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
