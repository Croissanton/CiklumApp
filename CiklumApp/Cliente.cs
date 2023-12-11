using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class lCliente : Form
    {
        int cliente_id;
        public lCliente(int cliente_id)
        {
            this.cliente_id = cliente_id;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
        }

        private void lCliente_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT NOMBRE, APELLIDOS FROM CLIENTE WHERE ID_USUARIO = " + cliente_id + ";");
            this.label2.Text = (string)list[0][0] + " " + (string)list[0][1];
            
        }

        private void bSesion_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion();
            this.Close();
            sesion.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            this.Close();
            clientes.Show();
        }

        private void bEjercicios_Click(object sender, EventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Close();
            ejercicios.Show();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Close();
            home.Show();
        }

        private void bSesiones_Click(object sender, EventArgs e)
        {
            var sesiones = new Sesion();
            this.Close();
            sesiones.Show();
        }
        private void bRutina_Click(object sender, EventArgs e)
        {

        }
    }
}
