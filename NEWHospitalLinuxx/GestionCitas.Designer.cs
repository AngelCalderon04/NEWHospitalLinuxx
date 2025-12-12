namespace CapaPresentacion
{
    partial class GestionCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTarifa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblGestionCitas = new Label();
            btnEditar = new Button();
            cboDoctor = new ComboBox();
            cboPaciente = new ComboBox();
            dgvCitas = new DataGridView();
            lblListaCitas = new Label();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            btnAgendar = new Button();
            dtpHora = new DateTimePicker();
            lblHora = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblDoctor = new Label();
            lblPaciente = new Label();
            label4 = new Label();
            txtEspecialidad = new TextBox();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(95, 245);
            txtTarifa.Margin = new Padding(2, 2, 2, 2);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.ReadOnly = true;
            txtTarifa.Size = new Size(216, 27);
            txtTarifa.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 247);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 41;
            label3.Text = "Costo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 397);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 81);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 39;
            label1.Text = "NUEVA CITA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblGestionCitas);
            panel1.Location = new Point(-1, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 50);
            panel1.TabIndex = 38;
            // 
            // lblGestionCitas
            // 
            lblGestionCitas.AutoSize = true;
            lblGestionCitas.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionCitas.ForeColor = SystemColors.ButtonHighlight;
            lblGestionCitas.Location = new Point(477, 10);
            lblGestionCitas.Margin = new Padding(2, 0, 2, 0);
            lblGestionCitas.Name = "lblGestionCitas";
            lblGestionCitas.Size = new Size(304, 33);
            lblGestionCitas.TabIndex = 0;
            lblGestionCitas.Text = "GESTION DE CITAS";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Location = new Point(51, 465);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 27);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cboDoctor
            // 
            cboDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(95, 166);
            cboDoctor.Margin = new Padding(2, 2, 2, 2);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(222, 28);
            cboDoctor.TabIndex = 36;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(95, 121);
            cboPaciente.Margin = new Padding(2, 2, 2, 2);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(222, 28);
            cboPaciente.TabIndex = 35;
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(426, 111);
            dgvCitas.Margin = new Padding(2, 2, 2, 2);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(616, 367);
            dgvCitas.TabIndex = 34;
            dgvCitas.CellContentClick += dgvCitas_CellClick;
            // 
            // lblListaCitas
            // 
            lblListaCitas.AutoSize = true;
            lblListaCitas.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaCitas.Location = new Point(426, 74);
            lblListaCitas.Margin = new Padding(2, 0, 2, 0);
            lblListaCitas.Name = "lblListaCitas";
            lblListaCitas.Size = new Size(211, 21);
            lblListaCitas.TabIndex = 33;
            lblListaCitas.Text = "CITAS REGISTRADAS";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Location = new Point(172, 465);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MistyRose;
            btnLimpiar.Location = new Point(172, 412);
            btnLimpiar.Margin = new Padding(2, 2, 2, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 27);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.PaleGreen;
            btnAgendar.Location = new Point(51, 412);
            btnAgendar.Margin = new Padding(2, 2, 2, 2);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(104, 27);
            btnAgendar.TabIndex = 30;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(186, 313);
            dtpHora.Margin = new Padding(2, 2, 2, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(122, 27);
            dtpHora.TabIndex = 29;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(211, 286);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(55, 21);
            lblHora.TabIndex = 28;
            lblHora.Text = "Hora:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(30, 313);
            dtpFecha.Margin = new Padding(2, 2, 2, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(112, 27);
            dtpFecha.TabIndex = 27;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(46, 286);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(69, 23);
            lblFecha.TabIndex = 26;
            lblFecha.Text = "Fecha:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(27, 170);
            lblDoctor.Margin = new Padding(2, 0, 2, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(69, 21);
            lblDoctor.TabIndex = 25;
            lblDoctor.Text = "Doctor:";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(14, 122);
            lblPaciente.Margin = new Padding(2, 0, 2, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(92, 23);
            lblPaciente.TabIndex = 24;
            lblPaciente.Text = "Paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 214);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 43;
            label4.Text = "Especialidad: ";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecialidad.Location = new Point(95, 208);
            txtEspecialidad.Margin = new Padding(2, 2, 2, 2);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.ReadOnly = true;
            txtEspecialidad.Size = new Size(219, 26);
            txtEspecialidad.TabIndex = 44;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(426, 525);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(616, 15);
            progressBar1.TabIndex = 45;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // GestionCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 559);
            Controls.Add(progressBar1);
            Controls.Add(txtEspecialidad);
            Controls.Add(label4);
            Controls.Add(txtTarifa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(cboDoctor);
            Controls.Add(cboPaciente);
            Controls.Add(dgvCitas);
            Controls.Add(lblListaCitas);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgendar);
            Controls.Add(dtpHora);
            Controls.Add(lblHora);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblDoctor);
            Controls.Add(lblPaciente);
            Margin = new Padding(2, 2, 2, 2);
            Name = "GestionCitas";
            Text = "GestionCitas";
            Load += GestionCitas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarifa;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label lblGestionCitas;
        private Button btnEditar;
        private ComboBox cboDoctor;
        private ComboBox cboPaciente;
        private DataGridView dgvCitas;
        private Label lblListaCitas;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Button btnAgendar;
        private DateTimePicker dtpHora;
        private Label lblHora;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblDoctor;
        private Label lblPaciente;
        private Label label4;
        private TextBox txtEspecialidad;
        private ProgressBar progressBar1;
    }
}