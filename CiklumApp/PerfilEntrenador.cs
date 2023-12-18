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
    public partial class PerfilEntrenador : Form
    {
        public static int entrenador_id = -1;
        public PerfilEntrenador(int id)
        {
            InitializeComponent();
            initMenu();
            entrenador_id = id;
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

        private void PerfilEntrenador_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var datosEntrenador = consulta.Select($"SELECT NOMBRE, APELLIDOS, CORREO, ESPECIALIDAD, HORAINICIAL, HORAFINAL FROM ENTRENADOR WHERE ID_USUARIO = {entrenador_id}")[0];
            tbNombre.Text = (string)datosEntrenador[0];
            tbApellidos.Text = (string)datosEntrenador[1];
            lNombreEntrenador.Text = tbNombre.Text + " " + tbApellidos.Text;
            tbCorreo.Text = (string)datosEntrenador[2];
            tbEspecialidad.Text = (string)datosEntrenador[3];
            tbHorario.Text = "UNAVAILABLE"; //datosEntrenador[4].ToString("HH:mm:ss") + " - " + datosEntrenador[5].ToString("HH:mm:ss");
            dgvResenas.Rows.Clear();
            var list = consulta.Select("SELECT * FROM RESENA_ENTRENADOR WHERE ID_ENTRENADOR = " + entrenador_id + ";");
            int suma = 0;
            int contador = 0;
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                this.dgvResenas.Rows.Add(Convert.ToInt32(item[0]), (string)item[2], Convert.ToInt32(item[1]));
                suma += Convert.ToInt32(item[1]);
                ++contador;
            }
            if (contador > 0)
            {
                lValoracion.Text = "Valoración: " + (suma / contador).ToString();
            }
            else
            {
                lValoracion.Text = "Valoración: 0";
            }
            dgvResenas.ClearSelection();
        }

        private void bEnviarFeedback_Click(object sender, EventArgs e)
        {
            var feedback = new FeedbackEntrenador(entrenador_id);
            this.Hide();
            feedback.Show();
        }
    }
}
