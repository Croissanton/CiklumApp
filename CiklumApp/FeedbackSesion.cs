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
    public partial class FeedbackSesion : Form
    {
        public static int id = -1;
        public FeedbackSesion(int idSesion)
        {
            InitializeComponent();
            id = idSesion;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            consulta.Insert("INSERT INTO RESENA_SESION (VALORACION, OPINION, ENLACE, ID_SESION) VALUES (" + lbValoracion.SelectedIndex + ", '" + tbOpinion.Text + "', '" + tbVideo.Text + "', " + id + ");");
            this.Close();
        }

        private void FeedbackSesion_Load(object sender, EventArgs e)
        {
            tbOpinion.Clear();
        }
    }
}
