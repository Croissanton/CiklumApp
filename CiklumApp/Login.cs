using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool checklogin(string user, string pass)
        {
            /*
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ciklumdb.db");
            string connectionString = $"Data Source={databasePath};Version=3;";
            */
/*

            string ds = Path.Combine(Directory.GetCurrentDirectory(), "..", "..","..");

            using (SQLiteConnection con = new SQLiteConnection("Data Source="+ds+"\\ciklumdb.db;Version=3;"))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM USUARIO WHERE USERNAME = @user AND PASSWORD = @pass", con))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                con.Close();
            }*/
            return true;
        }

        private void bSignin_Click(object sender, EventArgs e)
        {
            if (checklogin(tbUsername.Text,tbPassword.Text))
            {
                this.Hide();
                var home = new Home();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            else
            {
                MessageBox.Show("Wrong login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
