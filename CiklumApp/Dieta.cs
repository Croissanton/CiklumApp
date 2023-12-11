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
    public partial class Dieta : Form
    {
        public Dieta()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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

                var dieta = new Dieta();
                this.Hide();
                dieta.Show();
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
                    dgvDieta.SelectedRows[0].Cells[5].Value.ToString()
                    );
                modificarDieta.Show();

                modificarDieta.FormClosed += new FormClosedEventHandler(modificarDieta_FormClosed);
            }
        }

        private void Dieta_Load(object sender, EventArgs e)
        {
            var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM DIETA");

            foreach (var item in list)
            {
                int id = (int)item[0];
                //string nombre = (string)item[1];
                //int id_usuario = (int)item[2];
                string desayuno = (string)item[3];
                string mediamanana = (string)item[4];
                string almuerzo = (string)item[5];
                string merienda = (string)item[6];
                string cena = (string)item[7];
                string calorias = (string)item[8];

                dgvDieta.Rows.Add(id, desayuno, mediamanana, almuerzo, merienda, cena, calorias);   
            }
        }

        private void modificarDieta_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dieta = new Dieta();
            this.Close();
            dieta.Show();
        }
    }
}
