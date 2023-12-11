using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class ModificarSesion : Form
    {
        bool update = false;

        public ModificarSesion()
        {
            InitializeComponent();
        }

        public ModificarSesion(string nombre, int repeticiones, int series)
        {
            InitializeComponent();
            tbNombre.Text = nombre;
            tbRepeticiones.Text = repeticiones.ToString();
            tbSeries.Text = series.ToString();

            update = true;
        }

        private void bCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void bAplicar_Click(object sender, System.EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }

            try
            {
                string nombre = tbNombre.Text;
                int repeticiones = int.Parse(tbRepeticiones.Text);
                int series = int.Parse(tbSeries.Text);

                var consulta = new Consulta();

                if (update)
                {
                    consulta.Update("UPDATE SESION SET NOMBRE = '" + nombre + "', REPETICIONES = '" + repeticiones + "', SERIES = '" + series + 
                        "' WHERE NOMBRE = '" + nombre + "'");
                }
                else
                {
                    consulta.Insert("INSERT INTO SESION (NOMBRE, REPETICIONES, SERIES) " +
                        "VALUES ('" + nombre + "','" + repeticiones + "','" + series + "')");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Número de repeticiones o sesiones incorrecta.");
                return;
            }

            this.Close();
        }
    }
}
