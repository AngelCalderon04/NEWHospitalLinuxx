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
            // TODO: VALIDACION DE CAMPOS OBLIGATORIOS
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
                //TODO: GUARDAR
                CD_Enfermero objetoEnfermero = new CD_Enfermero();

                objetoEnfermero.RegistrarEnfermero(
                    txtNombre.Text.Trim(),
                    textcedula.Text.Trim(),
                    "", // Telefono 
                    "", // Email 
                    cboTurno.Text,     // Turno (Del ComboBox)
                    cboArea.Text.Trim(),   // Área
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

     

    
        // TODO: CAPTURADORES DE ERRORES Permite solo letras y espacios en el campo de Nombre
        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //TODO: Permite solo números en el campo de Cédula
       
        private void textcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO:  Permite solo dígitos  numericos 
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en la cédula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}