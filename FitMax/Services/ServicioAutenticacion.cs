using FitMax.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Services
{
    public class ServicioAutenticacion
    {
        // Comprueba las credenciales de un usuario.
        public bool IniciarSesion(
            IAutenticable usuario,
            string nombreUsuario,
            string contrasena)
        {
            if (usuario == null)
            {
                return false;
            }

            return usuario.Autenticar(nombreUsuario, contrasena);
        }
    }
}