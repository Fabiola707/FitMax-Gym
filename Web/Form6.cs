
using Core.Models;
using Core.Repositories;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Web
{
    /// <summary>
    /// hacer en la tienda, nuevo form
    /// 19/10/26 LUNES-----------------------------------------------------------------------------------------------------------------------------------------------------------
    /// </summary>
    public partial class Form6 : Form
    {
        private string archivo = Path.Combine(
           Environment.GetFolderPath(
               Environment.SpecialFolder.MyDocuments),
           "RegistroTienda.txt");
        public Form6()
        {
            InitializeComponent();

            btnGuardar.Click += btnGuardar_Click;//GUARDAR
            btnAbrir.Click += btnAbrir_Click;//ABRIR

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = DateTime.Now.ToString("HH:mm:ss")
                + " | Registro de prueba FitMax GYM";

            File.AppendAllText(
                archivo,
                mensaje + Environment.NewLine);

            MessageBox.Show(
                "El registro se guardó correctamente.",
                "Registro guardado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // Abrir el archivo en el Bloc de notas.
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (File.Exists(archivo))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = "\"" + archivo + "\"",
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show(
                    "Todavía no hay registros. Primero guarda uno.",
                    "Archivo no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Creamos y llenamos tu objeto Log utilizando las clases que ya tienes en Core.clases
                Core.Models.Log miLog = new Core.Models.Log();
                miLog.fecha = DateTime.Now;
                miLog.tipo = 1; // Por ejemplo, 1 para errores
                miLog.empleado = null; // O puedes pasar el empleado que esté logueado en el sistema

                // Simulamos una excepción o error controlado para guardarlo
                miLog.mensaje = new Exception("Falló la conexión con la base de datos al intentar consultar el inventario");

                // 2. Instanciamos tu repositorio y llamamos al método de registro
                RepositorioLogs repositorio = new RepositorioLogs();
                repositorio.RegistrarLog(miLog);

                MessageBox.Show("Log guardado exitosamente a través del Repositorio.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btn_db_empleados_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
    }
}///----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
