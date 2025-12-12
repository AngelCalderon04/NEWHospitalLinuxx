using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class RegistroPaciente : Form
    {
        public RegistroPaciente()
        {
            InitializeComponent();
            progressBar1.Visible = false; // Ocultar barra al inicio
        }

        // ============================================================
        //     MÉTODO ASÍNCRONO DE BARRA DE PROGRESO (3 SEGUNDOS)
        // ============================================================
        private async Task BarraProgresoAsync()
        {
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30);   // 100 * 30ms ≈ 3 segundos
            }

            progressBar1.Visible = false;
        }

        // ============================================================
        //                 BOTÓN GUARDAR PACIENTE
        // ============================================================
        private async void btnGuargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("El Nombre y la Cédula son obligatorios.",
                        "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ejecutar barra de progreso
                await BarraProgresoAsync();

                // Conversión segura
                decimal.TryParse(txtPeso.Text, out decimal peso);
                decimal.TryParse(txtAltura.Text, out decimal altura);

                // Guardar en BD
                CD_Paciente gestor = new CD_Paciente();

                gestor.RegistrarPaciente(
                    txtNombre.Text,
                    txtCedula.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    dtpFecha.Value,
                    cbosanguineo.Text,
                    txtAlergias.Text,
                    txtSeguro.Text,
                    txtContactoEmergencia.Text,
                    peso == 0 ? (decimal?)null : peso,
                    altura == 0 ? (decimal?)null : altura
                );

                MessageBox.Show("¡Paciente registrado correctamente!",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        //                    LIMPIAR CAMPOS
        // ============================================================
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtAlergias.Clear();
            txtSeguro.Clear();
            txtContactoEmergencia.Clear();
            txtPeso.Clear();
            txtAltura.Clear();

            if (cbosanguineo.Items.Count > 0)
                cbosanguineo.SelectedIndex = 0;

            dtpFecha.Value = DateTime.Now;
            txtNombre.Focus();
        }

        // ============================================================
        //              VALIDACIONES DE CAMPOS
        // ============================================================
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evitar 2 puntos decimales
            if (e.KeyChar == '.' &&
                (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // ============================================================
        //                 BOTÓN CERRAR
        // ============================================================
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================================================
        //                 BOTÓN LIMPIAR
        // ============================================================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ============================================================
        //     PANEL (VACÍO PERO NECESARIO PARA EL DESIGNER)
        // ============================================================
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}