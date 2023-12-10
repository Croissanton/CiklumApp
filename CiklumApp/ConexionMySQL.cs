/*using MySql.Data.MySql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    internal class ConexionMySQL : Conexion
    {

        private MySqlConnection connection;

        private string cadenaConexion;

        public ConexionMySQL()

        {

            cadenaConexion = "Database=" + database +

                "; DataSource=" + server +

                "; User Id=" + user +
            "; Password=" + password;

            connection = new MySqlConnection(cadenaConexion);

        }

        public MySqlConnection GetConnection()

        // Conecta con la base de datos

        {

            try

            {

                if (connection.State != System.Data.ConnectionState.Open)

                {

                    connection.Open();

                }

            }

            catch (Exception e)

            {

                MessageBox.Show(e.ToString());

            }

            return connection;

        }

    }
}
*/