using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
using EntidadLogica;
namespace Proyecto_final.cliente
{
    public partial class Anular : Form
    {
        public Anular()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void Anular_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_cliente_txt.Text);
            bool aux = clientelogica.Instancia.buscar_cliente(id);
            if(aux==true)
            {
                groupBox1.Enabled = true;
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
