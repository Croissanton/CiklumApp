using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class HomeCliente : Form
    {
        public HomeCliente()
        {
            InitializeComponent();
            initMenu();
            loadCitas();
        }

        private void loadCitas()
        {
            citasGridView.Rows.Clear();

            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM CITA WHERE id_cliente = " + Login.user.ID() + " AND estado = 1;"); // estado 0 - pendiente, estado 1 - confirmada, estado 2 - rechazada

            foreach (var item in list)
            {
                int id = Convert.ToInt32(item[0]);
                DateTime fecha = (DateTime)item[1];
                int duracion = (int)item[2];
                int id_entrenador = Convert.ToInt32(item[4]);
                string tipo = (string)item[5];
                var list2 = consulta.Select("SELECT nombre, apellidos FROM ENTRENADOR WHERE id_usuario = '" + id_entrenador + "';");
                string nombre = (string)list2[0][0] + " " + (string)list2[0][1];

                citasGridView.Rows.Add(id, fecha, duracion, nombre, tipo);
            }
        }

        private void initMenu()
        {
            cbMenu.Items.Clear();
            List<string> items = new List<string>
            {
                "Home",
                "Perfil",
                "Entrenadores",
                "Rutina"
            };
            foreach (string item in items)
            {
                cbMenu.Items.Add(item);
            }

            cbMenu.SelectedIndex = 0;
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = cbMenu.SelectedIndex;
            switch (selected)
            {
                case 0:
                    break;
                case 1:
                    var perfil = new PerfilCliente();
                    this.Hide();
                    perfil.Show();
                    break;
                case 2:
                    var entrenadoers = new Entrenadores();
                    this.Hide();
                    entrenadoers.Show();
                    break;
                case 3:
                    var rutina = new RutinaCliente();
                    this.Hide();
                    rutina.Show();
                    break;
                default:
                    break;
            }
        }

        private void bNotificaciones_Click(object sender, EventArgs e)
        {
            var notificaciones = new Notificaciones();
            notificaciones.FormClosed += new FormClosedEventHandler(Notificaciones_FormClosed);
            notificaciones.ShowDialog();
        }

        private void Notificaciones_FormClosed(object sender, EventArgs e)
        {
            this.Close();
            HomeCliente home = new HomeCliente();
            home.Show();
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
