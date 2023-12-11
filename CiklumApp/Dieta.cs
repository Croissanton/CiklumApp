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

        }

        private void bBorrar_Click(object sender, EventArgs e)
        {

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
                modificarEjercicio.Show();

                modificarEjercicio.FormClosed += new FormClosedEventHandler(modificarEjercicio_FormClosed);
            }
        }
    }
}
