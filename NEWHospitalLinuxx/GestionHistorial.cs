using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class GestionHistorial : Form
    {
        CD_HistorialMedico cdHistorial = new CD_HistorialMedico();
        CD_Paciente cdPaciente = new CD_Paciente();
        private DataTable dtHistorialCompleto = new DataTable();

        public GestionHistorial()
        {
            InitializeComponent();
            this.Load += new EventHandler(GestionHistorial_Load);
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            btnSalir.Click += new EventHandler(btnSalir_Click);
        }

        private void GestionHistorial_Load(object sender, EventArgs e)
        {
            // Configuración visual para que se vea profesional
            dgvHistorial.AutoGenerateColumns = true;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.RowHeadersVisible = false; // Oculta el margen izquierdo feo

            try
            {
                CargarComboPacientes();
                CargarHistorialCompleto();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void CargarComboPacientes()
        {
            try
            {
                DataTable dtPac = cdPaciente.Listar();
                cboPaciente.DataSource = dtPac;
                cboPaciente.DisplayMember = "Nombre";
                cboPaciente.ValueMember = "IDPaciente";
                cboPaciente.SelectedIndex = -1;
            }
            catch { }
        }

        private void CargarHistorialCompleto()
        {
            try
            {
                dtHistorialCompleto = cdHistorial.ListarHistorialDetallado();
                dgvHistorial.DataSource = dtHistorialCompleto;

                // 1. Ocultar IDs
                OcultarColumna("IDHistorialMED");
                OcultarColumna("IDPaciente");

                // 2. Formato de Títulos (Aquí agregamos lo nuevo)
                ConfigurarColumna("Paciente", "Paciente", 150);
                ConfigurarColumna("Cedula", "Cédula", 100);
                ConfigurarColumna("Sangre", "Sangre", 50);
                ConfigurarColumna("Seguro", "Seguro Médico", 100); // Nuevo
                ConfigurarColumna("Peso", "Peso (lb)", 60);        // Nuevo
                ConfigurarColumna("Altura", "Altura (m)", 60);     // Nuevo

                ConfigurarColumna("Fecha", "Fecha", 80);
                ConfigurarColumna("Doctor", "Dr. Atiende", 120);
                ConfigurarColumna("Diagnostico", "Diagnóstico", 150);

                dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show("Error tabla: " + ex.Message); }
        }

        // Métodos auxiliares para ahorrar código repetitivo
        private void OcultarColumna(string nombre)
        {
            if (dgvHistorial.Columns.Contains(nombre)) dgvHistorial.Columns[nombre].Visible = false;
        }

        private void ConfigurarColumna(string nombreBD, string titulo, int ancho)
        {
            if (dgvHistorial.Columns.Contains(nombreBD))
            {
                dgvHistorial.Columns[nombreBD].HeaderText = titulo;
                dgvHistorial.Columns[nombreBD].MinimumWidth = ancho;
                // Si quieres un ancho fijo descomenta esto, si no, usa AutoSize
                // dgvHistorial.Columns[nombreBD].Width = ancho; 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboPaciente.SelectedIndex == -1)
            {
                dgvHistorial.DataSource = dtHistorialCompleto;
                return;
            }

            try
            {
                int idBusqueda = Convert.ToInt32(cboPaciente.SelectedValue);
                DataView vista = new DataView(dtHistorialCompleto);
                vista.RowFilter = "IDPaciente = " + idBusqueda;
                dgvHistorial.DataSource = vista;

                if (vista.Count == 0) MessageBox.Show("Este paciente no tiene historial.");
            }
            catch (Exception ex) { MessageBox.Show("Error buscar: " + ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}