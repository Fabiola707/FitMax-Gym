using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Interfaces
{
    public interface IDesactivable
    {
        // Desactiva el registro.
        void Desactivar();

        // Comprueba si el registro está activo.
        bool EstaActivo();
    }
}
