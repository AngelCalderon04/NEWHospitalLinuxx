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
using System.Threading;

namespace CapaPresentacion
{
    public partial class RegistrarDoctor : Form
    {
        public RegistrarDoctor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO:  Cierra el formulario
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: VALIDAR VACIOS (Revisar que todos los campos obligatorios estén llenos)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(cboEspecialidad.Text) ||
                string.IsNullOrWhiteSpace(txtExequatur.Text) ||
                string.IsNullOrWhiteSpace(txtTarifa.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Llene todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: VALIDAR FORMATO NUMERICO (Asegurar que la tarifa sea un número válido)
            decimal tarifaIngresada;
            if (!decimal.TryParse(txtTarifa.Text, out tarifaIngresada))
            {
                MessageBox.Show("La tarifa debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // INSTANCIAR LA CAPA DE DATOS
                CD_Doctor objDoctor = new CD_Doctor();

                // TODO: ENVIAR TODOS LOS DATOS (Llamada al método de registro con todos los parámetros)
                objDoctor.RegistrarDoctor(
                    txtNombre.Text.Trim(),
                    txtCedula.Text.Trim(),
                    txtTelefono.Text.Trim(), // Teléfono
                    txtEmail.Text.Trim(),    // Email
                    cboEspecialidad.Text,    // Especialidad
                    txtExequatur.Text.Trim(),// Exequátur
                    tarifaIngresada,         // Tarifa (decimal)
                    txtUsuario.Text.Trim(),  // Usuario para Login
                    txtClave.Text.Trim()     // Clave para Login
                );

                // TODO: MOSTRAR EXITO Y LIMPIAR
                MessageBox.Show("Doctor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception ex)
            {
                // TODO:MANEJO DE ERRORES GENERALES
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            //TODO:  Limpia todos los campos del formulario después de un registro exitoso
            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtExequatur.Clear();
            txtTarifa.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            cboEspecialidad.SelectedIndex = 0;
            txtNombre.Focus();
        }

        //  CAPTURADORES DE ERRORES Permite solo letras y espacios
        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras 
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    
        //TODO:  Permite solo numeros enteros
        
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos 
            if (!(char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
        //TODO:Permite numeros y un separador decimal
     
        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite digitos, retroceso
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un separador decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Asegura que solo se ingrese UN separador decimal
            if (e.KeyChar == System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0] && (sender as System.Windows.Forms.TextBox).Text.Contains(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}