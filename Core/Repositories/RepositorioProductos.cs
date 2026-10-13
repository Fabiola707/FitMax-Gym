using FitMax.Interfaces;
using FitMax.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Repositories
{
    public class RepositorioProductos : IRepositorio<Producto>
    {
        private readonly List<Producto> productos = new List<Producto>();

        public void Registrar(Producto entidad)
        {
            productos.Add(entidad);
        }

        public void Actualizar(Producto entidad)
        {
            var productoExistente = productos.FirstOrDefault(
                p => p.Id == entidad.Id
            );

            if (productoExistente != null)
            {
                productoExistente.Nombre = entidad.Nombre;
                productoExistente.Precio = entidad.Precio;
                productoExistente.Stock = entidad.Stock;
            }
        }

        public List<Producto> ObtenerTodos()
        {
            return productos;
        }

        public Producto BuscarPorId(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

        public void Eliminar(int id)
        {
            var producto = BuscarPorId(id);

            if (producto != null)
            {
                productos.Remove(producto);
            }
        }
    }
}