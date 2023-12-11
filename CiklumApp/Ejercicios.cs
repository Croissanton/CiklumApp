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

        private void bAñadir_Click(object sender, EventArgs e)
        {
            ModificarEjercicio modificarEjercicio = new ModificarEjercicio();
            modificarEjercicio.Show();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (dgvEjercicios.SelectedRows.Count > 0)
            {
                string nombre = dgvEjercicios.SelectedRows[0].Cells[0].Value.ToString();
                var consulta = new Consulta();
                consulta.Delete("DELETE FROM EJERCICIO WHERE NOMBRE = '" + nombre + "'");

                var ejercicios = new Ejercicios();
                this.Hide();
                ejercicios.Show();
            }
        }

        private void dgvEjercicios_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEjercicios.SelectedRows.Count > 0)
            {
                ModificarEjercicio modificarEjercicio = new ModificarEjercicio(
                    dgvEjercicios.SelectedRows[0].Cells[0].Value.ToString(),
                    dgvEjercicios.SelectedRows[0].Cells[1].Value.ToString(),
                    int.Parse(dgvEjercicios.SelectedRows[0].Cells[2].Value.ToString()),
                    dgvEjercicios.SelectedRows[0].Cells[3].Value.ToString(),
                    dgvEjercicios.SelectedRows[0].Cells[4].Value.ToString(),
                    dgvEjercicios.SelectedRows[0].Cells[5].Value.ToString()
                    );
                modificarEjercicio.Show();

                modificarEjercicio.FormClosed += new FormClosedEventHandler(modificarEjercicio_FormClosed);
            }
        }

        private void modificarEjercicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Hide();
            ejercicios.Show();
        }
    }
}
