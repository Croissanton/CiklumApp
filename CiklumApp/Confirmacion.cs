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
    public partial class Confirmacion : Form
    {
        double altura;
        double peso;

        public Confirmacion(string altura, string peso)
        {
            InitializeComponent();
            this.altura = Convert.ToDouble(altura);
            this.peso = Convert.ToDouble(peso);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            consulta.Update($"UPDATE CLIENTE SET ALTURA = {this.altura}, PESO = {this.peso} WHERE ID_USUARIO = {Login.user.ID()}");
            this.Close();
        }
    }
}
