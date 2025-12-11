using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class VerEnfermeros : Form
    {
        CD_Enfermero cdEnfermero = new CD_Enfermero();

        public VerEnfermeros()
        {
            InitializeComponent();
            this.Load += new EventHandler(VerEnfermeros_Load);
            btnSalir.Click += new EventHandler(btnSalir_Click);
        }

        private void VerEnfermeros_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dgvEnfermeros.AutoGenerateColumns = true;
            dgvEnfermeros.ReadOnly = true;
            dgvEnfermeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnfermeros.AllowUserToAddRows = false;
            dgvEnfermeros.RowHeadersVisible = false;
            dgvEnfermeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo visual
            dgvEnfermeros.AlternatingRowsDefaultCellStyle.BackColor = Color.MintCream; // Un verde muy suave
            dgvEnfermeros.EnableHeadersVisualStyles = false;
            dgvEnfermeros.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvEnfermeros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEnfermeros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void CargarDatos()
        {
            try
            {
                // Usamos el método ListarDirectorioEnfermeros (del código unificado)
                dgvEnfermeros.DataSource = cdEnfermero.ListarDirectorioEnfermeros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar enfermeros: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}