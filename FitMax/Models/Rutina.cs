using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Rutina
    {
        // Datos principales de la rutina.
        public int Id { get; set; }
        public string CodigoRutina { get; set; }
        public string Nombre { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoEntrenador { get; set; }
        public string Objetivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public Rutina()
        {
            CodigoRutina = string.Empty;
            Nombre = string.Empty;
            CodigoCliente = string.Empty;
            CodigoEntrenador = string.Empty;
            Objetivo = string.Empty;
            FechaCreacion = DateTime.Today;
            Estado = "Activa";
        }
    }
}
