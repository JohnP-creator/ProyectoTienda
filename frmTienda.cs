using ManejadorT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónTienda
{
    public partial class frmTienda : Form
    {
        ManejadorRegistros mr;
        public frmTienda()
        {
            InitializeComponent();
            mr = new ManejadorRegistros();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mr.InsertarRegistros(txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text));
            MessageBox.Show("Producto GUARDADO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProductos u = new frmProductos();
            u.Show();
        }
    }
}
