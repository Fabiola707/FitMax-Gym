using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FitMax;

namespace Web
{
    public partial class Form4 : Form
    {
        //private static string connectionString = @"Server=localhost;Port=3306;Database=fitmaxDB;Uid=root;Pwd;19503236;";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarMembresiasPorVencer();
            CargarPromedioAsistencia();
        }
        private void CargarClientes()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    //consulta a DB
                    string consulta = @"
                        SELECT 
                            Idcliente AS 'ID', 
                            Nombres AS 'Nombres', 
                            Apellidos AS 'Apellidos', 
                            Telefono AS 'Teléfono', 
                            Correo AS 'Correo'
                        FROM FitMaxDB.Clientes";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando)) 
                            //mysql adapter es usado para no tener que recorrer los resultados fila por fila
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);

                            // Asignamos el DataTable como origen de datos del DataGridView
                            dataGridView1.DataSource = dt;

                            // Actualizamos el total de clientes usando el conteo de filas del DataTable
                            lbl_total_clientes.Text = dt.Rows.Count.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los clientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarMembresiasPorVencer()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT COUNT(*)
                        FROM ClienteMembresia
                        WHERE FechaFin >= CURDATE()
                        AND FechaFin <= DATE_ADD(CURDATE(), INTERVAL 7 DAY)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        int total = Convert.ToInt32(comando.ExecuteScalar());
                        lbl_membresias_por_vencer.Text = total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar las membresías por vencer: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarPromedioAsistencia()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            (SELECT COUNT(*) FROM Asistencias) AS TotalAsistencias,
                            (SELECT COUNT(*) FROM Clientes) AS TotalClientes";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            int totalAsistencias = Convert.ToInt32(lector["TotalAsistencias"]);
                            int totalClientes = Convert.ToInt32(lector["TotalClientes"]);

                            decimal promedio = totalClientes > 0
                                ? (decimal)totalAsistencias / totalClientes
                                : 0;

                            lbl_promedio_asistencia.Text = promedio.ToString("0.00");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al calcular el promedio de asistencia: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void lbl_total_clientes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //no es necesario modificar
        }

        private void btn_db_empleados_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
