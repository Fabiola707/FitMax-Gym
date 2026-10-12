using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Membresia
    {
        // Datos principales de la membresía.
        public int Id { get; set; }
        public string CodigoMembresia { get; set; }
        public string NombrePlan { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public Membresia()
        {
            CodigoMembresia = string.Empty;
            NombrePlan = string.Empty;
            Precio = 0;
            Estado = "Activa";
        }

        // Comprobar si la membresía está vigente.
        public bool EstaVigente()
        {
            return Estado == "Activa"
                && DateTime.Today >= FechaInicio.Date
                && DateTime.Today <= FechaFin.Date;
        }
    }
}