﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "";
            string bd = "sistema_usuarios";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password="+password + "; database="+bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }



        }


    }
}
