using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class RutinaCliente : Form
    {
        int id_rutina = -1;
        int id_SesionLunes = -1;
        int id_SesionMartes = -1;
        int id_SesionMiercoles = -1;
        int id_SesionJueves = -1;
        int id_SesionViernes = -1;
        int id_SesionSabado = -1;
        int id_SesionDomingo = -1;
        int id_DietaLunes = -1;
        int id_DietaMartes = -1;
        int id_DietaMiercoles = -1;
        int id_DietaJueves = -1;
        int id_DietaViernes = -1;
        int id_DietaSabado = -1;
        int id_DietaDomingo = -1;

        public RutinaCliente()
        {
            InitializeComponent();
            initMenu();

            getIDRutina();
        }



        private void getIDRutina()
        {
            var consulta = new Consulta();
            var list = consulta.Select($"SELECT ID FROM CLIENTE WHERE ID_USUARIO = {Login.user.ID()}")[0];
            int idCliente = Convert.ToInt32(list[0]);

            var consulta2 = new Consulta();
            var list2 = consulta2.Select($"SELECT ID_RUTINA FROM RUTINA_CLIENTE WHERE ID_CLIENTE = {idCliente}")[0];
            id_rutina = Convert.ToInt32(list2[0]);
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

        private void RutinaCliente_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM RUTINA WHERE ID = " + id_rutina)[0];

            if ((string)list[1] != null)
            {
                bSesionLunes.Enabled = true;
                id_SesionLunes = Convert.ToInt32(list[1]);
            }

            if ((string)list[2] != null)
            {
                bDietaLunes.Enabled = true;
                id_DietaLunes = Convert.ToInt32(list[2]);
            }

            if ((string)list[3] != null)
            {
                bSesionMartes.Enabled = true;
                id_SesionMartes = Convert.ToInt32(list[3]);
            }

            if ((string)list[4] != null)
            {
                bDietaMartes.Enabled = true;
                id_DietaMartes = Convert.ToInt32(list[4]);
            }

            if ((string)list[5] != null)
            {
                bSesionMiercoles.Enabled = true;
                id_SesionMiercoles = Convert.ToInt32(list[5]);
            }

            if ((string)list[6] != null)
            {
                bDietaMiercoles.Enabled = true;
                id_DietaMiercoles = Convert.ToInt32(list[6]);
            }

            if ((string)list[7] != null)
            {
                bSesionJueves.Enabled = true;
                id_SesionJueves = Convert.ToInt32(list[7]);
            }

            if ((string)list[8] != null)
            {
                bDietaJueves.Enabled = true;
                id_DietaJueves = Convert.ToInt32(list[8]);
            }

            if ((string)list[9] != null)
            {
                bSesionViernes.Enabled = true;
                id_SesionViernes = Convert.ToInt32(list[9]);
            }

            if ((string)list[10] != null)
            {
                bDietaViernes.Enabled = true;
                id_DietaViernes = Convert.ToInt32(list[10]);
            }

            if ((string)list[11] != null)
            {
                bSesionSabado.Enabled = true;
                id_SesionSabado = Convert.ToInt32(list[11]);
            }

            if ((string)list[12] != null)
            {
                bDietaSabado.Enabled = true;
                id_DietaSabado = Convert.ToInt32(list[12]);
            }

            if ((string)list[13] != null)
            {
                bSesionDomingo.Enabled = true;
                id_SesionDomingo = Convert.ToInt32(list[13]);
            }

            if ((string)list[14] != null)
            {
                bDietaDomingo.Enabled = true;
                id_DietaDomingo = Convert.ToInt32(list[14]);
            }
        }

        private void bSesionLunes_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionLunes);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaLunes_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaLunes);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionMartes_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionMartes);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaMartes_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaMartes);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionMiercoles_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionMiercoles);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaMiercoles_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaMiercoles);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionJueves_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionJueves);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaJueves_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaJueves);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionViernes_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionViernes);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaViernes_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaViernes);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionSabado_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionSabado);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaSabado_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaSabado);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionDomingo_Click(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionDomingo);
            this.Close();
            sesionCliente.Show();
        }

        private void bDietaDomingo_Click(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaDomingo);
            this.Close();
            dietaCliente.Show();
        }

        private void bFeedbackLunes_Click(object sender, EventArgs e)
        {
            Fe
        }

        private void bFeedbackMartes_Click(object sender, EventArgs e)
        {

        }

        private void bFeedbackMiercoles_Click(object sender, EventArgs e)
        {

        }

        private void bFeedbackJueves_Click(object sender, EventArgs e)
        {

        }

        private void bFeedbackViernes_Click(object sender, EventArgs e)
        {

        }

        private void bFeedbackSabado_Click(object sender, EventArgs e)
        {

        }

        private void bFeedbackDomingo_Click(object sender, EventArgs e)
        {

        }
    }
}
