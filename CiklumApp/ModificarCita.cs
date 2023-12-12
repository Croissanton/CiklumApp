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
    public partial class ModificarCita : Form
    {
        private int id_cita;
        public ModificarCita(int id_cita)
        {
            InitializeComponent();
            this.id_cita = id_cita;
        }

  

        private void bAplicar_Click(object sender, EventArgs e)
        {
            if (tbTipo.Text == "" || dateTimePicker.Value == null)
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }

            string duracion = tbDuracion.Text;
            string tipo = tbTipo.Text;
            DateTime dateTime = dateTimePicker.Value;

            var consulta = new Consulta();
            consulta.Update("UPDATE CITA SET fecha = " + dateTime.Year + dateTime.Month + dateTime.Day +
                        ", tipo = '" + tipo + "', duracion = " + duracion + " WHERE id = " + id_cita + "");

            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
