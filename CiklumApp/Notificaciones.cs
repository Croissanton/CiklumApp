using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CiklumApp
{
    public partial class Notificaciones : Form
    {

        private List<int> citas_ids = new List<int>();
        private int selected_id;
        public Notificaciones()
        {
            InitializeComponent();
            initNotificaciones();
        }

        private void loadCitas()
        {
            citas_ids.Clear();
            lbNotificaciones.Items.Clear();
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM CITA WHERE id_cliente = " + Login.user.ID() + " AND estado = 0;"); // estado 0 - pendiente, estado 1 - confirmada, estado 2 - rechazada

            foreach (var item in list)
            {
                int id = Convert.ToInt32(item[0]);
                citas_ids.Add(id);
                DateTime fecha = (DateTime)item[1];
                int duracion = (int)item[2];
                int id_entrenador = Convert.ToInt32(item[4]);
                var list2 = consulta.Select("SELECT nombre, apellidos FROM ENTRENADOR WHERE id_usuario = '" + id_entrenador + "';");
                string nombre = (string)list2[0][0] + " " + (string)list2[0][1];

                string notificacion = "Cita con " + nombre + " - " + fecha;
                lbNotificaciones.Items.Add(notificacion);
            }
        }
        private void initNotificaciones()
        {
            lbNotificaciones.Items.Clear();
            loadCitas();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            consulta.Update($"UPDATE CITA SET estado = 1 WHERE id = {selected_id}");
            this.Close();
        }

        private void bRechazar_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            consulta.Update($"UPDATE CITA SET estado = 2 WHERE id = {selected_id}");
            this.Close();
        }

        private void lbNotificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNotificaciones.SelectedIndex != -1)
            {
                selected_id = citas_ids[lbNotificaciones.SelectedIndex];   
            }
        }
    }
}
