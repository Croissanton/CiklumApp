using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CiklumApp
{
    public partial class Login : Form
    {
        private int user_id;
        private string username;
        private int rol_id;
        public static Usuario user;
        public enum Roles
        {
            Admin = 1,
            Entrenador = 2,
            Usuario = 3
        }
        public Login()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private bool checklogin(string username, string pass)
        {
            var consulta = new Consulta();
            string passHash = CalculateHash(pass);

            var list = consulta.Select("SELECT * FROM USUARIO WHERE username = '" + username + "' AND password_hash = '" + passHash + "'");
            if (list.Count > 0)
            {
                user_id = Convert.ToInt32(list[0][0]);
                this.username = username;
                rol_id = Convert.ToInt32(list[0][3]);
                user = new Usuario(user_id, this.username, rol_id);
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
                if (user.ID_rol() == (int)Roles.Usuario)
                {
                    this.Hide();
                    var homeCliente = new HomeCliente();
                    homeCliente.Closed += (s, args) => this.Close();
                    homeCliente.Show();
                } else
                {
                    this.Hide();
                    var home = new Home();
                    home.Closed += (s, args) => this.Close();
                    home.Show();
                }

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

