using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Core;
using FitMax;
using System.Windows.Forms;

namespace Web//pantalla para renovar membresias
{
    public partial class Form8 : Form
    {
        private int? idClienteSeleccionado = null;
        private int? idMembresiaSeleccionada = null;
        private int duracionDias = 0;
        private string nombreMembresia = "";
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;

            ActualizarFechaFin();
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

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_membresia_Click(object sender, EventArgs e)
        {//validar seleccion 
            if (idClienteSeleccionado == null)
            {
                MessageBox.Show("primero busque y seleccione un cliente");
                return;
            }//validar seleccion
            if (idClienteSeleccionado == null || duracionDias <= 0)
            {
                MessageBox.Show("seleccione tipo de membresia");
                return;
            }
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = fechaInicio.AddDays(duracionDias);

            DialogResult respuesta = MessageBox.Show(
                "¿Desea guardar la renovación?\n\n" +
                "Cliente ID: " + idClienteSeleccionado + "\n" +
                "Membresía: " + nombreMembresia + "\n" +
                "Inicio: " + fechaInicio.ToString("dd/MM/yyyy") +
                "\nFinalización: " + fechaFin.ToString("dd/MM/yyyy"),
                "Confirmar renovación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;
            try
            {
                using (MySqlConnection conexion =
                 ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        INSERT INTO ClienteMembresia
                            (IdCliente, IdMembresia,
                             FechaInicio, FechaFin)
                        VALUES
                            (@idCliente, @idMembresia,
                             @fechaInicio, @fechaFin)";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idCliente", idClienteSeleccionado.Value);

                        comando.Parameters.AddWithValue(
                            "@idMembresia",
                            idMembresiaSeleccionada.Value);

                        comando.Parameters.AddWithValue(
                            "@fechaInicio", fechaInicio);

                        comando.Parameters.AddWithValue(
                            "@fechaFin", fechaFin);

                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(
                  "¡La membresía se renovó correctamente!",
                  "FitMax Gym",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                btn_buscar_miembro_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la renovación:\n" + ex.Message);
            }
        }
        private void btn_leyenda_Click(object sender, EventArgs e)
        {
            SeleccionarMembresia("Leyenda");
        }

        private void btn_buscar_miembro_Click(object sender, EventArgs e)
        {
            string busqueda = txb_ingresar_nombre_miembro.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Ingrese el ID o nombre del cliente.");
                return;
            }

            try
            {
                using (MySqlConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            c.IdCliente,
                            CONCAT(c.Nombres, ' ', c.Apellidos)
                                AS NombreCompleto,
                            c.Telefono,
                            c.Correo,
                            COALESCE(m.Nombre, 'Sin membresía')
                                AS MembresiaActual,
                            cm.FechaFin
                        FROM Clientes c
                        LEFT JOIN ClienteMembresia cm
                            ON cm.IdClienteMembresia = (
                                SELECT MAX(cm2.IdClienteMembresia)
                                FROM ClienteMembresia cm2
                                WHERE cm2.IdCliente = c.IdCliente
                            )
                        LEFT JOIN Membresias m
                            ON m.IdMembresia = cm.IdMembresia
                        WHERE
                            c.IdCliente = @id
                            OR CONCAT(c.Nombres, ' ', c.Apellidos)
                                LIKE @nombre
                        ORDER BY c.IdCliente";

                    using (MySqlCommand comando =
                        new MySqlCommand(consulta, conexion))
                    {
                        int idBuscado;

                        if (!int.TryParse(busqueda, out idBuscado))
                        {
                            idBuscado = -1;
                        }

                        comando.Parameters.AddWithValue("@id", idBuscado);

                        comando.Parameters.AddWithValue("@nombre", "%" + busqueda + "%");

                        DataTable tabla = new DataTable();

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tabla);
                        }

                        dataGridView1.DataSource = tabla;

                        if (tabla.Rows.Count > 0)
                        {
                            idClienteSeleccionado = Convert.ToInt32(tabla.Rows[0]["IdCliente"]);

                            dataGridView1.ClearSelection();

                            dataGridView1.Rows[0].Selected = true;

                            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

                            MessageBox.Show("Cliente encontrado correctamente.");
                        }
                        else
                        {
                            idClienteSeleccionado = null;

                            MessageBox.Show("No se encontró ningún cliente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente:\n" + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Elite_Click(object sender, EventArgs e)
        {
            SeleccionarMembresia("Elite");
        }

        private void btn_Titan_Click(object sender, EventArgs e)
        {
            SeleccionarMembresia("Titán");
        }
        private void SeleccionarMembresia(string nombre)//declarar accion para los botones
        {
            try

            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())

                {

                    conexion.Open();
                    string consulta = @"

                        SELECT IdMembresia, Nombre, DuracionDias
                        FROM Membresias
                        WHERE Nombre = @nombre
                        LIMIT 1";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))

                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        using (MySqlDataReader lector =comando.ExecuteReader())

                        {

                            if (lector.Read())

                            {
                                idMembresiaSeleccionada =Convert.ToInt32(lector["IdMembresia"]);
                                nombreMembresia =lector["Nombre"].ToString();
                                duracionDias = Convert.ToInt32(lector["DuracionDias"]);

                                ActualizarFechaFin();
                                MessageBox.Show("Membresía seleccionada: " + nombreMembresia);
                            }
                            else
                            {
                                idMembresiaSeleccionada = null;
                                MessageBox.Show("No existe la membresía " + nombre + " en la base de datos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)

            {

                MessageBox.Show(

                    "Error al seleccionar la membresía:\n" +

                    ex.Message);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)

                return;



            object valor = dataGridView1.Rows[e.RowIndex].Cells["IdCliente"].Value;



            if (valor != null && valor != DBNull.Value)

            {

                idClienteSeleccionado = Convert.ToInt32(valor);

            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFechaFin();

        }
        private void ActualizarFechaFin()
        {
            if (duracionDias > 0)
            {
                DateTime fechaFin = dateTimePicker1.Value.Date.AddDays(duracionDias);
                lb_fecha_fin.Text = fechaFin.ToString("dd/MM/yyyy");
            
            }
            else
            {
                lb_fecha_fin.Text = "Seleccione membresia";
            }
        }

    }
}
