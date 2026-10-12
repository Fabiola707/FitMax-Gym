using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Ejercicio
    {
        // Datos principales del ejercicio.
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string GrupoMuscular { get; set; }
        public int Series { get; set; }
        public int Repeticiones { get; set; }
        public decimal Peso { get; set; }

        // Constructor.
        public Ejercicio()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            GrupoMuscular = string.Empty;
            Series = 0;
            Repeticiones = 0;
            Peso = 0;
        }
    }
}