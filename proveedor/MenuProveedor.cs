using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final.proveedor
{
    public partial class MenuProveedor : Form
    {
        public MenuProveedor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearProveedor frm = new CrearProveedor();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarProveedor frmr = new ModificarProveedor();
            frmr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InhabilitarProveedor frmw = new InhabilitarProveedor();
            frmw.Show();
        }
    }
}
