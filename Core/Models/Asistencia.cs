using System;
using System.Collections.Generic;
using System.Text;

namespace FitMax.Models
{
    public class Asistencia
    {
        // Datos de la asistencia.
        public int Id { get; set; }
        public string CodigoCliente { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime? FechaHoraSalida { get; set; }

        // Constructor.
        public Asistencia()
        {
            CodigoCliente = string.Empty;
            FechaHoraEntrada = DateTime.Now;
            FechaHoraSalida = null;
        }

        // Comprobar si el cliente continúa dentro del gimnasio.
        public bool EstaDentro()
        {
            return FechaHoraSalida == null;
        }
    }
}
