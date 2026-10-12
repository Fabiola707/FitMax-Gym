using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Producto
    {
        // Datos del producto.
        public int Id { get; set; }
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Estado { get; set; }

        // Constructor.
        public Producto()
        {
            CodigoProducto = string.Empty;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            Stock = 0;
            Estado = "Activo";
        }
    }
}