using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Rutina : Form
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

        public Rutina()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public Rutina(int id_rutina)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.id_rutina = id_rutina;
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
            { bSesionDomingo.Enabled = true; 
                id_SesionDomingo = Convert.ToInt32(list[13]);
            }

            if ((string)list[14] != null) 
            { 
                bDietaDomingo.Enabled = true;
                id_DietaDomingo = Convert.ToInt32(list[14]);
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModificarRutina modificarRutina = new ModificarRutina(id_rutina, id_SesionLunes, id_DietaLunes, id_SesionMartes, id_DietaMartes, 
                id_SesionMiercoles, id_DietaMiercoles, id_SesionJueves, id_DietaJueves, id_SesionViernes, id_DietaViernes, 
                id_SesionSabado, id_DietaSabado, id_SesionDomingo, id_DietaDomingo);
            modificarRutina.Show();
            modificarRutina.FormClosed += new FormClosedEventHandler(modificarRutina_FormClosed);
        }

        private void modificarRutina_FormClosed(object sender, FormClosedEventArgs e)
        {
            var rutina = new Rutina(id_rutina);
            this.Close();
            rutina.Show();
        }

        private void bSesionLunes_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionLunes);
            this.Close();
            sesion.Show();
        }

        private void bDietaLunes_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaLunes);
            this.Close();
            dieta.Show();
        }

        private void bSesionMartes_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionMartes);
            this.Close();
            sesion.Show();
        }

        private void bDietaMartes_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaMartes);
            this.Close();
            dieta.Show();
        }

        private void bSesionMiercoles_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionMiercoles);
            this.Close();
            sesion.Show();
        }

        private void bDietaMiercoles_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaMiercoles);
            this.Close();
            dieta.Show();
        }

        private void bSesionJueves_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionJueves);
            this.Close();
            sesion.Show();
        }

        private void bDietaJueves_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaJueves);
            this.Close();
            dieta.Show();
        }

        private void bSesionViernes_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionViernes);
            this.Close();
            sesion.Show();
        }

        private void bDietaViernes_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaViernes);
            this.Close();
            dieta.Show();
        }

        private void bSesionSabado_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionSabado);
            this.Close();
            sesion.Show();
        }

        private void bDietaSabado_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaSabado);
            this.Close();
            dieta.Show();
        }

        private void bSesionDomingo_Click(object sender, EventArgs e)
        {
            var sesion = new Sesion(id_SesionDomingo);
            this.Close();
            sesion.Show();
        }

        private void bDietaDomingo_Click(object sender, EventArgs e)
        {
            var dieta = new Dieta(id_DietaDomingo);
            this.Close();
            dieta.Show();
        }
    }
}
