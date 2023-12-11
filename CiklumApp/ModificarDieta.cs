using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CiklumApp
{
    public partial class ModificarDieta : Form
    {
        bool update = false;
        public ModificarDieta()
        {
            InitializeComponent();
        }


        public ModificarDieta(string desayuno, string media, string almuerzo, string merienda, string cena, string calorias)
        {
            InitializeComponent();
            tbDes.Text = desayuno;
            tbMed.Text = media;
            tbComida.Text = almuerzo;
            tbMerienda.Text = merienda;
            tbCena.Text = cena;
            tbCalorias.Text = calorias.ToString();

            update = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            //comprueba si las calorias son correctas
            try { tbCalorias.Text = int.Parse(tbCalorias.Text).ToString(); }
            catch (Exception) { MessageBox.Show("FORMATO: Calorias incorrectas"); return; }
            if(int.Parse(tbCalorias.Text) < 0) { MessageBox.Show("FORMATO: Calorias negativas"); return; }

            try
            {
                string desayuno = tbDes.Text;
                string media = tbMed.Text;
                string almuerzo = tbComida.Text;
                string merienda = tbMerienda.Text;
                string cena = tbCena.Text;
                uint calorias = (uint)int.Parse(tbCalorias.Text);

                var consulta = new Consulta();

                if (update)
                {
                    /*consulta.Update("UPDATE EJERCICIO SET NOMBRE = '" + nombre + "', TIPO = '" + tipo + "', DURACION = " + duracion +
                        ", DESCRIPCION = '" + descripcion + "', VIDEO_URL = '" + enlace + "', PRIVACIDAD = '" + privado +
                        "' WHERE NOMBRE = '" + nombre + "'");*/
                }
                else
                {
                    /*consulta.Insert("INSERT INTO EJERCICIO (NOMBRE, TIPO, DURACION, DESCRIPCION, VIDEO_URL, PRIVACIDAD) " +
                        "VALUES ('" + nombre + "', '" + tipo + "', " + duracion + ", '" + descripcion + "', '" + enlace + "', '" + privado + "')");*/
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
