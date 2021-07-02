using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final.cliente
{
    public partial class Menu_cliente : Form
    {
        public Menu_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crear_cliente cv = new crear_cliente();
            cv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificar_cliente mc = new modificar_cliente();
            mc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anular a = new Anular();
            a.Show();
        }

        private void Menu_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
