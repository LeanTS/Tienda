using FrontCliente;
using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End
{
    public partial class Inicio : Form
    {
        BackEnd.Inicio inicio = new BackEnd.Inicio();
        public Inicio()
        {
            InitializeComponent();
        }

        new int Enter;
        private void button1_Click(object sender, EventArgs e)
        {
            string Empleado;
            string Password;
            string Cliente;
            Cliente = "Cliente";
            Empleado = "EmpleadoADM";
            Password = "jonnybravo";

            if (txtbx_user.Text == Empleado && txtbx_pass.Text == Password)
            {
                Enter = (int)inicio.Ingreso(true,
                                       true);
            }
            else if (txtbx_user.Text == Cliente)
            {
                Enter = (int)inicio.Ingreso(true,
                                       false);
            }
            else if (txtbx_user.Text != Empleado && txtbx_user.Text != Cliente)
            {
                Enter = (int)inicio.Ingreso(false,
                                       false);
            }
            if (Enter == 0)
            {
                MessageBox.Show("Datos Incorrectos");
            }
            else if (Enter == 1)
            {
                MessageBox.Show("Datos como Clientes correctos");
                this.Hide();
                Tienda tienda = new Tienda();
                tienda.Show();
            }
            else if (Enter == 2)
            {
                MessageBox.Show("Datos como Empleado correctos");
            }
        }
    }
}
