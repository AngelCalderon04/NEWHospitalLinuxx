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
    public partial class formPersonalAdministrativo : Form
    {
        public formPersonalAdministrativo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: validamos que no haya vacios
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                string.IsNullOrWhiteSpace(textSalario.Text) ||
                string.IsNullOrWhiteSpace(textUsuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Llene los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: convertimos el texto del salario a numero
            decimal salarioIngresado;
            if (!decimal.TryParse(textSalario.Text, out salarioIngresado))
            {
                MessageBox.Show("El salario debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CD_PersonalAdministrativo objetoAdmin = new CD_PersonalAdministrativo();

                // TODO: aqui estaba el error, asegurate de enviar los 9 datos en este orden
                objetoAdmin.RegistrarPersonal(
                    textNombre.Text.Trim(),      // 1. nombre
                    textCedula.Text.Trim(),      // 2. cedula
                    textTelefono.Text.Trim(),    // 3. telefono
                    textEmail.Text.Trim(),       // 4. email
                    comboDepartamento.Text,       // 5. departamento
                    combocargo.Text,              // 6. cargo
                    salarioIngresado,           // 7. salario (decimal)
                    textUsuario.Text.Trim(),     // 8. usuario
                    textClave.Text.Trim()        // 9. clave (esta era la que faltaba)
                );

                MessageBox.Show("Personal registrado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textCedula.Clear();
            textTelefono.Clear();
            textEmail.Clear();    
            textUsuario.Clear();
            textClave.Clear();

            if (combocargo.Items.Count > 0) combocargo.SelectedIndex = 0;
            if (comboDepartamento.Items.Count > 0) comboDepartamento.SelectedIndex = 0;

            textNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
