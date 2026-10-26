namespace Web
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            label14 = new Label();
            btn_inicio = new Button();
            btn_db_empleados = new Button();
            btn_clientes = new Button();
            btn_cerrar_sesion = new Button();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.BackgroundImage = Properties.Resources.BG4;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 579);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(25, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(110, 100);
            pictureBox7.TabIndex = 51;
            pictureBox7.TabStop = false;
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
            label14.TabIndex = 73;
            label14.Text = "FITMAX GYM";
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.FromArgb(64, 64, 64);
            btn_inicio.BackgroundImage = Properties.Resources.BG4;
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = SystemColors.AppWorkspace;
            btn_inicio.Location = new Point(1, 236);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(161, 28);
            btn_inicio.TabIndex = 74;
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
            btn_db_empleados.Location = new Point(1, 269);
            btn_db_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_db_empleados.Name = "btn_db_empleados";
            btn_db_empleados.Size = new Size(161, 28);
            btn_db_empleados.TabIndex = 75;
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
            btn_clientes.Location = new Point(1, 302);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(161, 28);
            btn_clientes.TabIndex = 77;
            btn_clientes.Text = "CLIENTES";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_cerrar_sesion
            // 
            btn_cerrar_sesion.BackColor = Color.Red;
            btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            btn_cerrar_sesion.FlatStyle = FlatStyle.Popup;
            btn_cerrar_sesion.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar_sesion.ForeColor = SystemColors.ButtonHighlight;
            btn_cerrar_sesion.Location = new Point(12, 525);
            btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            btn_cerrar_sesion.Size = new Size(134, 38);
            btn_cerrar_sesion.TabIndex = 78;
            btn_cerrar_sesion.Text = "CERRAR SESIÓN";
            btn_cerrar_sesion.UseVisualStyleBackColor = false;
            btn_cerrar_sesion.Click += btn_cerrar_sesion_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 243);
            dataGridView1.TabIndex = 79;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.BG4;
            pictureBox2.Location = new Point(217, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(735, 270);
            pictureBox2.TabIndex = 80;
            pictureBox2.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1017, 575);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_cerrar_sesion);
            Controls.Add(btn_clientes);
            Controls.Add(btn_db_empleados);
            Controls.Add(btn_inicio);
            Controls.Add(label14);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private Label label14;
        private Button btn_inicio;
        private Button btn_db_empleados;
        private Button btn_clientes;
        private Button btn_cerrar_sesion;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
    }
}