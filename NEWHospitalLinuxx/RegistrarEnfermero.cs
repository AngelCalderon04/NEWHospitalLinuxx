using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RegistrarEnfermero : Form
    {
        public RegistrarEnfermero()
        {
            InitializeComponent();
        }

        private void RegistrarEnfermero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarEnfermero_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. VALIDAR
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
                // 2. GUARDAR
                CapaDatos.CD_Enfermero objetoEnfermero = new CapaDatos.CD_Enfermero();

                objetoEnfermero.RegistrarEnfermero(
                    txtNombre.Text.Trim(),
                  textcedula.Text.Trim(),
                    "", // Teléfono (Vacío si no está en el form)
                    "", // Email (Vacío si no está en el form)
                    cboTurno.Text,          // Turno (Del ComboBox)
                    cboArea.Text.Trim(),    // Área
                   textusuario.Text.Trim(), // Usuario para Login
                   textclave.Text.Trim()    // Clave para Login
                );

                MessageBox.Show("¡Enfermero y Usuario registrados con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
