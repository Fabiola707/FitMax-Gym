using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//---
namespace Web//pantalla de venta de productos y descontardel stock
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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
    }
}
