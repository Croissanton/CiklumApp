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
    public partial class SesionCliente : Form
    {
        public static int id = -1;
        public SesionCliente(int idSesion)
        {
            InitializeComponent();
            id = idSesion;
            initMenu();

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

            cbMenu.SelectedIndex = 3;
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = cbMenu.SelectedIndex;
            switch (selected)
            {
                case 0:
                    var homeCliente = new HomeCliente();
                    this.Hide();
                    homeCliente.Show();
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
                    break;
                default:
                    break;
            }
        }

        private void bRutina_Click(object sender, EventArgs e)
        {
            var rutina = new RutinaCliente();
            this.Hide();
            rutina.Show();
        }

        private void SesionCliente_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT E.NOMBRE, ES.REPETICIONES, ES.SERIES FROM EJERCICIO E " +
                                   "JOIN EJERCICIO_SESION ES ON E.ID = ES.ID_EJERCICIO " +
                                                      "WHERE ES.ID_SESION = " + id + ";");
            foreach (var item in list)
            {
                string nombre = (string)item[0];
                int repeticiones = Convert.ToInt32(item[1]);
                int series = Convert.ToInt32(item[2]);

                dgvSesiones.Rows.Add(nombre, repeticiones, series);
            };
            dgvSesiones.ClearSelection();
        }
    }
}
