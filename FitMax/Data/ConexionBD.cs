using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FitMax
{
    public class ConexionBD
    {
        private static string cadenaConexion =
            "Server=localhost;Port=3307;Database=FitMaxDB;Uid=root;Pwd=;paola05";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}


