using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            var list = consulta.Select($"SELECT ID_RUTINA FROM RUTINA_CLIENTE WHERE ID_CLIENTE = {Login.user.ID()}")[0];
            id_rutina = Convert.ToInt32(list[0]);
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

            if ((string)list[1] != null) bSesionLunes.Enabled = true; id_SesionLunes = Convert.ToInt32(list[1]);
            if ((string)list[2] != null) bDietaLunes.Enabled = true; id_DietaLunes = Convert.ToInt32(list[2]);
            if ((string)list[3] != null) bSesionMartes.Enabled = true; id_SesionMartes = Convert.ToInt32(list[3]);
            if ((string)list[4] != null) bDietaMartes.Enabled = true; id_DietaMartes = Convert.ToInt32(list[4]);
            if ((string)list[5] != null) bSesionMiercoles.Enabled = true; id_SesionMiercoles = Convert.ToInt32(list[5]);
            if ((string)list[6] != null) bDietaMiercoles.Enabled = true; id_DietaMiercoles = Convert.ToInt32(list[6]);
            if ((string)list[7] != null) bSesionJueves.Enabled = true; id_SesionJueves = Convert.ToInt32(list[7]);
            if ((string)list[8] != null) bDietaJueves.Enabled = true; id_DietaJueves = Convert.ToInt32(list[8]);
            if ((string)list[9] != null) bSesionViernes.Enabled = true; id_SesionViernes = Convert.ToInt32(list[9]);
            if ((string)list[10] != null) bDietaViernes.Enabled = true; id_DietaViernes = Convert.ToInt32(list[10]);
            if ((string)list[11] != null) bSesionSabado.Enabled = true; id_SesionSabado = Convert.ToInt32(list[11]);
            if ((string)list[12] != null) bDietaSabado.Enabled = true; id_DietaSabado = Convert.ToInt32(list[12]);
            if ((string)list[13] != null) bSesionDomingo.Enabled = true; id_SesionDomingo = Convert.ToInt32(list[13]);
            if ((string)list[14] != null) bDietaDomingo.Enabled = true; id_DietaDomingo = Convert.ToInt32(list[14]);



            var consulta2 = new Consulta();
            var list2 = consulta2.Select("SELECT LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO FROM CLIENTE WHERE ID_USUARIO = " + Login.user.ID())[0];

            if (Convert.ToInt32(list2[0]) == 1) { cbSesionLunes.Checked = true; cbDietaLunes.Checked = true; bFeedbackLunes.Enabled = true; }
            else { cbSesionLunes.Checked = false; cbDietaLunes.Checked = false; bFeedbackLunes.Enabled = false; }
            if (Convert.ToInt32(list2[1]) == 1) { cbSesionMartes.Checked = true; cbDietaMartes.Checked = true; bFeedbackMartes.Enabled = true; }
            else { cbSesionMartes.Checked = false; cbDietaMartes.Checked = false; bFeedbackMartes.Enabled = false; }
            if (Convert.ToInt32(list2[2]) == 1) { cbSesionMiercoles.Checked = true; cbDietaMiercoles.Checked = true; bFeedbackMiercoles.Enabled = true; }
            else { cbSesionMiercoles.Checked = false; cbDietaMiercoles.Checked = false; bFeedbackMiercoles.Enabled = false; }
            if (Convert.ToInt32(list2[3]) == 1) { cbSesionJueves.Checked = true; cbDietaJueves.Checked = true; bFeedbackJueves.Enabled = true; }
            else { cbSesionJueves.Checked = false; cbDietaJueves.Checked = false; bFeedbackJueves.Enabled = false; }
            if (Convert.ToInt32(list2[4]) == 1) { cbSesionViernes.Checked = true; cbDietaViernes.Checked = true; bFeedbackViernes.Enabled = true; }
            else { cbSesionViernes.Checked = false; cbDietaViernes.Checked = false; bFeedbackViernes.Enabled = false; }
            if (Convert.ToInt32(list2[5]) == 1) { cbSesionSabado.Checked = true; cbDietaSabado.Checked = true; bFeedbackSabado.Enabled = true; }
            else { cbSesionSabado.Checked = false; cbDietaSabado.Checked = false; bFeedbackSabado.Enabled = false; }
            if (Convert.ToInt32(list2[6]) == 1) { cbSesionDomingo.Checked = true; cbDietaDomingo.Checked = true; bFeedbackDomingo.Enabled = true; }
            else { cbSesionDomingo.Checked = false; cbDietaDomingo.Checked = false; bFeedbackDomingo.Enabled = false; }
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
            FeedbackSesion feedback = new FeedbackSesion(id_SesionLunes);
            feedback.Show();
        }

        private void bFeedbackMartes_Click(object sender, EventArgs e)
        {
            FeedbackSesion feedback = new FeedbackSesion(id_SesionMartes);
            feedback.Show();
        }

        private void bFeedbackMiercoles_Click(object sender, EventArgs e)
        {
            FeedbackSesion feedback = new FeedbackSesion(id_SesionMiercoles);
            feedback.Show();
        }

        private void bFeedbackJueves_Click(object sender, EventArgs e)
        {
            FeedbackSesion feedback = new FeedbackSesion(id_SesionJueves);
            feedback.Show();
        }

        private void bFeedbackViernes_Click(object sender, EventArgs e)
        {
            FeedbackSesion feedback = new FeedbackSesion(id_SesionViernes);
            feedback.Show();
        }

        private void bFeedbackSabado_Click(object sender, EventArgs e)
        {
            FeedbackSesion feedback = new FeedbackSesion(id_SesionSabado);
            feedback.Show();
        }

        private void bFeedbackDomingo_Click(object sender, EventArgs e)
        {
            FeedbackSesion feedback = new FeedbackSesion(id_SesionDomingo);
            feedback.Show();
        }

        private void cbSesionLunes_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionLunes.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET LUNES = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaLunes.Enabled = true;
                bFeedbackLunes.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET LUNES = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaLunes.Enabled = false;
                bFeedbackLunes.Enabled = false;
            }
        }

        private void cbSesionMartes_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionMartes.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET MARTES = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaMartes.Enabled = true;
                bFeedbackMartes.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET MARTES = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaMartes.Enabled = false;
                bFeedbackMartes.Enabled = false;
            }
        }

        private void cbSesionMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionMiercoles.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET MIERCOLES = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaMiercoles.Enabled = true;
                bFeedbackMiercoles.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET MIERCOLES = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaMiercoles.Enabled = false;
                bFeedbackMiercoles.Enabled = false;
            }
        }

        private void cbSesionJueves_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionJueves.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET JUEVES = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaJueves.Enabled = true;
                bFeedbackJueves.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET JUEVES = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaJueves.Enabled = false;
                bFeedbackJueves.Enabled = false;
            }
        }

        private void cbSesionViernes_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionViernes.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET VIERNES = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaViernes.Enabled = true;
                bFeedbackViernes.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET VIERNES = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaViernes.Enabled = false;
                bFeedbackViernes.Enabled = false;
            }
        }

        private void cbSesionSabado_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionSabado.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET SABADO = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaSabado.Enabled = true;
                bFeedbackSabado.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET SABADO = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaSabado.Enabled = false;
                bFeedbackSabado.Enabled = false;
            }
        }

        private void cbSesionDomingo_CheckedChanged(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            if (cbSesionDomingo.Checked)
            {
                consulta.Update($"UPDATE CLIENTE SET DOMINGO = 1 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaDomingo.Enabled = true;
                bFeedbackDomingo.Enabled = true;
            }
            else
            {
                consulta.Update($"UPDATE CLIENTE SET DOMINGO = 0 WHERE ID_USUARIO = {Login.user.ID()}");
                cbDietaDomingo.Enabled = false;
                bFeedbackDomingo.Enabled = false;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
            var rutinaCliente = new RutinaCliente();
            rutinaCliente.Show();
        }

        private void bDietaLunes_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaLunes);
            this.Close();
            dietaCliente.Show();
        }

        private void bDietaMartes_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaMartes);
            this.Close();
            dietaCliente.Show();
        }

        private void bDietaMiercoles_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaMiercoles);
            this.Close();
            dietaCliente.Show();
        }

        private void bDietaJueves_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaJueves);
            this.Close();
            dietaCliente.Show();
        }

        private void bDietaViernes_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaViernes);
            this.Close();
            dietaCliente.Show();
        }

        private void bDietaSabado_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaSabado);
            this.Close();
            dietaCliente.Show();
        }

        private void bDietaDomingo_Click_1(object sender, EventArgs e)
        {
            var dietaCliente = new DietaCliente(id_DietaDomingo);
            this.Close();
            dietaCliente.Show();
        }

        private void bSesionLunes_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionLunes);
            this.Close();
            sesionCliente.Show();
        }

        private void bSesionMartes_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionMartes);
            this.Close();
            sesionCliente.Show();
        }

        private void bSesionMiercoles_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionMiercoles);
            this.Close();
            sesionCliente.Show();
        }

        private void bSesionJueves_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionJueves);
            this.Close();
            sesionCliente.Show();
        }

        private void bSesionViernes_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionViernes);
            this.Close();
            sesionCliente.Show();
        }

        private void bSesionSabado_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionSabado);
            this.Close();
            sesionCliente.Show();
        }

        private void bSesionDomingo_Click_1(object sender, EventArgs e)
        {
            var sesionCliente = new SesionCliente(id_SesionDomingo);
            this.Close();
            sesionCliente.Show();
        }
    }
}
