namespace Web
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            btnAbrirRegistros = new Button();
            pictureBox1 = new PictureBox();
            btn_regresar_panel_principal = new Button();
            pictureBox7 = new PictureBox();
            btnAbrir = new Button();
            btnGuardar = new Button();
            label14 = new Label();
            btn_inicio = new Button();
            btn_db_empleados = new Button();
            btn_clientes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // btnAbrirRegistros
            // 
            btnAbrirRegistros.BackColor = Color.FromArgb(192, 0, 0);
            btnAbrirRegistros.FlatAppearance.BorderSize = 0;
            btnAbrirRegistros.FlatStyle = FlatStyle.Flat;
            btnAbrirRegistros.Font = new Font("Agency FB", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirRegistros.ForeColor = SystemColors.ButtonHighlight;
            btnAbrirRegistros.Location = new Point(785, 500);
            btnAbrirRegistros.Name = "btnAbrirRegistros";
            btnAbrirRegistros.Size = new Size(197, 51);
            btnAbrirRegistros.TabIndex = 0;
            btnAbrirRegistros.Text = "ERRORES";
            btnAbrirRegistros.UseVisualStyleBackColor = false;
            btnAbrirRegistros.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.BackgroundImage = Properties.Resources.BG4;
            pictureBox1.Location = new Point(-4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 574);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_regresar_panel_principal
            // 
            btn_regresar_panel_principal.BackColor = Color.Red;
            btn_regresar_panel_principal.FlatAppearance.BorderSize = 0;
            btn_regresar_panel_principal.FlatStyle = FlatStyle.Popup;
            btn_regresar_panel_principal.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresar_panel_principal.ForeColor = SystemColors.ButtonHighlight;
            btn_regresar_panel_principal.Location = new Point(12, 500);
            btn_regresar_panel_principal.Name = "btn_regresar_panel_principal";
            btn_regresar_panel_principal.Size = new Size(134, 38);
            btn_regresar_panel_principal.TabIndex = 26;
            btn_regresar_panel_principal.Text = "REGRESAR";
            btn_regresar_panel_principal.UseVisualStyleBackColor = false;
            btn_regresar_panel_principal.Click += btn_cerrar_sesion_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Location = new Point(21, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(110, 100);
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.Red;
            btnAbrir.FlatAppearance.BorderSize = 0;
            btnAbrir.FlatStyle = FlatStyle.Flat;
            btnAbrir.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrir.ForeColor = SystemColors.ButtonHighlight;
            btnAbrir.Location = new Point(219, 67);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(204, 57);
            btnAbrir.TabIndex = 28;
            btnAbrir.Text = "ABRIR";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += button2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(467, 67);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 57);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(64, 64, 64);
            label14.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Image = Properties.Resources.BG4;
            label14.Location = new Point(21, 115);
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
            btn_inicio.Location = new Point(-4, 210);
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
            btn_db_empleados.Location = new Point(-4, 243);
            btn_db_empleados.Margin = new Padding(3, 2, 3, 2);
            btn_db_empleados.Name = "btn_db_empleados";
            btn_db_empleados.Size = new Size(161, 28);
            btn_db_empleados.TabIndex = 76;
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
            btn_clientes.Location = new Point(-4, 276);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(161, 28);
            btn_clientes.TabIndex = 78;
            btn_clientes.Text = "CLIENTES";
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1014, 575);
            Controls.Add(btn_clientes);
            Controls.Add(btn_db_empleados);
            Controls.Add(btn_inicio);
            Controls.Add(label14);
            Controls.Add(btnGuardar);
            Controls.Add(btnAbrir);
            Controls.Add(pictureBox7);
            Controls.Add(btn_regresar_panel_principal);
            Controls.Add(pictureBox1);
            Controls.Add(btnAbrirRegistros);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirRegistros;
        private PictureBox pictureBox1;
        private Button btn_regresar_panel_principal;
        private PictureBox pictureBox7;
        private Button btnAbrir;
        private Button btnGuardar;
        private Label label14;
        private Button btn_inicio;
        private Button btn_db_empleados;
        private Button btn_clientes;
    }
}