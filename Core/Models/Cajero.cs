using System;
using System.Collections.Generic;
using System.Text;
//using static System.Windows.Form1.VisualStyles.VisualStyleElement.ToolTip;

namespace FitMax.Models
{
    public class Cajero : Empleado
    {
        // Identifica la caja que tiene asignada.
        public string NumeroCaja { get; set; }

        // Constructor de la clase.
        public Cajero()
        {
            Puesto = "Cajero";
            NumeroCaja = string.Empty;
        }

        // Mostrar información del cajero.
        public override string ObtenerInformacion()
        {
            return $"Cajero: {Nombre} | " +
                   $"Código: {CodigoEmpleado} | " +
                   $"Caja: {NumeroCaja}";
        }
    }
}
