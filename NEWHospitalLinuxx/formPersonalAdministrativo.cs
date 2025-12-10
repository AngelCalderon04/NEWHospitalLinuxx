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
        {// 1. VALIDACIONES
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCedula.Text) ||
                string.IsNullOrWhiteSpace(combocargo.Text) ||
                string.IsNullOrWhiteSpace(comboDepartamento.Text) ||
                string.IsNullOrWhiteSpace(textUsuario.Text) ||
                string.IsNullOrWhiteSpace(textClave.Text))
            {
                MessageBox.Show("Por favor, llene los campos obligatorios.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. LLAMADA A LA CAPA DE DATOS
                CD_PersonalAdministrativo objetoAdmin = new CD_PersonalAdministrativo();

                objetoAdmin.RegistrarPersonal(
                    textNombre.Text.Trim(),
                    textCedula.Text.Trim(),
                    textTelefono.Text.Trim(),   // <--- AQUÍ AGREGAMOS EL TELÉFONO
                    textEmail.Text.Trim(),      // <--- AQUÍ AGREGAMOS EL EMAIL
                    comboDepartamento.Text,
                    combocargo.Text,
                    textUsuario.Text.Trim(),
                    textClave.Text.Trim()
                );

                MessageBox.Show("¡Personal registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textCedula.Clear();
            textTelefono.Clear(); // <--- Limpiar Teléfono
            textEmail.Clear();    // <--- Limpiar Email
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
    
