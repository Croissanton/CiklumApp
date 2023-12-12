using System;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Dieta : Form
    {
        int id_dieta = -1;
        public Dieta(int id_dieta)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.id_dieta = id_dieta;
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            ModificarDieta modificarDieta = new ModificarDieta();
            modificarDieta.Show();
            modificarDieta.FormClosed += new FormClosedEventHandler(modificarDieta_FormClosed);
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDieta.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDieta.SelectedRows[0].Cells[0].Value.ToString());
                var consulta = new Consulta();
                consulta.Delete("DELETE FROM DIETA WHERE ID = '" + id + "'");

                var home = new Home();
                this.Hide();
                home.Show();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDieta.SelectedRows.Count > 0)
            {
                ModificarDieta modificarDieta = new ModificarDieta(
                    dgvDieta.SelectedRows[0].Cells[0].Value.ToString(),
                    dgvDieta.SelectedRows[0].Cells[1].Value.ToString(),
                    dgvDieta.SelectedRows[0].Cells[2].Value.ToString(),
                    dgvDieta.SelectedRows[0].Cells[3].Value.ToString(),
                    dgvDieta.SelectedRows[0].Cells[4].Value.ToString(),
                    dgvDieta.SelectedRows[0].Cells[5].Value.ToString(),
                    dgvDieta.SelectedRows[0].Cells[6].Value.ToString()
                    );
                modificarDieta.Show();

                modificarDieta.FormClosed += new FormClosedEventHandler(modificarDieta_FormClosed);
            }
        }

        private void Dieta_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM DIETA WHERE ID = " + id_dieta);

            foreach (var item in list)
            {
                int id = Convert.ToInt32(item[0]);
                string nombre = (string)item[1];
                string desayuno = (string)item[2];
                string mediamanana = (string)item[3];
                string almuerzo = (string)item[4];
                string merienda = (string)item[5];
                string cena = (string)item[6];
                int calorias = Convert.ToInt32(item[7]);

                dgvDieta.Rows.Add(nombre, desayuno, mediamanana, almuerzo, merienda, cena, calorias);
            }
        }

        private void modificarDieta_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dieta = new Dieta(id_dieta);
            this.Close();
            dieta.Show();
        }
    }
}