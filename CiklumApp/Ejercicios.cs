using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Ejercicios : Form
    {
        public Ejercicios()
        {
            InitializeComponent();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Hide();
            home.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void bSesiones_Click(object sender, EventArgs e)
        {
            var sesiones = new Sesion();
            this.Hide();
            sesiones.Show();
        }

        private void Ejercicios_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM EJERCICIO");

            foreach (var item in list)
            {
                string nombre = (string)item[1];
                string tipo = (string)item[2];
                int duracion = (int)item[3];
                string descripcion = (string)item[4];
                string video = (string)item[5];
                string privacidad = (string)item[6];

                dgvEjercicios.Rows.Add(nombre, tipo, duracion, descripcion, video, privacidad);
            }
        }
    }
}
