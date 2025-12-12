using CapaDatos;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistrarEnfermero : Form
    {
        public RegistrarEnfermero()
        {
            InitializeComponent();
            progressBar1.Visible = false; // Ocultar al iniciar
        }

        // BARRA DE CARGA (3s aprox.)
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30);
            }

            progressBar1.Visible = false;
        }

        // Evento Load (coincide con el Designer)
        private void RegistrarEnfermero_Load(object sender, EventArgs e)
        {
            // Si quieres inicializar cosas al cargar, aquí.
        }

        // BOTÓN GUARDAR (coincide con Designer: button1)
        private async void button1_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(textcedula.Text) ||
                string.IsNullOrWhiteSpace(cboTurno.Text) ||
                string.IsNullOrWhiteSpace(cboArea.Text) ||
                string.IsNullOrWhiteSpace(textusuario.Text) ||
                string.IsNullOrWhiteSpace(textclave.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Mostrar progreso antes de guardar
                await BarraDeCargaAsync();

                // Guardar
                CD_Enfermero objetoEnfermero = new CD_Enfermero();
                objetoEnfermero.RegistrarEnfermero(
                    txtNombre.Text.Trim(),
                    textcedula.Text.Trim(),
                    "", // telefono
                    "", // email
                    cboTurno.Text,
                    cboArea.Text.Trim(),
                    textusuario.Text.Trim(),
                    textclave.Text.Trim()
                );

                MessageBox.Show("¡Enfermero registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN SALIR (coincide con Designer: button2)
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // LIMPIAR
        private void Limpiar()
        {
            txtNombre.Clear();
            textcedula.Clear();
            textusuario.Clear();
            textclave.Clear();
            cboTurno.SelectedIndex = -1;
            cboArea.SelectedIndex = -1;
            txtNombre.Focus();
        }

        // VALIDACIONES KeyPress (nombres coinciden con Designer)
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                // Sin MessageBox en cada pulsación para no molestar; descomenta si prefieres aviso
                // MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                // MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}