using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class GestionCitas : Form
    {
        CD_Citas cdCitas = new CD_Citas();
        CD_Paciente cdPaciente = new CD_Paciente();

        private int idCitaSeleccionada = 0;

        public GestionCitas()
        {
            InitializeComponent();

            // Ocultamos barra desde el inicio
            progressBar1.Visible = false;

            this.Load += new EventHandler(GestionCitas_Load);
            btnAgendar.Click += new EventHandler(btnAgendar_Click);
            btnEditar.Click += new EventHandler(btnEditar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            cboDoctor.SelectedIndexChanged += new EventHandler(cboDoctor_SelectedIndexChanged);
            dgvCitas.CellClick += new DataGridViewCellEventHandler(dgvCitas_CellClick);
        }

        // ===========================
        //  MÉTODO: BARRA DE CARGA
        // ===========================
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30); // 30 ms × 100 = 3 segundos
            }

            progressBar1.Visible = false;
        }

        private void GestionCitas_Load(object sender, EventArgs e)
        {
            dgvCitas.AutoGenerateColumns = true;

            try
            {
                CargarCombos();
                CargarGrid();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // CARGAR DOCTORES / PACIENTES
        // ==============================
        private void CargarCombos()
        {
            try
            {
                DataTable dtDoc = new DataTable();
                ConexionDatos objConexion = new ConexionDatos();

                using (SqlConnection conn = objConexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql =
                    @"SELECT D.IDDoctor, P.Nombre, D.TarifaConsulta, D.Especialidad
                      FROM Doctor D
                      INNER JOIN Personas P ON D.IDPersona = P.IDPersona";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtDoc);
                }

                cboDoctor.DataSource = dtDoc;
                cboDoctor.DisplayMember = "Nombre";
                cboDoctor.ValueMember = "IDDoctor";
                cboDoctor.SelectedIndex = -1;

                // PACIENTES
                DataTable dtPac = cdPaciente.Listar();
                cboPaciente.DataSource = dtPac;
                cboPaciente.DisplayMember = "Nombre";
                cboPaciente.ValueMember = "IDPaciente";
                cboPaciente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        // ==============================
        //      CARGAR GRID
        // ==============================
        private void CargarGrid()
        {
            try
            {
                DataTable tabla = new DataTable();
                ConexionDatos objConexion = new ConexionDatos();

                using (SqlConnection conn = objConexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql =
                    @"SELECT 
                        ROW_NUMBER() OVER (ORDER BY C.IDCita ASC) AS NumeroOrden,
                        C.IDCita,
                        PerDoc.Nombre AS NombreDoctor,
                        PerPac.Nombre AS NombrePaciente,
                        C.FechaCita,
                        C.HoraCita,
                        D.TarifaConsulta AS Costo,
                        C.IDDoctor,
                        C.IDPaciente
                      FROM Citas C
                      INNER JOIN Doctor D ON C.IDDoctor = D.IDDoctor
                      INNER JOIN Personas PerDoc ON D.IDPersona = PerDoc.IDPersona
                      INNER JOIN Paciente P ON C.IDPaciente = P.IDPaciente
                      INNER JOIN Personas PerPac ON P.IDPersona = PerPac.IDPersona";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(tabla);
                }

                dgvCitas.DataSource = tabla;

                if (dgvCitas.Columns["IDCita"] != null)
                    dgvCitas.Columns["IDCita"].Visible = false;

                if (dgvCitas.Columns["IDDoctor"] != null)
                    dgvCitas.Columns["IDDoctor"].Visible = false;

                if (dgvCitas.Columns["IDPaciente"] != null)
                    dgvCitas.Columns["IDPaciente"].Visible = false;

                if (dgvCitas.Columns["NumeroOrden"] != null)
                {
                    dgvCitas.Columns["NumeroOrden"].HeaderText = "#";
                    dgvCitas.Columns["NumeroOrden"].Width = 40;
                }

                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Grid: " + ex.Message);
            }
        }

        // ==============================
        // MOSTRAR TARIFA Y ESPECIALIDAD
        // ==============================
        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoctor.SelectedIndex != -1 && cboDoctor.SelectedItem is DataRowView fila)
            {
                txtTarifa.Text = fila["TarifaConsulta"].ToString();
                txtEspecialidad.Text = fila["Especialidad"].ToString();
            }
            else
            {
                txtTarifa.Clear();
                txtEspecialidad.Clear();
            }
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // No hace nada (como en tu versión original)
        }

        // ==============================
        //     BOTÓN EDITAR
        // ==============================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow fila = dgvCitas.CurrentRow;

                    idCitaSeleccionada = Convert.ToInt32(fila.Cells["IDCita"].Value);

                    cboDoctor.SelectedValue = Convert.ToInt32(fila.Cells["IDDoctor"].Value);
                    cboPaciente.SelectedValue = Convert.ToInt32(fila.Cells["IDPaciente"].Value);

                    dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaCita"].Value);

                    TimeSpan hora = (TimeSpan)fila.Cells["HoraCita"].Value;
                    dtpHora.Value = DateTime.Today.Add(hora);

                    btnAgendar.Text = "GUARDAR CAMBIOS";
                    btnAgendar.BackColor = Color.Orange;

                    MessageBox.Show("Cita cargada. Realiza los cambios y pulsa 'AGENDAR'.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila primero.");
            }
        }

        // ==============================
        //      BOTÓN AGENDAR
        // ==============================
        private async void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cboDoctor.SelectedIndex == -1 || cboPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Doctor y Paciente.");
                return;
            }

            try
            {
                // ---------- APLICAR CARGA 3 SEG ----------
                await BarraDeCargaAsync();
                // ------------------------------------------

                if (idCitaSeleccionada == 0)
                {
                    cdCitas.AgendarCita(
                        Convert.ToInt32(cboPaciente.SelectedValue),
                        Convert.ToInt32(cboDoctor.SelectedValue),
                        dtpFecha.Value,
                        dtpHora.Value.TimeOfDay,
                        ""
                    );
                    MessageBox.Show("Cita creada con éxito.");
                }
                else
                {
                    cdCitas.EditarCita(
                        idCitaSeleccionada,
                        Convert.ToInt32(cboPaciente.SelectedValue),
                        Convert.ToInt32(cboDoctor.SelectedValue),
                        dtpFecha.Value,
                        dtpHora.Value.TimeOfDay
                    );
                    MessageBox.Show("Cita actualizada con éxito.");
                }

                LimpiarFormulario();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ==============================
        //      BOTÓN LIMPIAR
        // ==============================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            idCitaSeleccionada = 0;
            cboDoctor.SelectedIndex = -1;
            cboPaciente.SelectedIndex = -1;

            txtTarifa.Clear();
            txtEspecialidad.Clear();

            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

            btnAgendar.Text = "AGENDAR";
            btnAgendar.BackColor = Color.LightGreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}