using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Interfaces
{
    public interface IAutenticable
    {
        // Comprueba las credenciales de un usuario.
        bool Autenticar(string usuario, string contrasena);
    }
}