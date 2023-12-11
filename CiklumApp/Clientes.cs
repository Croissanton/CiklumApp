using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Clientes : Form
    {
        int cliente_id = -1;
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

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            var consulta = new Consulta();
            var list = consulta.Select("SELECT DISTINCT C.ID_USUARIO, C.NOMBRE, C.APELLIDOS FROM CLIENTE C " +
                "JOIN CLIENTE_ENTRENADOR C_E ON C.ID_USUARIO = C_E.ID_CLIENTE " +
                "WHERE C_E.ID_ENTRENADOR = " + Login.ID + ";");
            //Create an array for storing numbers
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                this.dgvClientes.Rows.Add(Convert.ToInt32(item[0]), (string)item[1], (string)item[2]);
            }
            dgvClientes.ClearSelection();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            if(cliente_id == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            this.Hide();
            var perfil = new lCliente(cliente_id);
            perfil.Show();
        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {

                //Get cliente id
                cliente_id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
        }
    }
}
