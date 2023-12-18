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
        string duracion;
        string tipo;
        DateTime dateTime;

        public ModificarCita(int id_cita)
        {
            InitializeComponent();
            this.id_cita = id_cita;
        }

        public ModificarCita(int id_cita, string duracion, string tipo)
        {
            InitializeComponent();
            this.id_cita = id_cita;
            this.duracion = duracion;
            this.tipo = tipo;
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            if (tbTipo.Text == "" || dateTimePicker.Value == null)
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }

            this.duracion = tbDuracion.Text;
            this.tipo = tbTipo.Text;
            this.dateTime = dateTimePicker.Value;

            var consulta = new Consulta();
            consulta.Update("UPDATE CITA SET fecha = " + dateTime.Year + dateTime.Month + dateTime.Day +
                        ", tipo = '" + this.tipo + "', duracion = " + this.duracion + " WHERE id = " + this.id_cita + "");

            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarCita_Load(object sender, EventArgs e)
        {
            tbDuracion.Text = duracion;
            tbTipo.Text = tipo;
        }
    }
}
