using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Administrador : Empleado
    {
        // Indica el nivel de acceso del administrador.
        public string NivelAcceso { get; set; }

        // Constructor de la clase.
        public Administrador()
        {
            Puesto = "Administrador";
            NivelAcceso = "Completo";
        }

        // Mostrar información del administrador.
        public override string ObtenerInformacion()
        {
            return $"Administrador: {Nombre} | " +
                   $"Código: {CodigoEmpleado} | " +
                   $"Acceso: {NivelAcceso}";
        }
    }
}