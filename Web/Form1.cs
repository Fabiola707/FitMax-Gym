using MySql.Data.MySqlClient;
namespace Web
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Server=localhost;Port=3307;Database=FitMaxDB;Uid=root;Pwd=;paola05";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txb_usuario.Text.Trim(); ;
            string password = txb_contraseña.Text.Trim(); ;

            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingresa tu usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Consulta a la base de datos de manera segura usando parámetros
            string query = "SELECT COUNT(*) FROM usuarios WHERE username = @usuario AND password = @password";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Pasamos los parámetros para evitar inyecciones SQL
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@password", password); // Nota: Idealmente la contraseña debería estar cifrada (ej. SHA256 o BCrypt)

                        // Ejecutamos la consulta
                        int resultado = Convert.ToInt32(comando.ExecuteScalar());

                        if (resultado > 0)
                        {
                            MessageBox.Show("¡Bienvenido a FitMax Gym!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Aquí abres tu formulario principal del sistema:
                            Form2 form2 = new Form2();
                            this.Hide();
                            form2.Show();

                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txb_contraseña.Clear();
                            txb_contraseña.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //no necesario modificar
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no necesario modificar....
        }

        private void txb_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
