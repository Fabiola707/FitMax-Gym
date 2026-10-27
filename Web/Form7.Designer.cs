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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            label14 = new Label();
            btn_inicio = new Button();
            btn_db_empleados = new Button();
            btn_clientes = new Button();
            btn_cerrar_sesion = new Button();
            dgv_existencia = new DataGridView();
            pictureBox2 = new PictureBox();
            txb_producto_nombre_id = new TextBox();
            btn_buscar_producto = new Button();
            dgv_compra = new DataGridView();
            btn_agregar_a_lista = new Button();
            label4 = new Label();
            lbl_mostrar_precio = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_cantidad_productos = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_total_a_pagar = new Label();
            btn_pago_tarjeta = new Button();
            btn_pago_efectivo = new Button();
            txb_pago_cliente = new TextBox();
            label8 = new Label();
            label9 = new Label();
            lbl_cambio_cliente = new Label();
            btn_finalizar_compra = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_existencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_compra).BeginInit();
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
            // dgv_existencia
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgv_existencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_existencia.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_existencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_existencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_existencia.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_existencia.Location = new Point(189, 99);
            dgv_existencia.MultiSelect = false;
            dgv_existencia.Name = "dgv_existencia";
            dgv_existencia.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_existencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_existencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_existencia.Size = new Size(341, 231);
            dgv_existencia.TabIndex = 79;
            dgv_existencia.CellContentClick += dgv_existencia_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.BG4;
            pictureBox2.Location = new Point(558, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(434, 338);
            pictureBox2.TabIndex = 80;
            pictureBox2.TabStop = false;
            // 
            // txb_producto_nombre_id
            // 
            txb_producto_nombre_id.Location = new Point(581, 67);
            txb_producto_nombre_id.Name = "txb_producto_nombre_id";
            txb_producto_nombre_id.Size = new Size(141, 23);
            txb_producto_nombre_id.TabIndex = 81;
            txb_producto_nombre_id.TextChanged += txb_producto_nombre_id_TextChanged;
            // 
            // btn_buscar_producto
            // 
            btn_buscar_producto.BackColor = Color.Red;
            btn_buscar_producto.FlatAppearance.BorderSize = 0;
            btn_buscar_producto.FlatStyle = FlatStyle.Flat;
            btn_buscar_producto.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar_producto.ForeColor = SystemColors.Window;
            btn_buscar_producto.Location = new Point(580, 108);
            btn_buscar_producto.Name = "btn_buscar_producto";
            btn_buscar_producto.Size = new Size(142, 42);
            btn_buscar_producto.TabIndex = 82;
            btn_buscar_producto.Text = "BUSCAR";
            btn_buscar_producto.UseVisualStyleBackColor = false;
            btn_buscar_producto.Click += button1_Click;
            // 
            // dgv_compra
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgv_compra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_compra.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgv_compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_compra.Location = new Point(189, 382);
            dgv_compra.Name = "dgv_compra";
            dgv_compra.Size = new Size(533, 165);
            dgv_compra.TabIndex = 83;
            dgv_compra.CellContentClick += dgv_compra_CellContentClick;
            // 
            // btn_agregar_a_lista
            // 
            btn_agregar_a_lista.BackColor = Color.Red;
            btn_agregar_a_lista.FlatAppearance.BorderSize = 0;
            btn_agregar_a_lista.FlatStyle = FlatStyle.Flat;
            btn_agregar_a_lista.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar_a_lista.ForeColor = SystemColors.Window;
            btn_agregar_a_lista.Location = new Point(743, 110);
            btn_agregar_a_lista.Name = "btn_agregar_a_lista";
            btn_agregar_a_lista.Size = new Size(224, 38);
            btn_agregar_a_lista.TabIndex = 84;
            btn_agregar_a_lista.Text = "AGREGAR AL CARRITO";
            btn_agregar_a_lista.UseVisualStyleBackColor = false;
            btn_agregar_a_lista.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Image = Properties.Resources.BG41;
            label4.Location = new Point(581, 43);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 88;
            label4.Text = "INGRESE NOMBRE O ID";
            // 
            // lbl_mostrar_precio
            // 
            lbl_mostrar_precio.AutoSize = true;
            lbl_mostrar_precio.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mostrar_precio.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_mostrar_precio.Image = Properties.Resources.BG41;
            lbl_mostrar_precio.Location = new Point(888, 70);
            lbl_mostrar_precio.Name = "lbl_mostrar_precio";
            lbl_mostrar_precio.Size = new Size(79, 20);
            lbl_mostrar_precio.TabIndex = 89;
            lbl_mostrar_precio.Text = "--------------";
            lbl_mostrar_precio.Click += lbl_mostrar_precio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(210, 28);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 90;
            label2.Text = "VENTA DE PRODUCTOS";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(189, 346);
            label3.Name = "label3";
            label3.Size = new Size(199, 20);
            label3.TabIndex = 91;
            label3.Text = "PRODUCTOS AGREGADOS AL CARRITO";
            // 
            // txb_cantidad_productos
            // 
            txb_cantidad_productos.Location = new Point(743, 67);
            txb_cantidad_productos.Name = "txb_cantidad_productos";
            txb_cantidad_productos.Size = new Size(121, 23);
            txb_cantidad_productos.TabIndex = 92;
            txb_cantidad_productos.TextChanged += txb_cantidad_productos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources.BG41;
            label1.Location = new Point(743, 43);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 93;
            label1.Text = "INGRESE CANTIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(381, 66);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 94;
            label5.Text = "PRODUCTOS EN EXISTENCIA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 128);
            label6.Location = new Point(743, 512);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 95;
            label6.Text = "TOTAL:";
            // 
            // lbl_total_a_pagar
            // 
            lbl_total_a_pagar.AutoSize = true;
            lbl_total_a_pagar.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total_a_pagar.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_total_a_pagar.Location = new Point(913, 512);
            lbl_total_a_pagar.Name = "lbl_total_a_pagar";
            lbl_total_a_pagar.Size = new Size(79, 20);
            lbl_total_a_pagar.TabIndex = 96;
            lbl_total_a_pagar.Text = "--------------";
            lbl_total_a_pagar.Click += lbl_total_a_pagar_Click;
            // 
            // btn_pago_tarjeta
            // 
            btn_pago_tarjeta.BackgroundImage = Properties.Resources.BG42;
            btn_pago_tarjeta.FlatStyle = FlatStyle.Flat;
            btn_pago_tarjeta.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pago_tarjeta.ForeColor = SystemColors.Control;
            btn_pago_tarjeta.Location = new Point(826, 233);
            btn_pago_tarjeta.Name = "btn_pago_tarjeta";
            btn_pago_tarjeta.Size = new Size(141, 38);
            btn_pago_tarjeta.TabIndex = 97;
            btn_pago_tarjeta.Text = "TARJETA";
            btn_pago_tarjeta.UseVisualStyleBackColor = true;
            btn_pago_tarjeta.Click += btn_pago_tarjeta_Click;
            // 
            // btn_pago_efectivo
            // 
            btn_pago_efectivo.BackgroundImage = Properties.Resources.BG42;
            btn_pago_efectivo.FlatStyle = FlatStyle.Flat;
            btn_pago_efectivo.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pago_efectivo.ForeColor = Color.White;
            btn_pago_efectivo.Location = new Point(826, 173);
            btn_pago_efectivo.Name = "btn_pago_efectivo";
            btn_pago_efectivo.Size = new Size(141, 38);
            btn_pago_efectivo.TabIndex = 98;
            btn_pago_efectivo.Text = "EFECTIVO";
            btn_pago_efectivo.UseVisualStyleBackColor = true;
            btn_pago_efectivo.Click += btn_pago_efectivo_Click;
            // 
            // txb_pago_cliente
            // 
            txb_pago_cliente.Location = new Point(581, 233);
            txb_pago_cliente.Name = "txb_pago_cliente";
            txb_pago_cliente.Size = new Size(155, 23);
            txb_pago_cliente.TabIndex = 99;
            txb_pago_cliente.TextChanged += txb_pago_cliente_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Image = Properties.Resources.BG42;
            label8.Location = new Point(581, 191);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 100;
            label8.Text = "INGRESE MONTO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 128);
            label9.Location = new Point(743, 458);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 101;
            label9.Text = "CAMBIO:";
            // 
            // lbl_cambio_cliente
            // 
            lbl_cambio_cliente.AutoSize = true;
            lbl_cambio_cliente.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cambio_cliente.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_cambio_cliente.Location = new Point(913, 458);
            lbl_cambio_cliente.Name = "lbl_cambio_cliente";
            lbl_cambio_cliente.Size = new Size(79, 20);
            lbl_cambio_cliente.TabIndex = 102;
            lbl_cambio_cliente.Text = "--------------";
            lbl_cambio_cliente.Click += lbl_cambio_cliente_Click;
            // 
            // btn_finalizar_compra
            // 
            btn_finalizar_compra.BackColor = Color.Red;
            btn_finalizar_compra.FlatAppearance.BorderSize = 0;
            btn_finalizar_compra.FlatStyle = FlatStyle.Flat;
            btn_finalizar_compra.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_finalizar_compra.ForeColor = SystemColors.Window;
            btn_finalizar_compra.Location = new Point(581, 302);
            btn_finalizar_compra.Name = "btn_finalizar_compra";
            btn_finalizar_compra.Size = new Size(387, 38);
            btn_finalizar_compra.TabIndex = 103;
            btn_finalizar_compra.Text = "COBRAR";
            btn_finalizar_compra.UseVisualStyleBackColor = false;
            btn_finalizar_compra.Click += btn_finalizar_compra_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(743, 382);
            button1.Name = "button1";
            button1.Size = new Size(249, 38);
            button1.TabIndex = 104;
            button1.Text = "FINALIZAR COMPRA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1017, 575);
            Controls.Add(button1);
            Controls.Add(btn_finalizar_compra);
            Controls.Add(lbl_cambio_cliente);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txb_pago_cliente);
            Controls.Add(btn_pago_efectivo);
            Controls.Add(btn_pago_tarjeta);
            Controls.Add(lbl_total_a_pagar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txb_cantidad_productos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_mostrar_precio);
            Controls.Add(label4);
            Controls.Add(btn_agregar_a_lista);
            Controls.Add(dgv_compra);
            Controls.Add(btn_buscar_producto);
            Controls.Add(txb_producto_nombre_id);
            Controls.Add(pictureBox2);
            Controls.Add(dgv_existencia);
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
            ((System.ComponentModel.ISupportInitialize)dgv_existencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_compra).EndInit();
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
        private DataGridView dgv_existencia;
        private PictureBox pictureBox2;
        private TextBox txb_producto_nombre_id;
        private Button btn_buscar_producto;
        private DataGridView dgv_compra;
        private Button btn_agregar_a_lista;
        private Label label4;
        private Label lbl_mostrar_precio;
        private Label label2;
        private Label label3;
        private TextBox txb_cantidad_productos;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label lbl_total_a_pagar;
        private Button btn_pago_tarjeta;
        private Button btn_pago_efectivo;
        private TextBox txb_pago_cliente;
        private Label label8;
        private Label label9;
        private Label lbl_cambio_cliente;
        private Button btn_finalizar_compra;
        private Button button1;
    }
}