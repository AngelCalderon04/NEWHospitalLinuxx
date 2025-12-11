using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class GestionCitas : Form
    {
        CD_Citas cdCitas = new CD_Citas();
        CD_Doctor cdDoctor = new CD_Doctor(); // TODO: Lo dejamos instanciado por si acaso, aunque usaremos SQL directo para el combo
        CD_Paciente cdPaciente = new CD_Paciente();

        private int idCitaSeleccionada = 0;

        public GestionCitas()
        {
            InitializeComponent();

            // TODO: CONEXION MANUAL DE EVENTOS YA QUE EN PROPIEDADES NO QURIAN COLABORAR 
            this.Load += new EventHandler(GestionCitas_Load);
            btnAgendar.Click += new EventHandler(btnAgendar_Click);
            btnEditar.Click += new EventHandler(btnEditar_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);

            // TODO:Eventos de interacción
            cboDoctor.SelectedIndexChanged += new EventHandler(cboDoctor_SelectedIndexChanged);
            dgvCitas.CellClick += new DataGridViewCellEventHandler(dgvCitas_CellClick);
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // TODO: CARGA DE DATOS EN EL DATAGRI
        private void CargarCombos()
        {
            try
            {
                // TODO: CARGAR DOCTORES Con SQL directo para traer Especialidad DEL DOCTOR 
                DataTable dtDoc = new DataTable();
                ConexionDatos objConexion = new ConexionDatos();

                using (SqlConnection conn = objConexion.ObtenerConexion())
                {
                    conn.Open();
                    // TODO: Agregamos D.Especialidad a la consulta 
                    //Para que se vea mas cull y profesional 
                    string sql = @"SELECT D.IDDoctor, P.Nombre, D.TarifaConsulta, D.Especialidad 
                                   FROM Doctor D 
                                   INNER JOIN Personas P ON D.IDPersona = P.IDPersona";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtDoc);
                }

                if (dtDoc.Rows.Count > 0)
                {
                    cboDoctor.DataSource = dtDoc;
                    cboDoctor.DisplayMember = "Nombre";
                    cboDoctor.ValueMember = "IDDoctor";
                    cboDoctor.SelectedIndex = -1;
                }

                // TODO: CARGAR PACIENTES Este sigue igual usando CD porque no necesitamos extra data
                DataTable dtPac = cdPaciente.Listar();
                if (dtPac.Rows.Count > 0)
                {
                    cboPaciente.DataSource = dtPac;
                    cboPaciente.DisplayMember = "Nombre";
                    cboPaciente.ValueMember = "IDPaciente";
                    cboPaciente.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar combos: " + ex.Message); }
        }

        private void CargarGrid()
        {
            try
            {
                DataTable tabla = new DataTable();
                ConexionDatos objConexion = new ConexionDatos();
                using (SqlConnection conn = objConexion.ObtenerConexion())
                {
                    conn.Open();
                    // TRUCO: Usamos ROW_NUMBER() para generar un 1, 2, 3... falso pero bonito
                    string sql = @"SELECT 
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

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }

                dgvCitas.DataSource = null;
                dgvCitas.Columns.Clear();
                dgvCitas.DataSource = tabla;

                // TODO: OCULTAMOS EL ID REAL (El feo que salta números)
                if (dgvCitas.Columns["IDCita"] != null) dgvCitas.Columns["IDCita"].Visible = false;

                // OCULTAMOS IDs INTERNOS
                if (dgvCitas.Columns["IDDoctor"] != null) dgvCitas.Columns["IDDoctor"].Visible = false;
                if (dgvCitas.Columns["IDPaciente"] != null) dgvCitas.Columns["IDPaciente"].Visible = false;

                // CONFIGURAMOS EL NUMERO BONITO (El que acabamos de crear)
                if (dgvCitas.Columns["NumeroOrden"] != null)
                {
                    dgvCitas.Columns["NumeroOrden"].HeaderText = "#";
                    dgvCitas.Columns["NumeroOrden"].Width = 40; // Hacemos la columna pequeñita
                }

                // Resto de títulos
                if (dgvCitas.Columns["NombreDoctor"] != null) dgvCitas.Columns["NombreDoctor"].HeaderText = "Doctor";
                if (dgvCitas.Columns["NombrePaciente"] != null) dgvCitas.Columns["NombrePaciente"].HeaderText = "Paciente";

                dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { MessageBox.Show("Error Grid: " + ex.Message); }
        }


        // TODO: ESTO  LLENA LOS TEXBOX DE  TARIFA Y ESPECIALIDAD
        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoctor.SelectedIndex != -1 && cboDoctor.SelectedItem is DataRowView fila)
            {
                // Mostrar Tarifa
                if (fila.Row.Table.Columns.Contains("TarifaConsulta"))
                    txtTarifa.Text = fila["TarifaConsulta"].ToString();

                // Mostrar Especialidad 
       
                if (fila.Row.Table.Columns.Contains("Especialidad"))
                    txtEspecialidad.Text = fila["Especialidad"].ToString();
            }
            else
            {
                txtTarifa.Clear();
                txtEspecialidad.Clear();
            }
        }

        // TODO:  Evento Click en la Tabla Solo selecciona, no carga datos todavIA
        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TODO:  BOTON EDITAR (Carga los datos y permite editar)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow != null && dgvCitas.CurrentRow.Index >= 0)
            {
                try
                {
                    DataGridViewRow fila = dgvCitas.CurrentRow;

                    idCitaSeleccionada = Convert.ToInt32(fila.Cells["IDCita"].Value);

                    // TODO: Al establecer los valores de los Combos, el evento SelectedIndexChanged 
                    // se dispara automaticamente y llenara Tarifa y Especialidad automaticamente linea 148 Mature 
                    cboDoctor.SelectedValue = Convert.ToInt32(fila.Cells["IDDoctor"].Value);
                    cboPaciente.SelectedValue = Convert.ToInt32(fila.Cells["IDPaciente"].Value);
                    dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaCita"].Value);
                    TimeSpan hora = (TimeSpan)fila.Cells["HoraCita"].Value;
                    dtpHora.Value = DateTime.Today.Add(hora);

                    // Cambiamos estado del botón
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

        // TODO: BOTON AGENDAR 
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cboDoctor.SelectedIndex == -1 || cboPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Doctor y Paciente");
                return;
            }

            try
            {
                if (idCitaSeleccionada == 0)
                {
                    // Crear Nueva
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
                    // Guardar Edición
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
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

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
    }
}