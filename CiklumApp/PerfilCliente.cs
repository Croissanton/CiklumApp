using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

            setData();
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



        private void setData()
        {
            var consulta = new Consulta();
            var datosCliente = consulta.Select($"SELECT * FROM CLIENTE WHERE ID_USUARIO = {Login.user.ID()}")[0];
            tbNombre.Text = (string) datosCliente[1];
            tbApellidos.Text = (string) datosCliente[2];
            lNombreCliente.Text = tbNombre.Text + " " + tbApellidos.Text;
            tbAltura.Text = Math.Round((Convert.ToDouble(datosCliente[6])), 2).ToString();
            tbPeso.Text = Math.Round((Convert.ToDouble(datosCliente[5])), 2).ToString();

            var IMC = Math.Round(Convert.ToDouble(tbPeso.Text) / (Convert.ToDouble(tbAltura.Text) / 100 * Convert.ToDouble(tbAltura.Text) / 100), 2);
            tbIMC.Text = IMC.ToString();
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



        private void bGuardar_Click(object sender, EventArgs e)
        {
            Confirmacion confirmacion = new Confirmacion(tbAltura.Text, tbPeso.Text);
            confirmacion.FormClosed += new FormClosedEventHandler(Confirmacion_FormClosed);
            confirmacion.ShowDialog();
        }



        private void Confirmacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            PerfilCliente perfilCliente = new PerfilCliente();
            perfilCliente.Show();
        }
    }
}
