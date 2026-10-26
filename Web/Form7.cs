using FitMax;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//---ya me cansé---
namespace Web//pantalla de venta de productos y descontardel stock
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            CargarProductos();
            if (dtCarrito.Columns.Count == 0)
            {
                dtCarrito.Columns.Add("IdProducto", typeof(int));
                dtCarrito.Columns.Add("Producto", typeof(string));
                dtCarrito.Columns.Add("Precio", typeof(decimal));
                dtCarrito.Columns.Add("Cantidad", typeof(int)); ;
                dtCarrito.Columns.Add("Subtotal", typeof(decimal), "Precio * Cantidad");
            }
            dgv_compra.DataSource = dtCarrito;
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)//interfaz clientes
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void btn_contabilidad_Click(object sender, EventArgs e)
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dtCarrito == null)//existencia tabla
            {
                dtCarrito = new DataTable();
                dtCarrito.Columns.Add("IdProducto", typeof(int));
                dtCarrito.Columns.Add("Producto", typeof(string));
                dtCarrito.Columns.Add("Precio", typeof(decimal));
                dtCarrito.Columns.Add("Cantidad", typeof(int));
                dtCarrito.Columns.Add("Subtotal", typeof(decimal), "Precio * Cantidad");
                dgv_compra.DataSource = dtCarrito;
            }
            if (dgv_existencia.SelectedRows.Count == 0)//sin seleccion da aviso para seleccionar

            {
                MessageBox.Show("Por favor, selecciona un producto de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txb_cantidad_productos.Text))
            {
                MessageBox.Show("Por favor, ingresa una cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //camntidad mayor a 0
            if (!int.TryParse(txb_cantidad_productos.Text.Trim(), out int cantidadIngresada) || cantidadIngresada <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow filaSeleccionada = dgv_existencia.SelectedRows[0];

            int idProducto = Convert.ToInt32(filaSeleccionada.Cells[0].Value); //ajuste
            string nombreProducto = filaSeleccionada.Cells[1].Value.ToString();
            decimal precioUnitario = Convert.ToDecimal(filaSeleccionada.Cells[2].Value);
            int stockDisponible = Convert.ToInt32(filaSeleccionada.Cells[3].Value);

            //coincidir con stock
            if (cantidadIngresada > stockDisponible)
            {
                MessageBox.Show($"No hay suficiente stock. Stock disponible: {stockDisponible}", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool productoExiste = false;//existencia
            foreach (DataRow dr in dtCarrito.Rows)
            {
                if (Convert.ToInt32(dr["IdProducto"]) == idProducto)
                {
                    int nuevaCantidad = Convert.ToInt32(dr["Cantidad"]) + cantidadIngresada;

                    if (nuevaCantidad > stockDisponible)
                    {
                        MessageBox.Show("La cantidad total en el carrito supera el stock disponible.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dr["Cantidad"] = nuevaCantidad;
                    productoExiste = true;
                    break;
                }
                if (!productoExiste)
                {
                    dtCarrito.Rows.Add(nombreProducto, precioUnitario, cantidadIngresada);//quité id
                }

                //total general
                CalcularTotalGeneral();
                txb_cantidad_productos.Clear();
            }
        }
        private void CalcularTotalGeneral()
        {
            decimal totalGeneral = 0;
            foreach (DataRow dr in dtCarrito.Rows)
            {
                totalGeneral += Convert.ToDecimal(dr["Subtotal"]);
            }
            lbl_total_a_pagar.Text = "TOTAL: $" + totalGeneral.ToString("0.00");
        }

        private void txb_pago_cliente_TextChanged(object sender, EventArgs e)//monto
        {

        }

        private void lbl_cambio_cliente_Click(object sender, EventArgs e)
        {
            if (MetodoPagoSeleccion == "Tarjeta") return;
            string totalTexto = lbl_total_a_pagar.Text.Replace("TOTAL: $", "").Trim();
            if (decimal.TryParse(totalTexto, out decimal totalGeneral) &&
        decimal.TryParse(txb_pago_cliente.Text.Trim(), out decimal efectivoRecibido))
            {
                decimal cambio = efectivoRecibido - totalGeneral;

                if (cambio >= 0)
                {
                    lbl_cambio_cliente.Text = "$" + cambio.ToString("0.00");
                }
                else
                {
                    lbl_cambio_cliente.Text = "Insuficiente";
                }
            }
            else
            {
                lbl_cambio_cliente.Text = "$0.00";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void CargarProductos()
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
                            dgv_existencia.DataSource = dt;
                            dgv_existencia.Columns[0].Visible = false;
                            //dgv_existencia.Columns[2].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR INVENTARIO: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InicializarCarrito()
        {
            dtCarrito = new DataTable();
            dtCarrito.Columns.Add("IdProducto", typeof(int));
            dtCarrito.Columns.Add("Producto", typeof(string));
            dtCarrito.Columns.Add("Precio", typeof(decimal));
            dtCarrito.Columns.Add("Cantidad", typeof(int));
            //calcular subtotal
            dtCarrito.Columns.Add("Subtotal", typeof(decimal), "Precio * Cantidad");

            // enlace del carrito al dgv
            dgv_compra.DataSource = dtCarrito;
        }

        private void dgv_existencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//fila valida
            {
                DataGridViewRow fila = dgv_existencia.Rows[e.RowIndex];

                decimal precio = Convert.ToDecimal(fila.Cells[2].Value);

                lbl_mostrar_precio.Text = "$" + precio.ToString("0.00");//lbl de precio
            }
        }
        private DataTable dtCarrito= new DataTable();

        private void dgv_compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_mostrar_precio_Click(object sender, EventArgs e)
        {

        }

        private void txb_cantidad_productos_TextChanged(object sender, EventArgs e)
        {

        }
        private string MetodoPagoSeleccion = "Efectivo"; // por defecto se inicia en efectivo

        private void btn_pago_efectivo_Click(object sender, EventArgs e)
        {
            MetodoPagoSeleccion = "Efectivo";
            txb_pago_cliente.Enabled = true;//habilitado
        }

        private void btn_pago_tarjeta_Click(object sender, EventArgs e)
        {
            MetodoPagoSeleccion = "Tarjeta";
            txb_pago_cliente.Enabled = false;//no habilitado
            lbl_cambio_cliente.Text = "$0.00";


        }

        private void btn_finalizar_compra_Click(object sender, EventArgs e)
        {
            if (dtCarrito == null || dtCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agrega productos antes de finalizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal totalGeneral = 0;
            foreach (DataRow dr in dtCarrito.Rows)
            {
                totalGeneral += Convert.ToDecimal(dr["Subtotal"]);
            }
            decimal efectivoRecibido = 0;
            if (MetodoPagoSeleccion == "Efectivo")
            {
                if (!decimal.TryParse(txb_pago_cliente.Text.Trim(), out efectivoRecibido) || efectivoRecibido < totalGeneral)
                {
                    MessageBox.Show("El monto ingresado en efectivo es menor al total de la venta o no es válido.", "Error de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                            string queryPago = "INSERT INTO fitmaxdb.pagos (Total, MetodoPago, Fecha) VALUES (@total, @metodo, NOW())";
                            using (MySqlCommand cmdPago = new MySqlCommand(queryPago, conexion, transaccion))
                            {
                                cmdPago.Parameters.AddWithValue("@total", totalGeneral);
                                cmdPago.Parameters.AddWithValue("@metodo", MetodoPagoSeleccion);
                                cmdPago.ExecuteNonQuery();
                            }
                            foreach (DataRow dr in dtCarrito.Rows)
                            {
                                int idProducto = Convert.ToInt32(dr["IdProducto"]);
                                int cantidadComprada = Convert.ToInt32(dr["Cantidad"]);

                                string queryStock = @"
                            UPDATE fitmaxdb.productos 
                            SET Stock = Stock - @cantidad 
                            WHERE IdProducto = @idProducto";
                                using (MySqlCommand cmdStock = new MySqlCommand(queryStock, conexion, transaccion))
                                {
                                    cmdStock.Parameters.AddWithValue("@cantidad", cantidadComprada);
                                    cmdStock.Parameters.AddWithValue("@idProducto", idProducto);
                                    cmdStock.ExecuteNonQuery();
                                }
                            }
                            transaccion.Commit();
                        }
                        catch
                        {
                            transaccion.Rollback();//revertir si hay error
                            throw;
                        }
                    }
                }
                string mensaje = "¡Venta finalizada con éxito";
                if (MetodoPagoSeleccion == "Efectivo")
                {
                    decimal cambioFinal = efectivoRecibido - totalGeneral;
                    mensaje += $"\nCambio a devolver al cliente: ${cambioFinal.ToString("0.00")}";
                }

                MessageBox.Show(mensaje, "FitMax Gym", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtCarrito.Rows.Clear();
                lbl_total_a_pagar.Text = "TOTAL: $0.00";
                txb_pago_cliente.Clear();
                lbl_cambio_cliente.Text = "$0.00";
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la venta: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_total_a_pagar_Click(object sender, EventArgs e)
        {

        }
    }
}
