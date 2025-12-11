using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class RegistrarConsulta : Form
    {
        // 1. INSTANCIAS NECESARIAS PARA LLENAR LOS COMBOS
        CD_Paciente cdPaciente = new CD_Paciente();
        CD_Doctor cdDoctor = new CD_Doctor();
        CD_HistorialMedico cdHistorial = new CD_HistorialMedico();

        public RegistrarConsulta()
        {
            InitializeComponent();

            // 2. CONECTAR EL EVENTO LOAD MANUALMENTE
            // Esto asegura que los datos carguen al abrir la ventana
            this.Load += new EventHandler(RegistrarConsulta_Load);
        }

        // 3. EVENTO QUE SE EJECUTA AL ABRIR EL FORMULARIO
        private void RegistrarConsulta_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        // 4. MÉTODO PARA LLENAR LAS LISTAS
        private void CargarCombos()
        {
            try
            {
                // Cargar Pacientes
                DataTable dtPac = cdPaciente.Listar();
                cboPaciente.DataSource = dtPac;
                cboPaciente.DisplayMember = "Nombre";       // Lo que se ve
                cboPaciente.ValueMember = "IDPaciente";     // El valor oculto (ID)
                cboPaciente.SelectedIndex = -1;             // Iniciar vacío

                // Cargar Doctores
                DataTable dtDoc = cdDoctor.ListarDoctoresParaCombo();
                cboDoctor.DataSource = dtDoc;
                cboDoctor.DisplayMember = "Nombre";
                cboDoctor.ValueMember = "IDDoctor";
                cboDoctor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cboPaciente.SelectedIndex == -1 || cboDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un paciente y un doctor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string motivo = txtMotivo.Text.Trim();
            if (string.IsNullOrEmpty(motivo))
            {
                MessageBox.Show("Debe ingresar el motivo de la consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos
            // Usamos Try-Catch para evitar que el programa se cierre si el ID no es válido
            try
            {
                int idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);
                int idDoctor = Convert.ToInt32(cboDoctor.SelectedValue);
                string diagnostico = txtDiagnostico.Text.Trim();
                string tratamiento = txtTratamiento.Text.Trim();
                string observaciones = txtObservaciones.Text.Trim();

                // Llama a la capa de datos (CORREGIDO: RegistrarHistorial)
                cdHistorial.RegistrarHistorial(
                    idPaciente,
                    idDoctor,
                    motivo,       // Se envía como 'síntomas' o motivo
                    diagnostico,
                    tratamiento,
                    observaciones
                );

                MessageBox.Show("Consulta registrada correctamente en el historial.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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