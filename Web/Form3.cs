using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Web
{
    public partial class Form3 : Form
    {
        private static string connectionString = @"Server=localhost;Port=3307;Database=FitMaxDB;Uid=root;Pwd=;paola05";
        public Form3()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
