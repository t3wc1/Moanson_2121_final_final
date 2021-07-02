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
    public partial class crear_cliente : Form
    {
        public crear_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = nombre_txt.Text;
            string apellido_materno = nombre_txt.Text;
            string apellido_paterno = apellido_paterno_txt.Text;
            string correo = correo_txt.Text;
            string direccion = direccion_txt.Text;
            string dni = dni_txt.Text;
            bool estado = estado_check.Checked;
            Console.WriteLine(estado);
            string telefono = telefono_txt.Text;
            DateTime cumpleaños = cumpleaños_date.Value;
            string ruc = ruc_txt.Text;
            if(correo !="" && direccion !="" && nombres !="" &&ruc !="")
            {
                string aux = "0";
                if (estado==true)
                {
                    aux = "1";
                }
                cliente_con_ruc cl = new cliente_con_ruc();
                cl.correo = correo;
                cl.dirreccion = direccion;
                cl.estado = aux;
                cl.id = clientelogica.Instancia.id_cliente();
                cl.nombre = nombres;
                cl.ruc = ruc;
                cl.telefono = telefono;
                Console.WriteLine(cl);
                clientelogica.Instancia.insertar_cliente_con_ruc(cl);
               
            }
        }

        private void crear_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
