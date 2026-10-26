using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FitMax
{
    public class ConexionBD
    {
        public static string cadenaConexion =
            "Server=localhost;Port=3306;Database=fitmaxDB;Uid=root;Pwd=19503236;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}


