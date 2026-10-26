using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Core;
using FitMax;
using System.Globalization;

namespace Web
{
    public partial class Form2 : Form
    {

        private const int CapacidadMaxima = 100;
        //private static string connectionString = @"Server=localhost;Port=3306;Database=fitmaxDB;Uid=root;Pwd=19503236;";
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load; //verificar porque da error

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarIndicadores(); //error
            CargarInventario();
        }
        private void CargarIndicadores()//declaracion de la accion
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // miembros activos
                    string consultaMiembros = @"
                        SELECT COUNT(DISTINCT IdCliente)
                        FROM ClienteMembresia
                        WHERE FechaInicio <= CURDATE()
                          AND FechaFin >= CURDATE()";

                    int miembrosActivos;

                    using (MySqlCommand comando =
                           new MySqlCommand(consultaMiembros, conexion))
                    {
                        miembrosActivos =
                            Convert.ToInt32(comando.ExecuteScalar());
                    }
                    lbl_miembros_activos.Text =
                        miembrosActivos.ToString();

                    //ingresos totales
                    string consultaIngresos =
                        "SELECT COALESCE(SUM(Monto), 0) FROM Pagos";

                    decimal ingresosTotales;

                    using (MySqlCommand comando =
                           new MySqlCommand(consultaIngresos, conexion))
                    {
                        ingresosTotales =
                            Convert.ToDecimal(comando.ExecuteScalar());
                    }

                    lbl_ingresos_totales.Text =
                        ingresosTotales.ToString("C2", new CultureInfo("es-MX"));

                    //capacidad máxima
                    decimal ocupacion =
                        (decimal)miembrosActivos / CapacidadMaxima * 100;

                    lbl_ocupacion_gym.Text =
                        ocupacion.ToString("0.0") + "%";

                    // 4. Stock total de productos
                    string consultaStock =
                        "SELECT COALESCE(SUM(Stock), 0) FROM Productos";

                    int stockTotal;

                    using (MySqlCommand comando =
                           new MySqlCommand(consultaStock, conexion))
                    {
                        stockTotal =
                            Convert.ToInt32(comando.ExecuteScalar());
                    }

                    lbl_stock.Text = stockTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los indicadores: " + ex.Message,
                    "FitMax Gym",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_nueva_venta_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //  no necesario modificar
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void btb_alta_miembro_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void lbl_miembros_activos_Click(object sender, EventArgs e)
        {

        }
        private void CargarInventario()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = @"
                SELECT 
                    IdProducto AS 'ID', 
                    Nombre AS 'Producto', 
                    Precio AS 'Precio ($)', 
                    Stock AS 'Stock Disponible'
                FROM fitmaxdb.productos";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR INVENTARIO: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_contabilidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_membresia_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();
        }
    }
}
