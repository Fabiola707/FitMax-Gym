using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class InscripcionClase
    {
        // Datos de la inscripción.
        public int Id { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoClase { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public InscripcionClase()
        {
            CodigoCliente = string.Empty;
            CodigoClase = string.Empty;
            FechaInscripcion = DateTime.Today;
            Estado = "Activa";
        }
    }
}