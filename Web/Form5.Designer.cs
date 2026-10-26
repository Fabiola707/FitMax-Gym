namespace Web
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tbx_nombre_empleado = new TextBox();
            tbx_empleado_contraseña = new TextBox();
            tbx_usuario_empleado = new TextBox();
            btn_agregar_empleado = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            btn_inicio = new Button();
            btn_db_empleados = new Button();
            btn_clientes = new Button();
            btn_cerrar_sesion = new Button();
            cbx_administrador = new CheckBox();
            cbx_cajero = new CheckBox();
            cbx_entrenador = new CheckBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.BackgroundImage = Properties.Resources.BG4;
            pictureBox1.Location = new Point(1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 579);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(22, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(110, 100);
            pictureBox7.TabIndex = 50;
            pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.BG5;
            pictureBox2.Location = new Point(220, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(732, 231);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Image = Properties.Resources.BG5;
            label1.Location = new Point(816, 64);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 52;
            label1.Text = "NUEVO EMPLEADO";
            // 
            // tbx_nombre_empleado
            // 
            tbx_nombre_empleado.BackColor = Color.Black;
            tbx_nombre_empleado.BorderStyle = BorderStyle.FixedSingle;
            tbx_nombre_empleado.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_nombre_empleado.ForeColor = SystemColors.Window;
            tbx_nombre_empleado.Location = new Point(246, 92);
            tbx_nombre_empleado.Name = "tbx_nombre_empleado";
            tbx_nombre_empleado.Size = new Size(316, 26);
            tbx_nombre_empleado.TabIndex = 53;
            tbx_nombre_empleado.TextChanged += tbx_nombre_empleado_TextChanged;
            // 
            // tbx_empleado_contraseña
            // 
            tbx_empleado_contraseña.BackColor = Color.Black;
            tbx_empleado_contraseña.BorderStyle = BorderStyle.FixedSingle;
            tbx_empleado_contraseña.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_empleado_contraseña.ForeColor = SystemColors.Window;
            tbx_empleado_contraseña.Location = new Point(622, 146);
            tbx_empleado_contraseña.Name = "tbx_empleado_contraseña";
            tbx_empleado_contraseña.Size = new Size(290, 26);
            tbx_empleado_contraseña.TabIndex = 54;
            tbx_empleado_contraseña.TextChanged += tbx_empleado_contraseña_TextChanged;
            // 
            // tbx_usuario_empleado
            // 
            tbx_usuario_empleado.BackColor = Color.Black;
            tbx_usuario_empleado.BorderStyle = BorderStyle.FixedSingle;
            tbx_usuario_empleado.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_usuario_empleado.ForeColor = SystemColors.Window;
            tbx_usuario_empleado.Location = new Point(622, 92);
            tbx_usuario_empleado.Name = "tbx_usuario_empleado";
            tbx_usuario_empleado.Size = new Size(290, 26);
            tbx_usuario_empleado.TabIndex = 55;
            tbx_usuario_empleado.TextChanged += tbx_usuario_empleado_TextChanged;
            // 
            // btn_agregar_empleado
            // 
            btn_agregar_empleado.BackColor = Color.Red;
            btn_agregar_empleado.FlatAppearance.BorderSize = 0;
            btn_agregar_empleado.FlatStyle = FlatStyle.Flat;
            btn_agregar_empleado.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_empleado.ForeColor = SystemColors.ControlLightLight;
            btn_agregar_empleado.Location = new Point(622, 197);
            btn_agregar_empleado.Name = "btn_agregar_empleado";
            btn_agregar_empleado.Size = new Size(290, 45);
            btn_agregar_empleado.TabIndex = 57;
            btn_agregar_empleado.Text = "AGREGAR";
            btn_agregar_empleado.UseVisualStyleBackColor = false;
            btn_agregar_empleado.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.BG5;
            label2.Location = new Point(246, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 58;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.BG5;
            label3.Location = new Point(622, 69);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 59;
            label3.Text = "USUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.BG5;
            label4.Location = new Point(622, 121);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 60;
            label4.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = Properties.Resources.BG5;
            label5.Location = new Point(246, 130);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 61;
            label5.Text = "PUESTOS";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.BG5;
            pictureBox3.Location = new Point(400, 298);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(552, 231);
            pictureBox3.TabIndex = 62;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 128);
            label6.Image = Properties.Resources.BG5;
            label6.Location = new Point(853, 316);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 63;
            label6.Text = "EMPLEADOS";
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.FromArgb(64, 64, 64);
            btn_inicio.BackgroundImage = Properties.Resources.BG4;
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = SystemColors.AppWorkspace;
            btn_inicio.Location = new Point(1, 233);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(161, 28);
            btn_inicio.TabIndex = 64;
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
            btn_db_empleados.Location = new Point(1, 266);
            btn_db_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_db_empleados.Name = "btn_db_empleados";
            btn_db_empleados.Size = new Size(161, 28);
            btn_db_empleados.TabIndex = 65;
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
            btn_clientes.Location = new Point(1, 299);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(161, 28);
            btn_clientes.TabIndex = 67;
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
            btn_cerrar_sesion.Location = new Point(12, 523);
            btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            btn_cerrar_sesion.Size = new Size(134, 38);
            btn_cerrar_sesion.TabIndex = 68;
            btn_cerrar_sesion.Text = "CERRAR SESIÓN";
            btn_cerrar_sesion.UseVisualStyleBackColor = false;
            btn_cerrar_sesion.Click += btn_cerrar_sesion_Click;
            // 
            // cbx_administrador
            // 
            cbx_administrador.AutoSize = true;
            cbx_administrador.BackgroundImage = Properties.Resources.BG5;
            cbx_administrador.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_administrador.ForeColor = SystemColors.ButtonHighlight;
            cbx_administrador.Location = new Point(246, 164);
            cbx_administrador.Name = "cbx_administrador";
            cbx_administrador.Size = new Size(100, 24);
            cbx_administrador.TabIndex = 69;
            cbx_administrador.Text = "ADMINISTRADOR";
            cbx_administrador.UseVisualStyleBackColor = true;
            cbx_administrador.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbx_cajero
            // 
            cbx_cajero.AutoSize = true;
            cbx_cajero.BackgroundImage = Properties.Resources.BG5;
            cbx_cajero.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_cajero.ForeColor = SystemColors.ButtonHighlight;
            cbx_cajero.Location = new Point(246, 194);
            cbx_cajero.Name = "cbx_cajero";
            cbx_cajero.Size = new Size(63, 24);
            cbx_cajero.TabIndex = 70;
            cbx_cajero.Text = "CAJERO";
            cbx_cajero.UseVisualStyleBackColor = true;
            // 
            // cbx_entrenador
            // 
            cbx_entrenador.AutoSize = true;
            cbx_entrenador.BackgroundImage = Properties.Resources.BG5;
            cbx_entrenador.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbx_entrenador.ForeColor = SystemColors.ButtonHighlight;
            cbx_entrenador.Location = new Point(246, 224);
            cbx_entrenador.Name = "cbx_entrenador";
            cbx_entrenador.Size = new Size(86, 24);
            cbx_entrenador.TabIndex = 71;
            cbx_entrenador.Text = "ENTRENADOR";
            cbx_entrenador.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(64, 64, 64);
            label14.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Image = Properties.Resources.BG4;
            label14.Location = new Point(22, 115);
            label14.Name = "label14";
            label14.Size = new Size(108, 31);
            label14.TabIndex = 72;
            label14.Text = "FITMAX GYM";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(424, 344);
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
            dataGridView1.Size = new Size(516, 145);
            dataGridView1.TabIndex = 73;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(220, 298);
            button1.Name = "button1";
            button1.Size = new Size(132, 231);
            button1.TabIndex = 74;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1019, 573);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label14);
            Controls.Add(cbx_entrenador);
            Controls.Add(cbx_cajero);
            Controls.Add(cbx_administrador);
            Controls.Add(btn_cerrar_sesion);
            Controls.Add(btn_clientes);
            Controls.Add(btn_db_empleados);
            Controls.Add(btn_inicio);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_agregar_empleado);
            Controls.Add(tbx_usuario_empleado);
            Controls.Add(tbx_empleado_contraseña);
            Controls.Add(tbx_nombre_empleado);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox tbx_nombre_empleado;
        private TextBox tbx_empleado_contraseña;
        private TextBox tbx_usuario_empleado;
        private Button btn_agregar_empleado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label6;
        private Button btn_inicio;
        private Button btn_db_empleados;
        private Button btn_clientes;
        private Button btn_cerrar_sesion;
        private CheckBox cbx_administrador;
        private CheckBox cbx_cajero;
        private CheckBox cbx_entrenador;
        private Label label14;
        private DataGridView dataGridView1;
        private Button button1;
    }
}