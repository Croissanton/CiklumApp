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
    public partial class Entrenadores : Form
    {
        public static int entrenador_id = -1;
        public Entrenadores()
        {
            InitializeComponent();
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

            cbMenu.SelectedIndex = 2;
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

        private void Entrenadores_Load(object sender, EventArgs e)
        {
            dgvEntrenadores.Rows.Clear();
            var consulta = new Consulta();
            var list = consulta.Select("SELECT DISTINCT E.ID_USUARIO, E.NOMBRE, E.APELLIDOS, E.ESPECIALIDAD FROM ENTRENADOR E " +
                "JOIN CLIENTE_ENTRENADOR C_E ON E.ID_USUARIO = C_E.ID_ENTRENADOR " +
                "WHERE C_E.ID_CLIENTE = " + Login.user.ID() + ";");
            //Create an array for storing numbers
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                this.dgvEntrenadores.Rows.Add(Convert.ToInt32(item[0]), (string)(item[1]), (string)item[2], (string)item[3]);
            }
            dgvEntrenadores.ClearSelection();
        }

        private void dgvEntrenadores_Click(object sender, EventArgs e)
        {
            if (dgvEntrenadores.SelectedRows.Count > 0)
            {
                entrenador_id = Convert.ToInt32(dgvEntrenadores.SelectedRows[0].Cells[0].Value);
            }
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            if (entrenador_id == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }
            this.Hide();
            var perfil = new PerfilEntrenador(entrenador_id);
            perfil.Show();
        }
    }
}
