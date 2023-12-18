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
    public partial class DietaCliente : Form
    {
        public static int dieta_id = -1;
        public DietaCliente(int idDieta)
        {
            InitializeComponent();
            initMenu();
            dieta_id = idDieta;
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

        private void DietaCliente_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM DIETA WHERE ID = " + dieta_id);

            foreach (var item in list)
            {
                string nombre = (string)item[1];
                string desayuno = (string)item[2];
                string mediamanana = (string)item[3];
                string almuerzo = (string)item[4];
                string merienda = (string)item[5];
                string cena = (string)item[6];
                int calorias = Convert.ToInt32(item[7]);

                dgvDieta.Rows.Add(nombre, desayuno, mediamanana, almuerzo, merienda, cena, calorias);
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            RutinaCliente rutinaCliente = new RutinaCliente();
            rutinaCliente.Show();
        }
    }
}
