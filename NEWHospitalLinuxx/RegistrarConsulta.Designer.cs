namespace CapaPresentacion
{
    partial class RegistrarConsulta
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
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            btnGuardar = new Button();
            txtObservaciones = new TextBox();
            txtTratamiento = new TextBox();
            txtDiagnostico = new TextBox();
            txtMotivo = new TextBox();
            lblObservaciones = new Label();
            lblTratamiento = new Label();
            lblDiagnostico = new Label();
            lblMotivo = new Label();
            cboDoctor = new ComboBox();
            cboPaciente = new ComboBox();
            lblDoctor = new Label();
            lblPaciente = new Label();
            panel3 = new Panel();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(-126, 46);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(116, 577);
            panel2.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-117, -21);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 80);
            panel1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(382, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(404, 46);
            label2.TabIndex = 15;
            label2.Text = "REGISTRAR CONSULTA";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(477, 513);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 30;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(314, 513);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 45);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(511, 209);
            txtObservaciones.Margin = new Padding(2, 2, 2, 2);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "OBSERVACIONES";
            txtObservaciones.Size = new Size(324, 89);
            txtObservaciones.TabIndex = 28;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(511, 362);
            txtTratamiento.Margin = new Padding(2, 2, 2, 2);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PlaceholderText = "TRATAMIENTO";
            txtTratamiento.Size = new Size(324, 93);
            txtTratamiento.TabIndex = 27;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(92, 362);
            txtDiagnostico.Margin = new Padding(2, 2, 2, 2);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PlaceholderText = "DIAGNOSTICO";
            txtDiagnostico.Size = new Size(296, 93);
            txtDiagnostico.TabIndex = 26;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(90, 201);
            txtMotivo.Margin = new Padding(2, 2, 2, 2);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "MOTIVO CONSULTA ";
            txtMotivo.Size = new Size(298, 89);
            txtMotivo.TabIndex = 25;
            txtMotivo.TextChanged += txtMotivo_TextChanged;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(511, 166);
            lblObservaciones.Margin = new Padding(2, 0, 2, 0);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(149, 18);
            lblObservaciones.TabIndex = 24;
            lblObservaciones.Text = "OBSERVACIONES:";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTratamiento.Location = new Point(504, 334);
            lblTratamiento.Margin = new Padding(2, 0, 2, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(130, 18);
            lblTratamiento.TabIndex = 23;
            lblTratamiento.Text = "TRATAMIENTO:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(92, 334);
            lblDiagnostico.Margin = new Padding(2, 0, 2, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(125, 18);
            lblDiagnostico.TabIndex = 22;
            lblDiagnostico.Text = "DIAGNOSTICO ";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotivo.Location = new Point(90, 166);
            lblMotivo.Margin = new Padding(2, 0, 2, 0);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(168, 18);
            lblMotivo.TabIndex = 21;
            lblMotivo.Text = "MOTIVO CONSULTA:";
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(600, 97);
            cboDoctor.Margin = new Padding(2, 2, 2, 2);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(202, 28);
            cboDoctor.TabIndex = 20;
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(219, 97);
            cboPaciente.Margin = new Padding(2, 2, 2, 2);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(211, 28);
            cboPaciente.TabIndex = 19;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.BorderStyle = BorderStyle.Fixed3D;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(477, 97);
            lblDoctor.Margin = new Padding(2, 0, 2, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(91, 23);
            lblDoctor.TabIndex = 18;
            lblDoctor.Text = "DOCTOR:";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BorderStyle = BorderStyle.Fixed3D;
            lblPaciente.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(92, 100);
            lblPaciente.Margin = new Padding(2, 0, 2, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(113, 23);
            lblPaciente.TabIndex = 17;
            lblPaciente.Text = "PACIENTE: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Location = new Point(-2, 58);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(78, 538);
            panel3.TabIndex = 33;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(314, 489);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(268, 10);
            progressBar1.TabIndex = 34;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // RegistrarConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 593);
            Controls.Add(progressBar1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(txtObservaciones);
            Controls.Add(txtTratamiento);
            Controls.Add(txtDiagnostico);
            Controls.Add(txtMotivo);
            Controls.Add(lblObservaciones);
            Controls.Add(lblTratamiento);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblMotivo);
            Controls.Add(cboDoctor);
            Controls.Add(cboPaciente);
            Controls.Add(lblDoctor);
            Controls.Add(lblPaciente);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegistrarConsulta";
            Text = "RegistrarConsulta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button btnGuardar;
        private TextBox txtObservaciones;
        private TextBox txtTratamiento;
        private TextBox txtDiagnostico;
        private TextBox txtMotivo;
        private Label lblObservaciones;
        private Label lblTratamiento;
        private Label lblDiagnostico;
        private Label lblMotivo;
        private ComboBox cboDoctor;
        private ComboBox cboPaciente;
        private Label lblDoctor;
        private Label lblPaciente;
        private Panel panel3;
        private ProgressBar progressBar1;
    }
}