using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Empleado : Usuario
    {
        // Datos específicos del empleado.
        public string CodigoEmpleado { get; set; }
        public decimal Salario { get; set; }
        public string Puesto { get; set; }

        // Constructor.
        public Empleado()
        {
            CodigoEmpleado = string.Empty;
            Salario = 0;
            Puesto = string.Empty;
        }

        // Mostrar información del empleado.
        public override string ObtenerInformacion()
        {
            return $"Empleado: {Nombre} | " +
                   $"Código: {CodigoEmpleado} | " +
                   $"Puesto: {Puesto} | " +
                   $"Salario: {Salario:C}";
        }
    }
}