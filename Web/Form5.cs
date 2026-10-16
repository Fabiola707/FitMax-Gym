using FitMax.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Web
{
    public partial class Form5 : Form
    {
        private static string connectionString = @"Server=localhost;Port=3307;Database=FitMaxDB;Uid=root;Pwd=;paola05";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tbx_nombre_empleado.Text.Trim();
            string usuario = tbx_usuario_empleado.Text.Trim();
            string password = tbx_empleado_contraseña.Text.Trim();
            string puesto = "";

            // Verificamos cuál RadioButton está seleccionado
            if (cbx_administrador.Checked)
            {
                puesto = "Administrador";
            }
            else if (cbx_cajero.Checked)
            {
                puesto = "Cajero";
            }
            else if (cbx_entrenador.Checked)
            {
                puesto = "Entrenador";
            }

           
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(puesto))
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona un puesto.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO usuarios (nombre, username, password, puesto) " +
                           "VALUES (@nombre, @usuario, @password, @puesto)";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@password", password);
                        comando.Parameters.AddWithValue("@puesto", puesto);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("¡Empleado registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar campos y actualizar la tabla visual inferior
                        LimpiarCampos();
                        CargarEmpleados();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("El nombre de usuario ya existe. Elige uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error de MySQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEmpleados()
        {
            string query = "SELECT nombre, username, puesto FROM usuarios";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);    
                    }
                }
            }
            catch (Exception)
            {
            
            }
        }

        private void LimpiarCampos()
        {
            tbx_nombre_empleado.Clear();
            tbx_usuario_empleado.Clear();
            tbx_empleado_contraseña.Clear();
           
            tbx_nombre_empleado.Focus();
        }

private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btn_db_empleados_Click(object sender, EventArgs e)
        {

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void tbx_nombre_empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_usuario_empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_empleado_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
