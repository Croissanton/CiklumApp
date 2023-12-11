using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class ModificarEjercicio : Form
    {
        bool update = false;

        public ModificarEjercicio()
        {
            InitializeComponent();
        }

        public ModificarEjercicio(string nombre, string tipo, int duracion, string descripcion, string video, string privacidad)
        {
            InitializeComponent();
            tbNombre.Text = nombre;
            tbTipo.Text = tipo;
            tbDuracion.Text = duracion.ToString();
            tbDescripcion.Text = descripcion;
            tbEnlace.Text = video;

            if (privacidad == "privado")
            {
                cbPrivado.Checked = true;
            }
            else
            {
                cbPrivado.Checked = false;
            }

            update = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbTipo.Text == "" || tbDescripcion.Text == "" || tbEnlace.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }

            try {
                string nombre = tbNombre.Text;
                string tipo = tbTipo.Text;
                int duracion = int.Parse(tbDuracion.Text);
                string descripcion = tbDescripcion.Text;
                string enlace = tbEnlace.Text;
                string privado = null;

                if (cbPrivado.Checked)
                {
                    privado = "privado";
                }
                else
                {
                    privado = "publico";
                }

                var consulta = new Consulta();

                if (update)
                {
                    consulta.Update("UPDATE EJERCICIO SET NOMBRE = '" + nombre + "', TIPO = '" + tipo + "', DURACION = " + duracion + 
                        ", DESCRIPCION = '" + descripcion + "', VIDEO_URL = '" + enlace + "', PRIVACIDAD = '" + privado + 
                        "' WHERE NOMBRE = '" + nombre + "'");
                }
                else 
                {
                    consulta.Insert("INSERT INTO EJERCICIO (NOMBRE, TIPO, DURACION, DESCRIPCION, VIDEO_URL, PRIVACIDAD) " +
                        "VALUES ('" + nombre + "', '" + tipo + "', " + duracion + ", '" + descripcion + "', '" + enlace + "', '" + privado + "')");
                }


                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Duración incorrecta.");
                return;
            }

            this.Close();
        }
    }
}
