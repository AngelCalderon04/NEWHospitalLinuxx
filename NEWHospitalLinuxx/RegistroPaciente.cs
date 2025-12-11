using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnGuargar_Click(object sender, EventArgs e)
        {
            try
            {
                //  Capturador de error
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("El Nombre y la Cédula son obligatorios.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                decimal peso = 0;
                decimal altura = 0;
                decimal.TryParse(txtPeso.Text, out peso);
                decimal.TryParse(txtAltura.Text, out altura);

                // llamamos a la capa Datos 
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


                MessageBox.Show("¡Paciente registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Aquí atrapamos el error si la cédula está repetida
                MessageBox.Show(ex.Message, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        //capturadores de errores 
        private void AsignarValidaciones()
        {
            this.txtNombre.KeyPress += new KeyPressEventHandler(SoloLetras_KeyPress);
            this.txtCedula.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            this.txtTelefono.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            this.txtSeguro.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            this.txtContactoEmergencia.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
            this.txtPeso.KeyPress += new KeyPressEventHandler(SoloDecimales_KeyPress);
            this.txtAltura.KeyPress += new KeyPressEventHandler(SoloDecimales_KeyPress);
        }


        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void SoloDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

       
    }
}
