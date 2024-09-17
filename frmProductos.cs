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
    public partial class frmProductos : Form
    {
        ManejadorProductos mp;
        public frmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            Mostrar();
        }
        string FiltroU;
        int fila, columns;
        public void Mostrar()
        {
            mp.MostrarUsuarios(dgvtProductos, FiltroU);
        }
        public static int idp;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columns = e.ColumnIndex;
            switch (columns)
            {

                case 6:
                    {
                        idp = int.Parse(dgvtProductos.Rows[fila].Cells[0].Value.ToString());
                        mp.Borrar(idp);
                        Mostrar();
                        txtProducto.Text = "";
                        txtProducto.Focus();

                    }
                    break;

                case 7:
                    {

                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltroU = txtProducto.Text;
        }

    }
}
