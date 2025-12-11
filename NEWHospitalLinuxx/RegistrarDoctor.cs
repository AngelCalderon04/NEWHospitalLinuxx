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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: VALIDAR VACIOS (Agregamos Usuario y Clave a la validaciOn)
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

            // 2. VALIDAR TARIFA NUMÉRICA
            decimal tarifaIngresada;
            if (!decimal.TryParse(txtTarifa.Text, out tarifaIngresada))
            {
                MessageBox.Show("La tarifa debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CD_Doctor objDoctor = new CD_Doctor();

                // TODO: ENVIAR LOS 9 DATOS (Aquí estaba el error)
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

                MessageBox.Show("Doctor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
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
            cboEspecialidad.SelectedIndex = 0;
            txtNombre.Focus();
        }
    }

}

