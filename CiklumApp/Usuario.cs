using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklumApp
{
    public partial class Usuario
    {
        private int id;
        private string username;
        private int id_rol;

        public Usuario(int id, string username, int id_rol)
        {
            this.id = id;
            this.username = username ?? throw new ArgumentNullException(nameof(username));
            this.id_rol = id_rol;
        }

        public int ID()
        {
            return id;
        } 
        public string Username()
        {
            return username;
        }
        public int ID_rol()
        {
            return id_rol;
        }
    }
}
