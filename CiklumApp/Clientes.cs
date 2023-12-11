using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Clientes : Form
    {
        int cliente_id;
        public Clientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Hide();
            home.Show();
        }

        private void bEjercicios_Click(object sender, EventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Hide();
            ejercicios.Show();
        }

        private void bSesiones_Click(object sender, EventArgs e)
        {
            var sesiones = new Sesion();
            this.Hide();
            sesiones.Show();
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get cliente id
            cliente_id = Convert.ToInt32(lbClientes.SelectedValue);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.lbClientes.Items.Clear();
            var consulta = new Consulta();
            Console.WriteLine(Login.ID);
            var list = consulta.Select("SELECT DISTINCT C.ID, C.NOMBRE, C.APELLIDOS FROM CLIENTE C " +
                "JOIN CLIENTE_ENTRENADOR C_E ON C.ID_USUARIO = C_E.ID_CLIENTE " +
                "WHERE C_E.ID_ENTRENADOR = " + Login.ID + ";");
            foreach (var item in list)
            {
                this.lbClientes.Items.Add((string) item[1] + " " + (string)item[2]);
                this.lbClientes.ValueMember = item[0].ToString();
            }
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            var perfil = new lCliente(cliente_id);
            perfil.Show();
        }
    }
}
