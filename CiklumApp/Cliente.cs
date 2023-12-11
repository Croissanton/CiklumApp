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
    public partial class lCliente : Form
    {
        int cliente_id = -1;
        int id_runita = -1;
        int id_sesion = -1;
        public lCliente(int cliente_id)
        {
            this.cliente_id = cliente_id;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
        }

        private void lCliente_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT NOMBRE, APELLIDOS FROM CLIENTE WHERE ID_USUARIO = " + cliente_id + ";");
            this.label2.Text = (string)list[0][0] + " " + (string)list[0][1];
            
            var list2 = consulta.Select("SELECT ID_RUTINA FROM RUTINA_CLIENTE WHERE ID_CLIENTE = " + cliente_id + ";");
            foreach (var item in list2)
            {
                int id_rutina = Convert.ToInt32(item[0]);
                string nombre_rutina = "RUTINA: " + id_rutina.ToString();
                this.dgvRutinas.Rows.Add(id_rutina, nombre_rutina);
            }
            dgvRutinas.ClearSelection();
        }

        private void bSesion_Click(object sender, EventArgs e)
        {
            if (dgvSesion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sesion");
                return;
            }
            var sesiones = new Sesion(id_sesion);
            this.Close();
            sesiones.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            this.Close();
            clientes.Show();
        }

        private void bEjercicios_Click(object sender, EventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Close();
            ejercicios.Show();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            var home = new Home();
            this.Close();
            home.Show();
        }

        private void bSesiones_Click(object sender, EventArgs e)
        {
            var sesiones = new Sesion();
            this.Close();
            sesiones.Show();
        }

        private void bRutina_Click(object sender, EventArgs e)
        {
            if(dgvRutinas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una rutina");
                return;
            }
            var r = new Rutina(id_runita);
            this.Close();
            r.Show();
        }

        private void dgvRutinas_Click(object sender, EventArgs e)
        {
            if (dgvRutinas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una rutina");
                return;
            }
            id_runita = Convert.ToInt32(dgvRutinas.SelectedRows[0].Cells[0].Value);
            dgvSesion.Rows.Clear();
            var consulta = new Consulta();
            var list = consulta.Select("SELECT LUNESSESION, MARTESSESION, MIERCOLESSESION, JUEVESSESION, VIERNESSESION, SABADOSESION, DOMINGOSESION FROM RUTINA WHERE ID = " + id_runita + ";");
            int id_sesionLunes = Convert.ToInt32(list[0][0]);
            int id_sesionMartes = Convert.ToInt32(list[0][1]);
            int id_sesionMiercoles = Convert.ToInt32(list[0][2]);
            int id_sesionJueves = Convert.ToInt32(list[0][3]);
            int id_sesionViernes = Convert.ToInt32(list[0][4]);
            int id_sesionSabado = Convert.ToInt32(list[0][5]);
            int id_sesionDomingo = Convert.ToInt32(list[0][6]);
            if (id_sesionLunes > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionLunes + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionLunes, nombre_sesion);
            }
            if (id_sesionMartes > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionMartes + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionMartes, nombre_sesion);
            }
            if (id_sesionMiercoles > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionMiercoles + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionMiercoles, nombre_sesion);
            }
            if (id_sesionJueves > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionJueves + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionJueves, nombre_sesion);
            }
            if (id_sesionViernes > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionViernes + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionViernes, nombre_sesion);
            }
            if (id_sesionSabado > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionSabado + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionSabado, nombre_sesion);
            }
            if (id_sesionDomingo > 0)
            {
                var list2 = consulta.Select("SELECT NOMBRE FROM SESION WHERE ID = " + id_sesionDomingo + ";");
                string nombre_sesion = (string)list2[0][0];
                this.dgvSesion.Rows.Add(id_sesionDomingo, nombre_sesion);
            }
            dgvSesion.ClearSelection();
        }

        private void dgvSesion_Click(object sender, EventArgs e)
        {
            if(dgvSesion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sesion");
                return;
            }
            id_sesion = Convert.ToInt32(dgvSesion.SelectedRows[0].Cells[0].Value);
        }
    }
}
