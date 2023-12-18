using MySqlX.XDevAPI;
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
    public partial class GenerarCita : Form
    {
        private int id_cliente;
        //selecciona el entrenador q tiene el cliente con correo especifico
        /*
         * SELECT DISTINCT E.id_usuario
            FROM CLIENTE C
            JOIN CLIENTE_ENTRENADOR CE ON C.id_usuario = CE.id_cliente
            JOIN ENTRENADOR E ON CE.id_entrenador = E.id_usuario
            WHERE C.id_usuario = 7 AND E.correo = 'a@gmail.com';
         * 
         * */
        public GenerarCita(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            if (tbTipo.Text == "" || dateTimePicker.Value == null)
            {
                MessageBox.Show("Rellene todos los campos.");
                return;
            }

            string duracion = tbDuracion.Text;
            string tipo = tbTipo.Text;
            string entrenador = tbEntrenador.Text;
            DateTime dateTime = dateTimePicker.Value;

            var consultaEntrenador = new Consulta();
            var lista = consultaEntrenador.Select("SELECT DISTINCT E.id_usuario FROM CLIENTE C " +
                "JOIN CLIENTE_ENTRENADOR CE ON C.id_usuario = CE.id_cliente " +
                "JOIN ENTRENADOR E ON CE.id_entrenador = E.id_usuario " +
                "WHERE C.id_usuario = "+this.id_cliente+" AND E.correo = '" + entrenador +"'; ");

            if(lista.Count == 0)
            {
                MessageBox.Show("No existe el entrenador.");
                return;
            }   

            var consulta = new Consulta();
            consulta.Update("INSERT INTO `grupo10DB`.`CITA`" +
                "("+
                "`fecha`," +
                "`duracion`," +
                "`id_cliente`," +
                "`id_entrenador`," +
                "`tipo`," +
                "`estado`)" +
                "VALUES" +
                "(" +
                "'" +dateTime.Year + dateTime.Month + dateTime.Day+ "'," +
                "'" + duracion + "'," +
                "'" + id_cliente + "'," +
                "'" + lista[0].GetValue(0) + "'," +
                "'" + tipo + "'," +
                "" + 1 + 
                ");");;

            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
