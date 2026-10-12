using FitMax.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitMax.Services
{
    public class ServicioVentas
    {
        // Comprueba si hay existencias suficientes.
        public bool HayExistencias(Producto producto, int cantidad)
        {
            if (producto == null || cantidad <= 0)
            {
                return false;
            }

            return producto.Stock >= cantidad;
        }

        // Calcula el importe de los productos vendidos.
        public decimal CalcularSubtotal(Producto producto, int cantidad)
        {
            if (!HayExistencias(producto, cantidad))
            {
                return 0;
            }

            return producto.Precio * cantidad;
        }
    }
}
