using CapaDatos;
using System;
using System.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistrarDoctor : Form
    {
        public RegistrarDoctor()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        // ===========================
        //     BARRA DE PROGRESO
        // ===========================
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(20);
            }

            progressBar1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        // ===========================
        //      BOTÓN SALIR
        // ===========================
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===========================
        //     BOTÓN GUARDAR
        // ===========================
        private async void button1_Click(object sender, EventArgs e)
        {
            // VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(cboEspecialidad.Text) ||
                string.IsNullOrWhiteSpace(txtExequatur.Text) ||
                string.IsNullOrWhiteSpace(txtTarifa.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Llene todos los campos obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDACIÓN DECIMAL
            decimal tarifaIngresada;
            if (!decimal.TryParse(txtTarifa.Text, out tarifaIngresada))
            {
                MessageBox.Show("La tarifa debe ser un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await BarraDeCargaAsync();

                CD_Doctor objDoctor = new CD_Doctor();
                objDoctor.RegistrarDoctor(
                    txtNombre.Text.Trim(),
                    txtCedula.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtEmail.Text.Trim(),
                    cboEspecialidad.Text,
                    txtExequatur.Text.Trim(),
                    tarifaIngresada,
                    txtUsuario.Text.Trim(),
                    txtClave.Text.Trim()
                );

                MessageBox.Show("Doctor registrado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ===========================
        //      MÉTODO LIMPIAR
        // ===========================
        private void Limpiar()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtExequatur.Clear();
            txtTarifa.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            cboEspecialidad.SelectedIndex = -1;

            txtNombre.Focus();
        }

        // ===========================
        // VALIDACIÓN LETRAS
        // ===========================
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ===========================
        // VALIDACIÓN NÚMEROS
        // ===========================
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // ===========================
        // VALIDACIÓN DECIMAL
        // ===========================
        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = CultureInfo.CurrentCulture
                .NumberFormat.NumberDecimalSeparator[0];

            TextBox txt = sender as TextBox;

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == decimalSeparator) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo números y un separador decimal.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (e.KeyChar == decimalSeparator && txt.Text.Contains(decimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
