using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class ClaseGym
    {
        // Datos principales de la clase grupal.
        public int Id { get; set; }
        public string CodigoClase { get; set; }
        public string Nombre { get; set; }
        public string CodigoEntrenador { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public int CapacidadMaxima { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public ClaseGym()
        {
            CodigoClase = string.Empty;
            Nombre = string.Empty;
            CodigoEntrenador = string.Empty;
            CapacidadMaxima = 0;
            Estado = "Activa";
        }
    }
}