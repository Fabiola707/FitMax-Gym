using FitMax.Interfaces;
using FitMax.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Repositories
{
    public class RepositorioEmpleados : IRepositorio<Empleado>
    {
        private readonly List<Empleado> empleados = new List<Empleado>();

        public void Registrar(Empleado entidad)
        {
            empleados.Add(entidad);
        }

        public void Actualizar(Empleado entidad)
        {
            var empleadoExistente = empleados.FirstOrDefault(
                e => e.Id == entidad.Id
            );

            if (empleadoExistente != null)
            {
                empleadoExistente.Nombre = entidad.Nombre;
                empleadoExistente.CodigoEmpleado = entidad.CodigoEmpleado;
                empleadoExistente.Salario = entidad.Salario;
                empleadoExistente.Puesto = entidad.Puesto;
                empleadoExistente.Estado = entidad.Estado;
            }
        }

        public List<Empleado> ObtenerTodos()
        {
            return empleados;
        }

        public Empleado BuscarPorId(int id)
        {
            return empleados.FirstOrDefault(e => e.Id == id);
        }

        public void Eliminar(int id)
        {
            var empleado = BuscarPorId(id);

            if (empleado != null)
            {
                empleados.Remove(empleado);
            }
        }
    }
}