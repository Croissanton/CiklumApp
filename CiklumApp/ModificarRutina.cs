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
    public partial class ModificarRutina : Form
    {
        bool update = false;
        public ModificarRutina()
        {
            InitializeComponent();
        }

        public ModificarRutina(int sesionLunes, int dietaLunes, int sesionMartes, int dietaMartes, int sesionMiercoles,
            int dietaMiercoles, int sesionJueves, int dietaJueves, int sesionViernes, int dietaViernes, int sesionSabado,
            int dietaSabado, int sesionDomingo, int dietaDomingo)
        {
            InitializeComponent();
            tbSesionLunes.Text = sesionLunes.ToString();
            tbDietaLunes.Text = dietaLunes.ToString();
            tbSesionMartes.Text = sesionMartes.ToString();
            tbDietaMartes.Text = dietaMartes.ToString();
            tbSesionMiercoles.Text = sesionMiercoles.ToString();
            tbDietaMiercoles.Text = dietaMiercoles.ToString();
            tbSesionJueves.Text = sesionJueves.ToString();
            tbDietaJueves.Text = dietaJueves.ToString();
            tbSesionViernes.Text = sesionViernes.ToString();
            tbDietaViernes.Text = dietaViernes.ToString();
            tbSesionSabado.Text = sesionSabado.ToString();
            tbDietaSabado.Text = dietaSabado.ToString();
            tbSesionDomingo.Text = sesionDomingo.ToString();
            tbDietaDomingo.Text = dietaDomingo.ToString();

            update = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            if (tbSesionLunes.Text == "" || tbDietaLunes.Text == "" || tbSesionMartes.Text == "" || tbDietaMartes.Text == "" 
                || tbSesionMiercoles.Text == "" || tbDietaMiercoles.Text == "" || tbSesionJueves.Text == "" || tbDietaJueves.Text == "" 
                || tbSesionViernes.Text == "" || tbDietaViernes.Text == "" || tbSesionSabado.Text == "" || tbDietaSabado.Text == "" 
                || tbSesionDomingo.Text == "" || tbDietaDomingo.Text == "")
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }

            try
            {
                string sesionLunes = tbSesionLunes.Text;
                string dietaLunes = tbDietaLunes.Text;
                string sesionMartes = tbSesionMartes.Text;
                string dietaMartes = tbDietaMartes.Text;
                string sesionMiercoles = tbSesionMiercoles.Text;
                string dietaMiercoles = tbDietaMiercoles.Text;
                string sesionJueves = tbSesionJueves.Text;
                string dietaJueves = tbDietaJueves.Text;
                string sesionViernes = tbSesionViernes.Text;
                string dietaViernes = tbDietaViernes.Text;
                string sesionSabado = tbSesionSabado.Text;
                string dietaSabado = tbDietaSabado.Text;
                string sesionDomingo = tbSesionDomingo.Text;
                string dietaDomingo = tbDietaDomingo.Text;

                var consulta = new Consulta();
                if (update)
                {
                    consulta.Update("UPDATE RUTINA SET LUNESSESION = '" + sesionLunes + "', LUNESDIETA = '" + dietaLunes 
                        + "', MARTESSESION = '" + sesionMartes + "', MARTESDIETA = '" + dietaMartes + "', MIERCOLESSESION = '" 
                        + sesionMiercoles + "', MIERCOLESDIETA = '" + dietaMiercoles + "', JUEVESSESION = '" + sesionJueves 
                        + "', JUEVESDIETA = '" + dietaJueves + "', VIERNESSESION = '" + sesionViernes + "', VIERNESDIETA = '" 
                        + dietaViernes + "', SABADOSESION = '" + sesionSabado + "', SABADODIETA = '" + dietaSabado + "', DOMINGOSESION = '" 
                        + sesionDomingo + "', DOMINGODIETA = '" + dietaDomingo + "';");
                    MessageBox.Show("Rutina modificada correctamente.");
                } else
                {
                    consulta.Insert("INSERT INTO RUTINA (LUNESSESION, LUNESDIETA, MARTESSESION, MARTESDIETA, MIERCOLESSESION, MIERCOLESDIETA, " +
                        "JUEVESSESION, JUEVESDIETA, VIERNESSESION, VIERNESDIETA, SABADOSESION, SABADODIETA, DOMINGOSESION, DOMINGODIETA) " +
                        "VALUES ('" + sesionLunes + "', '" + dietaLunes + "', '" + sesionMartes + "', '" + dietaMartes + "', '" + sesionMiercoles + 
                        "', '" + dietaMiercoles + "', '" + sesionJueves + "', '" + dietaJueves + "', '" + sesionViernes + "', '" + dietaViernes +
                        "', '" + sesionSabado + "', '" + dietaSabado + "', '" + sesionDomingo + "', '" + dietaDomingo + "');");
                    MessageBox.Show("Rutina añadida correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Close();
        }
    }
}
