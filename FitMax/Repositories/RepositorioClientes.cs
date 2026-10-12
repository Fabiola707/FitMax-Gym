using FitMax.Interfaces;
using FitMax.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Repositories
{
    public class RepositorioClientes : IRepositorio<Cliente>
    {
        private readonly List<Cliente> clientes = new List<Cliente>();

        public void Registrar(Cliente entidad)
        {
            clientes.Add(entidad);
        }

        public void Actualizar(Cliente entidad)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == entidad.Id);

            if (clienteExistente != null)
            {
                clienteExistente.Nombre = entidad.Nombre;
                clienteExistente.Telefono = entidad.Telefono;
                clienteExistente.Correo = entidad.Correo;
                clienteExistente.CodigoCliente = entidad.CodigoCliente;
            }
        }

        public List<Cliente> ObtenerTodos()
        {
            return clientes;
        }

        public Cliente BuscarPorId(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        public void Eliminar(int id)
        {
            var cliente = BuscarPorId(id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }
    }
}
