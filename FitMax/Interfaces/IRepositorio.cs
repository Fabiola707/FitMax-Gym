using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Interfaces
{
    public interface IRepositorio<T>
    {
        // Registrar un nuevo elemento.
        void Registrar(T entidad);

        // Actualizar un elemento existente.
        void Actualizar(T entidad);

        // Obtener todos los elementos.
        List<T> ObtenerTodos();

        // Buscar un elemento por su identificador.
        T BuscarPorId(int id);

        // Eliminar un elemento.
        void Eliminar(int id);
    }
}