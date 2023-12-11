using System;
using System.Numerics;
using System.Windows.Forms;



namespace CiklumApp
{
    public partial class Home : Form
    {
        private void loadCitas()
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM CITA WHERE id_entrenador = '" + Login.ID + "';");

            foreach (var item in list)
            {
                DateTime fecha = (DateTime)item[1];
                int duracion = (int)item[2];
                int id_cliente = Convert.ToInt32(item[3]);
                var list2 = consulta.Select("SELECT nombre, apellidos FROM CLIENTE WHERE id_usuario = '" + id_cliente + "';");
                string nombre = (string)list2[0][0] + " " + (string)list2[0][1];

                citasGridView.Rows.Add(fecha, duracion, nombre);
            }
        }

        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            loadCitas();
        }

        private void bEjercicios_Click(object sender, EventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Hide();
            ejercicios.Show();
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

        private void bSalir_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
