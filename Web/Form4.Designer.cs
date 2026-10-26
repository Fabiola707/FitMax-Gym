namespace Web
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            btn_inicio = new Button();
            btn_db_empleados = new Button();
            btn_clientes = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_total_clientes = new Label();
            lbl_membresias_por_vencer = new Label();
            lbl_promedio_asistencia = new Label();
            btn_cerrar_sesion = new Button();
            pictureBox7 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.BackgroundImage = Properties.Resources.BG4;
            pictureBox1.Location = new Point(1, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 579);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(64, 64, 64);
            label14.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Image = Properties.Resources.BG4;
            label14.Location = new Point(25, 115);
            label14.Name = "label14";
            label14.Size = new Size(108, 31);
            label14.TabIndex = 32;
            label14.Text = "FITMAX GYM";
            label14.Click += label14_Click;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.FromArgb(64, 64, 64);
            btn_inicio.BackgroundImage = Properties.Resources.BG4;
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = SystemColors.AppWorkspace;
            btn_inicio.Location = new Point(1, 234);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(161, 28);
            btn_inicio.TabIndex = 33;
            btn_inicio.Text = "INICIO";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // btn_db_empleados
            // 
            btn_db_empleados.BackColor = Color.FromArgb(64, 64, 64);
            btn_db_empleados.BackgroundImage = Properties.Resources.BG4;
            btn_db_empleados.FlatAppearance.BorderSize = 0;
            btn_db_empleados.FlatStyle = FlatStyle.Flat;
            btn_db_empleados.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_db_empleados.ForeColor = SystemColors.AppWorkspace;
            btn_db_empleados.Location = new Point(1, 267);
            btn_db_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_db_empleados.Name = "btn_db_empleados";
            btn_db_empleados.Size = new Size(161, 28);
            btn_db_empleados.TabIndex = 34;
            btn_db_empleados.Text = "EMPLEADOS";
            btn_db_empleados.UseVisualStyleBackColor = false;
            btn_db_empleados.Click += btn_db_empleados_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.FromArgb(64, 64, 64);
            btn_clientes.BackgroundImage = Properties.Resources.BG4;
            btn_clientes.FlatAppearance.BorderSize = 0;
            btn_clientes.FlatStyle = FlatStyle.Flat;
            btn_clientes.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clientes.ForeColor = SystemColors.AppWorkspace;
            btn_clientes.Location = new Point(1, 300);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(161, 28);
            btn_clientes.TabIndex = 36;
            btn_clientes.Text = "CLIENTES";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(199, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 37;
            label1.Text = "GESTIÓN DE CLIENTES";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.BG7;
            pictureBox3.Location = new Point(199, 100);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 98);
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.BG7;
            pictureBox2.Location = new Point(199, 234);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 98);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.BG7;
            pictureBox4.Location = new Point(199, 369);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 98);
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Image = Properties.Resources.BG5;
            label4.Location = new Point(230, 116);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 42;
            label4.Text = "TOTAL DE CLIENTES";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Image = Properties.Resources.BG5;
            label2.Location = new Point(230, 253);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 43;
            label2.Text = "MEMBRESIAS POR VENCER";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Image = Properties.Resources.BG5;
            label3.Location = new Point(230, 388);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 44;
            label3.Text = "ASISTENCIA MEDIA";
            label3.Click += label3_Click;
            // 
            // lbl_total_clientes
            // 
            lbl_total_clientes.AutoSize = true;
            lbl_total_clientes.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_clientes.ForeColor = SystemColors.ButtonHighlight;
            lbl_total_clientes.Image = Properties.Resources.BG5;
            lbl_total_clientes.Location = new Point(283, 153);
            lbl_total_clientes.Name = "lbl_total_clientes";
            lbl_total_clientes.Size = new Size(42, 31);
            lbl_total_clientes.TabIndex = 45;
            lbl_total_clientes.Text = "----";
            lbl_total_clientes.Click += lbl_total_clientes_Click;
            // 
            // lbl_membresias_por_vencer
            // 
            lbl_membresias_por_vencer.AutoSize = true;
            lbl_membresias_por_vencer.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_membresias_por_vencer.ForeColor = SystemColors.ButtonHighlight;
            lbl_membresias_por_vencer.Image = Properties.Resources.BG5;
            lbl_membresias_por_vencer.Location = new Point(283, 286);
            lbl_membresias_por_vencer.Name = "lbl_membresias_por_vencer";
            lbl_membresias_por_vencer.Size = new Size(42, 31);
            lbl_membresias_por_vencer.TabIndex = 46;
            lbl_membresias_por_vencer.Text = "----";
            // 
            // lbl_promedio_asistencia
            // 
            lbl_promedio_asistencia.AutoSize = true;
            lbl_promedio_asistencia.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_promedio_asistencia.ForeColor = SystemColors.ButtonHighlight;
            lbl_promedio_asistencia.Image = Properties.Resources.BG5;
            lbl_promedio_asistencia.Location = new Point(283, 420);
            lbl_promedio_asistencia.Name = "lbl_promedio_asistencia";
            lbl_promedio_asistencia.Size = new Size(42, 31);
            lbl_promedio_asistencia.TabIndex = 47;
            lbl_promedio_asistencia.Text = "----";
            // 
            // btn_cerrar_sesion
            // 
            btn_cerrar_sesion.BackColor = Color.Red;
            btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            btn_cerrar_sesion.FlatStyle = FlatStyle.Popup;
            btn_cerrar_sesion.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar_sesion.ForeColor = SystemColors.ButtonHighlight;
            btn_cerrar_sesion.Location = new Point(12, 526);
            btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            btn_cerrar_sesion.Size = new Size(134, 38);
            btn_cerrar_sesion.TabIndex = 48;
            btn_cerrar_sesion.Text = "CERRAR SESIÓN";
            btn_cerrar_sesion.UseVisualStyleBackColor = false;
            btn_cerrar_sesion.Click += btn_cerrar_sesion_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(25, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(110, 100);
            pictureBox7.TabIndex = 49;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(446, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(546, 367);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1018, 576);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox7);
            Controls.Add(btn_cerrar_sesion);
            Controls.Add(lbl_promedio_asistencia);
            Controls.Add(lbl_membresias_por_vencer);
            Controls.Add(lbl_total_clientes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(btn_clientes);
            Controls.Add(btn_db_empleados);
            Controls.Add(btn_inicio);
            Controls.Add(label14);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label14;
        private Button btn_inicio;
        private Button btn_db_empleados;
        private Button btn_clientes;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label lbl_total_clientes;
        private Label lbl_membresias_por_vencer;
        private Label lbl_promedio_asistencia;
        private Button btn_cerrar_sesion;
        private PictureBox pictureBox7;
        private DataGridView dataGridView1;
    }
}