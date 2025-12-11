using CapaDatos;

namespace NEWHospitalLinuxx
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: capturadores de errrores 
            if (string.IsNullOrWhiteSpace(textUsuario.Text) || string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // TODO: Llamar a CapaDatos
                CD_Usuario objetoUsuario = new CD_Usuario();

                bool accesoCorrecto = objetoUsuario.Login(textUsuario.Text, textClave.Text);

                if (accesoCorrecto == true)
                {
                    MessageBox.Show("¡Bienvenido al sistema!", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el Menu Principal
                    // FormPrincipal menu = new FormPrincipal();
                    //  menu.Show();

                    this.Hide(); // Ocultamos el login
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textClave.Clear();
                    textUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
