using Core; // 2. Importante para poder usar tu clase Log y Empleado
using Core.Models;
using System;
using System.Collections.Generic;
using System.IO; // 1. Importante para usar File.AppendAllText
using System.Text;

namespace Core.Repositories
{
    public class RepositorioLogs
    {
        // Método para registrar y guardar el log en un archivo de texto
        public void RegistrarLog(Log nuevoLog)
        {
            try
            {
                string nombreArchivo = $"{DateTime.Now:yyyyMMdd}_log.txt";

                string horaStr = nuevoLog.fecha.ToString("HH:mm:ss");
                string tipoStr = nuevoLog.tipo.ToString();
                string mensajeStr = nuevoLog.mensaje != null ? nuevoLog.mensaje.Message : "Sin detalles";
                string empleadoInfo = (nuevoLog.empleado != null) ? "Empleado registrado" : "Sistema / Desconocido";

                string linea = $"{horaStr} | Tipo: {tipoStr} | {empleadoInfo} | {mensajeStr} |" + Environment.NewLine;

                File.AppendAllText(nombreArchivo, linea);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el log en archivo: " + ex.Message);
            }
        }
    }
}