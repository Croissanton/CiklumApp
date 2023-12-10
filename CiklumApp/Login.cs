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
            /*var consulta = new Consulta();
            var list = consulta.Select("SELECT * FROM users WHERE username = '" + user + "' AND password = '" + pass + "'");*/
            var list = new List<object[]>();
            return true;
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
    }
}

