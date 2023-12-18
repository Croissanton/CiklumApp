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
            var list = consulta.Select("SELECT * FROM CITA WHERE id_entrenador = '" + Login.user.ID() + "';");

            foreach (var item in list)
            {
                int id = Convert.ToInt32(item[0]);
                DateTime fecha = (DateTime)item[1];
                int duracion = (int)item[2];
                int id_cliente = Convert.ToInt32(item[3]);
                var list2 = consulta.Select("SELECT nombre, apellidos FROM CLIENTE WHERE id_usuario = '" + id_cliente + "';");
                string nombre = (string)list2[0][0] + " " + (string)list2[0][1];

                citasGridView.Rows.Add(id, fecha, duracion, nombre);
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

        private void bModificar_Click(object sender, EventArgs e)
        {
            if (citasGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccion la cita.");
                return;
            }
            int id_cita = Convert.ToInt32(citasGridView.SelectedRows[0].Cells[0].Value);

            ModificarCita modificarCita = new ModificarCita(id_cita);
            modificarCita.Show();
        }
    }
}
