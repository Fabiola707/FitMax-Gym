using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Web
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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
    }
}
