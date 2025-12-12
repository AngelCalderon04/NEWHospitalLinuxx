using CapaDatos;
using CapaPresentacion;

namespace NEWHospitalLinuxx
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            progressBar1.Visible = false; // se oculta al iniciar
        }

        // MÉTODO ASÍNCRONO PARA 3 SEGUNDOS DE CARGA
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30);  // 30ms * 100 ≈ 3 segundos
            }

            progressBar1.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // TODO: capturadores de errrores 
            if (string.IsNullOrWhiteSpace(textUsuario.Text) || string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ======= BARRA DE CARGA 3 SEGUNDOS =========
                await BarraDeCargaAsync();
                // ============================================

                // TODO: Llamar a CapaDatos
                CD_Usuario objetoUsuario = new CD_Usuario();

                bool accesoCorrecto = objetoUsuario.Login(textUsuario.Text, textClave.Text);

                if (accesoCorrecto == true)
                {
                    MessageBox.Show("¡Bienvenido al sistema!", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el Menu Principal
                    Principal menu = new Principal();
                    menu.Show();

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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}