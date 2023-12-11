using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Rutina : Form
    {
        public Rutina()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Hide();
            home.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void bSesiones_Click(object sender, EventArgs e)
        {
            var sesiones = new Sesion();
            this.Hide();
            sesiones.Show();
        }

        private void bEjercicios_Click(object sender, EventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Hide();
            ejercicios.Show();
        }

        private void Rutina_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM RUTINA");

            foreach (var item in list)
            {
                string SesionLunes = (string)item[1];
                string DietaLunes = (string)item[2];
                string SesionMartes = (string)item[3];
                string DietaMartes = (string)item[4];
                string SesionMiercoles = (string)item[5];
                string DietaMiercoles = (string)item[6];
                string SesionJueves = (string)item[7];
                string DietaJueves = (string)item[8];
                string SesionViernes = (string)item[9];
                string DietaViernes = (string)item[10];
                string SesionSabado = (string)item[11];
                string DietaSabado = (string)item[12];
                string SesionDomingo = (string)item[13];
                string DietaDomingo = (string)item[14];
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModificarRutina modificarRutina = new ModificarRutina();
            modificarRutina.Show();
            modificarRutina.FormClosed += new FormClosedEventHandler(modificarRutina_FormClosed);
        }

        private void modificarRutina_FormClosed(object sender, FormClosedEventArgs e)
        {
            var rutina = new Rutina();
            this.Close();
            rutina.Show();
        }
    }
}
