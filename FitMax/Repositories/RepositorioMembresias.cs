using FitMax.Interfaces;
using FitMax.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Repositories
{
    public class RepositorioMembresias : IRepositorio<Membresia>
    {
        private readonly List<Membresia> membresias = new List<Membresia>();

        public void Registrar(Membresia entidad)
        {
            membresias.Add(entidad);
        }

        public void Actualizar(Membresia entidad)
        {
            var membresiaExistente = membresias.FirstOrDefault(
                m => m.Id == entidad.Id
            );

            if (membresiaExistente != null)
            {
                membresiaExistente.CodigoMembresia = entidad.CodigoMembresia;
                membresiaExistente.NombrePlan = entidad.NombrePlan;
                membresiaExistente.Precio = entidad.Precio;
                membresiaExistente.FechaInicio = entidad.FechaInicio;
                membresiaExistente.FechaFin = entidad.FechaFin;
                membresiaExistente.Estado = entidad.Estado;
            }
        }

        public List<Membresia> ObtenerTodos()
        {
            return membresias;
        }

        public Membresia BuscarPorId(int id)
        {
            return membresias.FirstOrDefault(m => m.Id == id);
        }

        public void Eliminar(int id)
        {
            var membresia = BuscarPorId(id);

            if (membresia != null)
            {
                membresias.Remove(membresia);
            }
        }
    }
}