using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CiklumApp
{
    public partial class AñadirSesion : Form
    {
        public AñadirSesion()
        {
            InitializeComponent();
        }

        private void bAplicar_Click(object sender, System.EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }

            string nombre = tbNombre.Text;
            Random random = new Random();

            int id = random.Next(0, 1000000);
            var consulta = new Consulta();

            consulta.Insert("INSERT INTO SESION (ID, NOMBRE) VALUES (" + id + ", '" + nombre + "')");

            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
