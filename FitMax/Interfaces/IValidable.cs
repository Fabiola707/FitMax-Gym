using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Interfaces
{
    public interface IValidable
    {
        // Comprueba si los datos del objeto son válidos.
        bool EsValido();

        // Devuelve un mensaje si existen datos incorrectos.
        string ObtenerErrores();
    }
}
