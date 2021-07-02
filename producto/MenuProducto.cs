using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final.producto
{
    public partial class MenuProducto : Form
    {
        public MenuProducto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InhabilitarProducto frm = new InhabilitarProducto();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearProducto frm = new CrearProducto();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarProducto frm = new ModificarProducto();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
