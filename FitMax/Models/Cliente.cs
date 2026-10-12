using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Cliente : Usuario
    {
        // Datos personales del cliente.
        public string CodigoCliente { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        // Constructor.
        public Cliente()
        {
            CodigoCliente = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
        }

        // Mostrar información del cliente.
        public override string ObtenerInformacion()
        {
            return $"Cliente: {Nombre} | " +
                   $"Código: {CodigoCliente} | " +
                   $"Teléfono: {Telefono} | " +
                   $"Estado: {Estado}";
        }
    }
}