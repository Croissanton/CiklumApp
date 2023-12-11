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
            };
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
                var list = consulta.Select("SELECT * FROM EJERCICIO WHERE NOMBRE = '" + nombre + "'");
              if (list.Count == 0)
                {
                    MessageBox.Show("No existe un ejercicio con ese nombre.");
                    return;
                }
              int ejercicio_id = Convert.ToInt32(list[0][0]);
                consulta.Delete("DELETE FROM EJERCICIO_SESION " +
                                       "WHERE ID_SESION = " + sesion_id + " AND ID_EJERCICIO = " + ejercicio_id + "");

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
                dgvSesion.Rows.Clear();
                this.sesion_id = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells[0].Value);
                var consulta = new Consulta();
                var list = consulta.Select("SELECT E.NOMBRE, ES.REPETICIONES, ES.SERIES FROM EJERCICIO E " +
                                       "JOIN EJERCICIO_SESION ES ON E.ID = ES.ID_EJERCICIO " +
                                                          "WHERE ES.ID_SESION = " + sesion_id + ";");
                foreach (var item in list)
                {
                    string nombre = (string)item[0];
                    int repeticiones = Convert.ToInt32(item[1]);
                    int series = Convert.ToInt32(item[2]);

                    dgvSesion.Rows.Add(nombre, repeticiones, series);
                };
                dgvSesion.ClearSelection();
            }
        }

        private void añadirSesion_Click(object sender, EventArgs e)
        {
            AñadirSesion añadirSesion = new AñadirSesion();
            añadirSesion.Show();
            añadirSesion.FormClosed += new FormClosedEventHandler(añadirSesion_FormClosed);
        }

        private void borrarSesion_Click(object sender, EventArgs e)
        {
                if (dgvSesiones.SelectedRows.Count > 0)
                {
                    sesion_id = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells[0].Value.ToString());
                    var consulta = new Consulta();
                    consulta.Delete("DELETE FROM SESION WHERE ID = '" + sesion_id + "'");

                    var ses = new Sesion();
                    this.Hide();
                    ses.Show();
                }
        }

        private void añadirSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            var s = new Sesion();
            this.Close();
            s.Show();
        }
    }
}
