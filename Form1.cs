using Proyecto_final.cliente;
using Proyecto_final.producto;
using Proyecto_final.proveedor;
using Proyecto_final.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moanson_2121_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crear_cliente frm = new crear_cliente();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearProducto frmw = new CrearProducto();
            frmw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crear_venta frmwa = new crear_venta();
            frmwa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearProveedor frty = new CrearProveedor();
            frty.Show();
        }
    }
}
