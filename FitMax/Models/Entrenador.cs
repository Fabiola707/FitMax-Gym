using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Entrenador : Empleado
    {
        // Datos específicos del entrenador.
        public string Especialidad { get; set; }
        public string Certificacion { get; set; }

        // Constructor.
        public Entrenador()
        {
            Puesto = "Entrenador";
            Especialidad = string.Empty;
            Certificacion = string.Empty;
        }

        // Mostrar información del entrenador.
        public override string ObtenerInformacion()
        {
            return $"Entrenador: {Nombre} | " +
                   $"Código: {CodigoEmpleado} | " +
                   $"Especialidad: {Especialidad} | " +
                   $"Certificación: {Certificacion}";
        }
    }
}