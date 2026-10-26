using Core;
using FitMax;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Web
{
    public partial class Form3 : Form
    {
        private int idMembresiaSeleccionada = 0;
        //private static string connectionString = @"Server=localhost;Port=3306;Database=fitmaxDB;Uid=root;Pwd=19503236;";
        public Form3()
        {
            InitializeComponent();
            btn_Elite.Click += btn_Elite_Click;
            btn_Titan.Click += btn_Titan_Click;
            btn_leyenda.Click += btn_leyenda_Click;
            btn_registrar_cliente.Click += btn_registrar_cliente_Click;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //   no necesario modificar
        }

        private void btn_Elite_Click(object sender, EventArgs e)//boton elite
        {
            SeleccionarMembresia(1, "Elite");
        }

        private void btn_Titan_Click(object sender, EventArgs e)//boton titan
        {
            SeleccionarMembresia(2, "Titán");
        }

        private void btn_registrar_cliente_Click(object sender, EventArgs e)//registrar cliente
        {
            string nombres = textBox3.Text.Trim();
            string apellidos = textBox6.Text.Trim();
            string telefono = textBox1.Text.Trim();
            string correo = textBox2.Text.Trim();

            if (nombres == "" || apellidos == "" ||
                telefono == "" || correo == "")
            {
                MessageBox.Show("Completa los datos personales.");
                return;
            }

            if (idMembresiaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una membresía: Elite, Titán o Leyenda.");
                return;
            }
            decimal peso;
            decimal estatura;

            if (!decimal.TryParse(
                    textBox7.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out peso) || peso <= 0)
            {
                MessageBox.Show("Escribe un peso válido. Ejemplo: 65.5");
                return;
            }
            if (!decimal.TryParse(
                    textBox8.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out estatura) || estatura <= 0)
            {
                MessageBox.Show("Escribe una estatura válida. Ejemplo: 1.70");
                return;
            }
            DateTime fechaInicio = dtp_inicio_membresia.Value;
            DateTime fechaFin = dtp_fin_membresia.Value;

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.");
                return;
            }

            if (fechaFin.Date != fechaInicio.Date.AddDays(30))
            {
                MessageBox.Show(
                    "Las membresías actuales duran 30 días. Revisa la fecha de fin.");
                return;
            }
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    using (MySqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string consultaCliente = @"
                                INSERT INTO Clientes
                                (Nombres, Apellidos, Telefono, Correo,
                                 Peso, Estatura, FechaRegistro)
                                VALUES
                                (@nombres, @apellidos, @telefono, @correo,
                                 @peso, @estatura, CURDATE())";

                            int idCliente;

                            using (MySqlCommand comando = new MySqlCommand(
                                consultaCliente, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@nombres", nombres);
                                comando.Parameters.AddWithValue("@apellidos", apellidos);
                                comando.Parameters.AddWithValue("@telefono", telefono);
                                comando.Parameters.AddWithValue("@correo", correo);
                                comando.Parameters.AddWithValue("@peso", peso);
                                comando.Parameters.AddWithValue("@estatura", estatura);

                                comando.ExecuteNonQuery();
                                idCliente = (int)comando.LastInsertedId;
                            }

                            string consultaMembresia = @"
                                INSERT INTO ClienteMembresia
                                (IdCliente, IdMembresia, FechaInicio, FechaFin)
                                VALUES
                                (@idCliente, @idMembresia, @fechaInicio, @fechaFin)";

                            using (MySqlCommand comando = new MySqlCommand(
                                consultaMembresia, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idCliente", idCliente);
                                comando.Parameters.AddWithValue(
                                    "@idMembresia", idMembresiaSeleccionada);
                                comando.Parameters.AddWithValue(
                                    "@fechaInicio", fechaInicio.Date);
                                comando.Parameters.AddWithValue(
                                    "@fechaFin", fechaFin.Date);

                                comando.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                        }
                        catch
                        {
                            transaccion.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "¡Socio registrado correctamente!",
                    "FitMax Gym",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el socio: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario() //declarar accion de limpieza automatica del formulario
        {
            textBox3.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox7.Clear();
            textBox8.Clear();
            dtp_inicio_membresia.Value = DateTime.Now;
            dtp_fin_membresia.Value = DateTime.Now;
            idMembresiaSeleccionada = 0;
        }


        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btn_db_empleados_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void btn_leyenda_Click(object sender, EventArgs e)//boton leyenda
        {
            SeleccionarMembresia(3, "Leyenda");
        }
        private void SeleccionarMembresia(int id, string nombre)//declarar la accion usada antes
        {
            idMembresiaSeleccionada = id;
            MessageBox.Show("Membresia Seleccionada: " + nombre, "FitMax Gym", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
