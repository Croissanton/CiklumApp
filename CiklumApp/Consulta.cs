﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiklumApp
{
    internal class Consulta

    {

        private ConexionMySQL con;



        public Consulta()

        {

            con = new ConexionMySQL();

        }



        public List<object[]> Select(string consulta)

        {

            // Vuestro codigo para hacer consulta
            var command = con.GetConnection().CreateCommand();
            command.CommandText = consulta;
            List<object[]> list = new List<object[]>();


            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                list.Add(values);
            }

            con.GetConnection().Close();
            return list;

        }



        public void Update(string consulta)

        {
            // Vuestro codigo para hacer consulta
            var command = con.GetConnection().CreateCommand();
            command.CommandText = consulta;
            command.ExecuteNonQuery();
            con.GetConnection().Close();
        }

        public void Delete(string consulta)

        {
            // Vuestro codigo para hacer consulta
            var command = con.GetConnection().CreateCommand();
            command.CommandText = consulta;
            command.ExecuteNonQuery();
            con.GetConnection().Close();
        }

        public void Insert(string consulta)

        {
            // Vuestro codigo para hacer consulta
            var command = con.GetConnection().CreateCommand();
            command.CommandText = consulta;
            command.ExecuteNonQuery();
            con.GetConnection().Close();
        }

    }
}
