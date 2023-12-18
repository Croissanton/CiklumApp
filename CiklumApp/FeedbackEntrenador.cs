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
    public partial class FeedbackEntrenador : Form
    {
        public static int id = -1;
        public FeedbackEntrenador(int id_entrenador)
        {
            InitializeComponent();
            id = id_entrenador;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            var perfil = new PerfilEntrenador(id);
            this.Hide();
            perfil.Show();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            consulta.Insert("INSERT INTO RESENA_ENTRENADOR (VALORACION, OPINION, ID_ENTRENADOR) VALUES (" + lbValoracion.SelectedIndex + ", '" + tbOpinion.Text + "', " + id + ");");
            var perfil = new PerfilEntrenador(id);
            this.Hide();
            perfil.Show();
        }

        private void FeedbackEntrenador_Load(object sender, EventArgs e)
        {
            lbValoracion.ClearSelected();
        }
    }
}
