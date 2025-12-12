using CapaDatos;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            progressBar1.Visible = false; // Ocultar al iniciar

            // 2. CONECTAR EL EVENTO LOAD MANUALMENTE
            this.Load += new EventHandler(RegistrarConsulta_Load);
        }

        // MÉTODO ASÍNCRONO PARA 3 SEGUNDOS
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30); // 30ms * 100 = 3 segundos
            }

            progressBar1.Visible = false;
        }

        // EVENTO LOAD
        private void RegistrarConsulta_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        // MÉTODO CARGAR COMBOS
        private void CargarCombos()
        {
            try
            {
                DataTable dtPac = cdPaciente.Listar();
                cboPaciente.DataSource = dtPac;
                cboPaciente.DisplayMember = "Nombre";
                cboPaciente.ValueMember = "IDPaciente";
                cboPaciente.SelectedIndex = -1;

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

        private async void btnGuardar_Click(object sender, EventArgs e)
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

            string Diagnostico = txtDiagnostico.Text.Trim();
            if (string.IsNullOrEmpty(Diagnostico))
            {
                MessageBox.Show("Debe ingresar el Diagnostico de la consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string observacioness = lblObservaciones.Text.Trim();
            if (string.IsNullOrEmpty(observacioness))
            {
                MessageBox.Show("Debe ingresar las Observaciones de la consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Tratamiento = lblTratamiento.Text.Trim();
            if (string.IsNullOrEmpty(Tratamiento))
            {
                MessageBox.Show("Debe ingresar el tratamiento de la consulta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ===== APLICAR BARRA DE CARGA DE 3 SEGUNDOS =====
                await BarraDeCargaAsync();
                // =================================================

                int idPaciente = Convert.ToInt32(cboPaciente.SelectedValue);
                int idDoctor = Convert.ToInt32(cboDoctor.SelectedValue);
                string diagnostico = txtDiagnostico.Text.Trim();
                string tratamiento = txtTratamiento.Text.Trim();
                string observaciones = txtObservaciones.Text.Trim();

                cdHistorial.RegistrarHistorial(
                    idPaciente,
                    idDoctor,
                    motivo,
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}