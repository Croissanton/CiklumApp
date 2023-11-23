using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;



namespace CiklumApp
{
    public partial class Home : Form
    {
        /*private void loadCitas()
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
            string connectionString = "Data Source=" + path + "\\ciklumdb.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM cita", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            citasGridView.Rows.Add(reader["id"], reader["entrenador"], reader["id_cliente"], reader["fecha"], reader["hora"]);
                        }
                    }
                }
                conn.Close();
            }
        }*/


        //TODO: ninguna de las implementaciones de loadCitas() funciona <3
        private void loadCitas()
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..");
            string connectionString = "Data Source=" + path + "\\ciklumdb.db;Version=3;";

            citasGridView.AutoGenerateColumns = true;

            
            string query = "SELECT * FROM cita";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            con.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    citasGridView.DataSource = dataTable;
                }
            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void bEjercicios_Click(object sender, EventArgs e)
        {
            var ejercicios = new Ejercicios();
            this.Hide();
            ejercicios.Show();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            var clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void bSesiones_Click(object sender, EventArgs e)
        {
            var sesiones = new Sesion();
            this.Hide();
            sesiones.Show();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
