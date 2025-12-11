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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(119, 306);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.ReadOnly = true;
            txtTarifa.Size = new Size(269, 31);
            txtTarifa.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 309);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 41;
            label3.Text = "Costo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 496);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 101);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 39;
            label1.Text = "NUEVA CITA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblGestionCitas);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1605, 62);
            panel1.TabIndex = 38;
            // 
            // lblGestionCitas
            // 
            lblGestionCitas.AutoSize = true;
            lblGestionCitas.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionCitas.ForeColor = SystemColors.ButtonHighlight;
            lblGestionCitas.Location = new Point(596, 13);
            lblGestionCitas.Name = "lblGestionCitas";
            lblGestionCitas.Size = new Size(352, 38);
            lblGestionCitas.TabIndex = 0;
            lblGestionCitas.Text = "GESTION DE CITAS";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.Location = new Point(64, 581);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 34);
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
            cboDoctor.Location = new Point(119, 208);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(276, 33);
            cboDoctor.TabIndex = 36;
            cboDoctor.SelectedIndexChanged += cboDoctor_SelectedIndexChanged;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(119, 151);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(276, 33);
            cboPaciente.TabIndex = 35;
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(533, 139);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 62;
            dgvCitas.Size = new Size(770, 459);
            dgvCitas.TabIndex = 34;
            dgvCitas.CellContentClick += dgvCitas_CellClick;
            // 
            // lblListaCitas
            // 
            lblListaCitas.AutoSize = true;
            lblListaCitas.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaCitas.Location = new Point(533, 92);
            lblListaCitas.Name = "lblListaCitas";
            lblListaCitas.Size = new Size(244, 23);
            lblListaCitas.TabIndex = 33;
            lblListaCitas.Text = "CITAS REGISTRADAS";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Location = new Point(215, 581);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MistyRose;
            btnLimpiar.Location = new Point(215, 515);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.PaleGreen;
            btnAgendar.Location = new Point(64, 515);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(130, 34);
            btnAgendar.TabIndex = 30;
            btnAgendar.Text = "AGENDAR";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(233, 391);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(152, 31);
            dtpHora.TabIndex = 29;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(264, 357);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(63, 23);
            lblHora.TabIndex = 28;
            lblHora.Text = "Hora:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(37, 391);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(139, 31);
            dtpFecha.TabIndex = 27;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(57, 357);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(79, 27);
            lblFecha.TabIndex = 26;
            lblFecha.Text = "Fecha:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(34, 212);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(78, 23);
            lblDoctor.TabIndex = 25;
            lblDoctor.Text = "Doctor:";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Century", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(18, 152);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(106, 27);
            lblPaciente.TabIndex = 24;
            lblPaciente.Text = "Paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 267);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 43;
            label4.Text = "Especialidad: ";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecialidad.Location = new Point(119, 260);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.ReadOnly = true;
            txtEspecialidad.Size = new Size(273, 29);
            txtEspecialidad.TabIndex = 44;
            // 
            // GestionCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 699);
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
    }
}