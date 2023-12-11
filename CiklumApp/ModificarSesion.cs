using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class ModificarSesion : Form
    {
        bool update = false;
        int sesion_id = -1;

        public ModificarSesion(int sesion_id)
        {
            InitializeComponent();
            this.sesion_id = sesion_id;
        }

        public ModificarSesion(int sesion_id, string nombre, int repeticiones, int series)
        {
            InitializeComponent();
            tbNombre.Text = nombre;
            tbRepeticiones.Text = repeticiones.ToString();
            tbSeries.Text = series.ToString();
            this.sesion_id = sesion_id;

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

/*            try
            {*/
                string nombre = tbNombre.Text;
                int repeticiones = int.Parse(tbRepeticiones.Text);
                int series = int.Parse(tbSeries.Text);

                var consulta = new Consulta();
                var list = consulta.Select("SELECT * FROM EJERCICIO WHERE NOMBRE = '" + nombre + "'");
                if(list.Count == 0)
                {
                    MessageBox.Show("No existe un ejercicio con ese nombre.");
                    return;
                }
                int id_ejercicio = Convert.ToInt32(list[0][0]);
                

                if (update)
                {
                    consulta.Update("UPDATE EJERCICIO_SESION SET REPETICIONES = " + repeticiones + ", SERIES = " + series + 
                        " WHERE ID_EJERCICIO = " + id_ejercicio + "");
                }
                else
                {
                    consulta.Insert("INSERT INTO EJERCICIO_SESION (ID_SESION, ID_EJERCICIO, REPETICIONES, SERIES) VALUES (" + sesion_id + ", " + id_ejercicio + ", " + repeticiones + ", " + series + ")");
                }
/*            }*/
/*            catch (Exception)
            {
                MessageBox.Show("Número de repeticiones o sesiones incorrecto.");
                return;
            }*/

            this.Close();
        }
    }
}
