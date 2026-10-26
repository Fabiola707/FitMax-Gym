using Core;
using FitMax;
using FitMax.Models;
using MySql.Data.MySqlClient;
using System;

namespace FitMax.Repositories
{
    public class RepositorioUsuarios
    {
        public Usuario BuscarPorNombreUsuario(string nombreUsuario)
        {
            using (MySqlConnection conexion =
                   ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string consulta = @"
                    SELECT IdUsuario, NombreUsuario,
                           ContrasenaHash, Rol, Activo
                    FROM Usuarios
                    WHERE NombreUsuario = @nombreUsuario
                    LIMIT 1;";

                using (MySqlCommand comando =
                       new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@nombreUsuario", nombreUsuario);

                    using (MySqlDataReader lector =
                           comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Usuario
                            {
                                Id = lector.GetInt32("IdUsuario"),
                                UsuarioAcceso =
                                    lector.GetString("NombreUsuario"),
                                Contrasena =
                                    lector.GetString("ContrasenaHash"),
                                Estado =
                                    lector.GetBoolean("Activo")
                                        ? "Activo"
                                        : "Inactivo"
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}