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
    public partial class PerfilCliente : Form
    {
        public PerfilCliente()
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

            cbMenu.SelectedIndex = 1;
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
    }
}
