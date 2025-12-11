using System;
using System.Windows.Forms;
using CapaDatos;
using System.Globalization; // TD: NECESARIO para obtener el separador decimal correcto

namespace CapaPresentacion
{
    // TD: Clase principal del formulario de registro de administrativos
    public partial class FormPersonalAdministrativo : Form
    {
        public FormPersonalAdministrativo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // TD: Cierra el formulario al pulsar Salir
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: VALIDAR VACIOS 
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                // string.IsNullOrWhiteSpace(textTelefono.Text) ||
                //string.IsNullOrWhiteSpace(textEmail.Text) ||
                string.IsNullOrWhiteSpace(textSalario.Text) ||
                string.IsNullOrWhiteSpace(textUsuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text) ||
                string.IsNullOrWhiteSpace(comboDepartamento.Text) ||
                string.IsNullOrWhiteSpace(comboCargo.Text))
            {
                MessageBox.Show("Llene todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: VALIDAR SALARIO NUMERICO 
            decimal salarioIngresado;
            if (!decimal.TryParse(textSalario.Text, out salarioIngresado))
            {
                MessageBox.Show("El salario debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // TD: INSTANCIAR LA CAPA DE DATOS DEL ADMINISTRATIVO
                CD_PersonalAdministrativo objAdmin = new CD_PersonalAdministrativo();

                // TODO: LLAMADA A REGISTRAR
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

                // TD: MOSTRAR EXITO Y LIMPIAR
                MessageBox.Show("Administrativo registrado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // TD: MANEJO DE ERRORES GENERALES
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TD: METODO DE LIMPIEZA
        private void LimpiarCampos()
        {
            // TD: Limpia todos los campos del formulario
            textNombre.Clear();
            textCedula.Clear();
            //  textTelefono.Clear();
            //  textEmail.Clear();
            textSalario.Clear();
            textUsuario.Clear();
            textClave.Clear();

            // TD: Intentamos deseleccionar el ComboBox, usando -1 para evitar errores si no hay items.
            if (comboDepartamento.Items.Count > 0) comboDepartamento.SelectedIndex = -1;
            if (comboCargo.Items.Count > 0) comboCargo.SelectedIndex = -1;

            textNombre.Focus();
        }

        // =======================================================================
        // TD: METODOS PARA VALIDACION DE ENTRADA POR TECLA (KEYPRESS)
        // =======================================================================

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TD: Permite solo letras y espacios en el nombre
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TD: Permite solo digitos. Usado para Cedula y Telefono
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // TD: METODO REVISADO PARA SALARIO/DECIMALES
        private void textSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TD: Usamos la cultura del sistema para determinar el separador (punto o coma)
            char decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            TextBox currentTextBox = sender as TextBox;

            // 1. Permite dígitos, retroceso, y el separador decimal.
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == decimalSeparator) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y el separador decimal correcto (" + decimalSeparator + ").", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 2. Asegura que solo se ingrese UN separador decimal
            if (e.KeyChar == decimalSeparator && currentTextBox.Text.Contains(decimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}