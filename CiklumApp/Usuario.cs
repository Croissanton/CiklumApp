using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklumApp
{
    internal class Usuario
    {
        private string username;
        public int id_rol;

        public Usuario(string username)
        {
            this.username = username;
            string consultaText = "SELECT * FROM USUARIOS WHERE username='" + username + "';";
            Consulta consulta = new Consulta();
            var res = consulta.Select(consultaText);
            
        }
    }
}
 