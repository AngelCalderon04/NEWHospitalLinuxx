using System;
using System.Drawing; // Para los colores bonitos
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class VerDoctores : Form
    {
        CD_Doctor cdDoctor = new CD_Doctor();

        public VerDoctores()
        {
            InitializeComponent();
            this.Load += new EventHandler(VerDoctores_Load);
            btnSalir.Click += new EventHandler(btnSalir_Click);
        }

        private void VerDoctores_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            // Estilo "Base de Datos Bonita"
            dgvDoctores.AutoGenerateColumns = true;
            dgvDoctores.ReadOnly = true;
            dgvDoctores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctores.AllowUserToAddRows = false;
            dgvDoctores.RowHeadersVisible = false;
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Colores alternos (Cebra) para lectura fácil
            dgvDoctores.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvDoctores.EnableHeadersVisualStyles = false;
            dgvDoctores.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvDoctores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDoctores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void CargarDatos()
        {
            try
            {
                // Usamos el método ListarDirectorioDoctores (que ya creamos antes)
                dgvDoctores.DataSource = cdDoctor.ListarDirectorioDoctores();

                // Formato de moneda para la tarifa
                if (dgvDoctores.Columns.Contains("Tarifa"))
                    dgvDoctores.Columns["Tarifa"].DefaultCellStyle.Format = "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar doctores: " + ex.Message);
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