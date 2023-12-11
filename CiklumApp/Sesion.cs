using System;
using System.Windows.Forms;

namespace CiklumApp
{ 
    public partial class Sesion : Form
    {
        int sesion_id = -1;
        public Sesion()
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

        private void bClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void Sesion_Load_1(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM SESION");

            foreach (var item in list)
            {
                string nombre = (string)item[1];

                dgvSesiones.Rows.Add(Convert.ToInt32(item[0]), nombre);
            }
            dgvSesion.ClearSelection();
            dgvSesiones.ClearSelection();
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            ModificarSesion modificarSesion = new ModificarSesion(sesion_id);
            modificarSesion.Show();
            modificarSesion.FormClosed += new FormClosedEventHandler(modificarSesion_FormClosed);
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (dgvSesion.SelectedRows.Count > 0)
            {
                string nombre = dgvSesion.SelectedRows[0].Cells[0].Value.ToString();
                var consulta = new Consulta();
                consulta.Delete("DELETE FROM SESION WHERE NOMBRE = '" + nombre + "'");

                var sesion = new Sesion();
                this.Hide();
                sesion.Show();
            }
        }

        private void dgvSesion_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSesion.SelectedRows.Count > 0)
            {
                ModificarSesion modificarSesion = new ModificarSesion(sesion_id,
                    dgvSesion.SelectedRows[0].Cells[0].Value.ToString(),
                    int.Parse(dgvSesion.SelectedRows[0].Cells[1].Value.ToString()),
                    int.Parse(dgvSesion.SelectedRows[0].Cells[2].Value.ToString())
                    );
                modificarSesion.Show();

                modificarSesion.FormClosed += new FormClosedEventHandler(modificarSesion_FormClosed);
            }
        }

        private void modificarSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            var sesion = new Sesion();
            this.Close();
            sesion.Show();
        }

        private void dgvSesiones_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.SelectedRows.Count > 0)
            {
                this.sesion_id = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells[0].Value);
            }
        }
    }
}
