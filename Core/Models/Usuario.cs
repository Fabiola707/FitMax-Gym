using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Usuario
    {
        // Datos principales del usuario.
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UsuarioAcceso { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }

        // Constructor de la clase.
        public Usuario()
        {
            Nombre = string.Empty;
            UsuarioAcceso = string.Empty;
            Contrasena = string.Empty;
            Estado = "Activo";
        }

        // Método para mostrar el nombre del usuario.
        public virtual string ObtenerInformacion()
        {
            return $"Usuario: {Nombre} - Estado: {Estado}";
        }
    }
}