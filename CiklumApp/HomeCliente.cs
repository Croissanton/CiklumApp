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
    public partial class HomeCliente : Form
    {
        public HomeCliente()
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

            cbMenu.SelectedIndex = 0;
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bNotificaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
