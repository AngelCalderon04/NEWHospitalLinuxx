using CapaDatos;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPersonalAdministrativo : Form
    {
        public FormPersonalAdministrativo()
        {
            InitializeComponent();

            progressBar1.Visible = false; // Oculta la barra de carga al iniciar
        }

        // MÉTODO ASÍNCRONO DE ESPERA (3 segundos)
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30); // 30ms * 100 = 3 segundos
            }

            progressBar1.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES ORIGINALES
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                string.IsNullOrWhiteSpace(textSalario.Text) ||
                string.IsNullOrWhiteSpace(textUsuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text) ||
                string.IsNullOrWhiteSpace(comboDepartamento.Text) ||
                string.IsNullOrWhiteSpace(comboCargo.Text))
            {
                MessageBox.Show("Llene todos los campos obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salarioIngresado;
            if (!decimal.TryParse(textSalario.Text, out salarioIngresado))
            {
                MessageBox.Show("El salario debe ser un numero valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // ========= APLICAR BARRA DE CARGA =========
                await BarraDeCargaAsync();
                // ===========================================

                CD_PersonalAdministrativo objAdmin = new CD_PersonalAdministrativo();

                objAdmin.RegistrarPersonal(
                    textNombre.Text.Trim(),
                    textCedula.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtEmail.Text.Trim(),
                    comboDepartamento.Text.Trim(),
                    comboCargo.Text.Trim(),
                    salarioIngresado,
                    textUsuario.Text.Trim(),
                    textClave.Text.Trim()
                );

                MessageBox.Show("Administrativo registrado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textCedula.Clear();
            textSalario.Clear();
            textUsuario.Clear();
            textClave.Clear();

            if (comboDepartamento.Items.Count > 0)
                comboDepartamento.SelectedIndex = -1;

            if (comboCargo.Items.Count > 0)
                comboCargo.SelectedIndex = -1;

            textNombre.Focus();
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = CultureInfo.CurrentCulture
                .NumberFormat.NumberDecimalSeparator[0];

            // 🔥 AQUÍ SE CORRIGE LA AMBIGÜEDAD
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == decimalSeparator) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show(
                    "Solo números y el separador decimal (" + decimalSeparator + ").",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                return;
            }

            if (e.KeyChar == decimalSeparator && txt.Text.Contains(decimalSeparator))
            {
                e.Handled = true;
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