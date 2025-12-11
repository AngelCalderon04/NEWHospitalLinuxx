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
    public partial class RegistrarConsulta : Form
    {
        public RegistrarConsulta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: Validaciones, capturadores de errores 
            if (cboPaciente.SelectedValue == null || cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un paciente y un doctor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //TODO:  Obtener datos del formulario
            int idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);
            int idDoctor = Convert.ToInt32(cboDoctor.SelectedValue);
            string motivo = txtMotivo.Text.Trim();
            string diagnostico = txtDiagnostico.Text.Trim();
            string tratamiento = txtTratamiento.Text.Trim();
            string observaciones = txtObservaciones.Text.Trim();

            //TODO:Capturador de error 

            if (string.IsNullOrEmpty(motivo))
            {
                MessageBox.Show("Debe ingresar el motivo de la consulta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //TODO: Aqui llama de la capaDatos los query 
                CD_HistorialMedico gestor = new CD_HistorialMedico();


                gestor.RegistrarConsulta(
                    idPaciente,
                    idDoctor,
                    motivo,       // Esto corresponde a sintomas 
                    diagnostico,
                    tratamiento,
                    observaciones
                );

                MessageBox.Show("Consulta registrada correctamente en el historial.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la consulta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            cboPaciente.SelectedIndex = -1;
            cboDoctor.SelectedIndex = -1;
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtObservaciones.Clear();
        }
    }
    
}
