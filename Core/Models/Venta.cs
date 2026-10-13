using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Venta
    {
        // Datos principales de la venta.
        public int Id { get; set; }
        public string CodigoVenta { get; set; }
        public string CodigoEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public Venta()
        {
            CodigoVenta = string.Empty;
            CodigoEmpleado = string.Empty;
            FechaVenta = DateTime.Now;
            Total = 0;
            MetodoPago = string.Empty;
            Estado = "Registrada";
        }
    }
}