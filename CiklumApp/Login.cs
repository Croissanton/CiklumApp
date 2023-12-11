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
using System.Security.Cryptography;

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
            var consulta = new Consulta();
            string passHash = CalculateHash(pass);

            var list = consulta.Select("SELECT * FROM USUARIOS WHERE username = '" + user + "' AND password_hash = '" + passHash + "'");
            if (list.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bSignin_Click(object sender, EventArgs e)
        {
            if (checklogin(tbUsername.Text, tbPassword.Text))
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

        static string CalculateHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convierte el hash a una representación hexadecimal
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}

