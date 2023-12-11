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
            /*var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM RUTINA WHERE ");

            if ((string)item[1] != null) { bSesionLunes.Enabled = false; }
            if ((string)item[2] != null) { bDietaLunes.Enabled = false; }
            if ((string)item[3] != null) { bSesionMartes.Enabled = false; }
            if ((string)item[4] != null) { bDietaMartes.Enabled = false; }
            if ((string)item[5] != null) { bSesionMiercoles.Enabled = false; }
            if ((string)item[6] != null) { bDietaMiercoles.Enabled = false; }
            if ((string)item[7] != null) { bSesionJueves.Enabled = false; }
            if ((string)item[8] != null) { bDietaJueves.Enabled = false; }
            if ((string)item[9] != null) { bSesionViernes.Enabled = false; }
            if ((string)item[10] != null) { bDietaViernes.Enabled = false; }
            if ((string)item[11] != null) { bSesionSabado.Enabled = false; }
            if ((string)item[12] != null) { bDietaSabado.Enabled = false; }
            if ((string)item[13] != null) { bSesionDomingo.Enabled = false; }
            if ((string)item[14] != null) { bDietaDomingo.Enabled = false; }*/
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
