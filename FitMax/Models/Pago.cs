using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Pago
    {
        // Datos del pago.
        public int Id { get; set; }
        public string CodigoPago { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoMembresia { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public Pago()
        {
            CodigoPago = string.Empty;
            CodigoCliente = string.Empty;
            CodigoMembresia = string.Empty;
            MetodoPago = string.Empty;
            Estado = "Pendiente";
        }

        // Mostrar un resumen del pago.
        public string ObtenerResumen()
        {
            return $"Pago: {CodigoPago} | " +
                    $"Cliente: {CodigoCliente} | " +
                    $"Monto: {Monto:C} | " +
                    $"Estado: {Estado}";
        }
    }
}