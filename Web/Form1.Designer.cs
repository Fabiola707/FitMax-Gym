namespace Web
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_inicio_sesion = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txb_contraseña = new TextBox();
            txb_usuario = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_inicio_sesion
            // 
            btn_inicio_sesion.BackColor = Color.Red;
            btn_inicio_sesion.FlatAppearance.BorderSize = 0;
            btn_inicio_sesion.FlatStyle = FlatStyle.Flat;
            btn_inicio_sesion.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inicio_sesion.ForeColor = Color.WhiteSmoke;
            btn_inicio_sesion.Location = new Point(440, 354);
            btn_inicio_sesion.Name = "btn_inicio_sesion";
            btn_inicio_sesion.Size = new Size(169, 38);
            btn_inicio_sesion.TabIndex = 0;
            btn_inicio_sesion.Text = "INICIAR SESIÓN ";
            btn_inicio_sesion.UseVisualStyleBackColor = false;
            btn_inicio_sesion.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Image = Properties.Resources.BG5;
            label1.Location = new Point(440, 237);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Image = Properties.Resources.BG5;
            label2.Location = new Point(440, 295);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 3;
            label2.Text = "PASWORD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Image = Properties.Resources.BG5;
            label3.Location = new Point(470, 190);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 4;
            label3.Text = "FITMAX GYM";
            label3.Click += label3_Click;
            // 
            // txb_contraseña
            // 
            txb_contraseña.BackColor = Color.Black;
            txb_contraseña.BorderStyle = BorderStyle.FixedSingle;
            txb_contraseña.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_contraseña.ForeColor = SystemColors.ButtonHighlight;
            txb_contraseña.Location = new Point(440, 315);
            txb_contraseña.Name = "txb_contraseña";
            txb_contraseña.Size = new Size(169, 25);
            txb_contraseña.TabIndex = 5;
            // 
            // txb_usuario
            // 
            txb_usuario.BackColor = Color.Black;
            txb_usuario.BorderStyle = BorderStyle.FixedSingle;
            txb_usuario.Font = new Font("Agency FB", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb_usuario.ForeColor = SystemColors.ButtonHighlight;
            txb_usuario.Location = new Point(440, 257);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(169, 25);
            txb_usuario.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.BackgroundImage = Properties.Resources.BG7;
            pictureBox1.Location = new Point(400, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 331);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1068, 557);
            Controls.Add(txb_usuario);
            Controls.Add(txb_contraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_inicio_sesion);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_inicio_sesion;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txb_contraseña;
        private TextBox txb_usuario;
        private PictureBox pictureBox1;
    }
}
