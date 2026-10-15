using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Web
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_nueva_venta_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
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
    }
}
