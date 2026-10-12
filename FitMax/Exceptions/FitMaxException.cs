using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Exceptions
{
    public class FitMaxException : Exception
    {
        // Constructor que recibe el mensaje del error.
        public FitMaxException(string mensaje)
            : base(mensaje)
        {
        }
    }
}