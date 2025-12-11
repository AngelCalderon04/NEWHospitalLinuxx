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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(-157, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 721);
            panel2.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-146, -26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1436, 100);
            panel1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(478, 35);
            label2.Name = "label2";
            label2.Size = new Size(485, 55);
            label2.TabIndex = 15;
            label2.Text = "REGISTRAR CONSULTA";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(596, 641);
            button1.Name = "button1";
            button1.Size = new Size(131, 56);
            button1.TabIndex = 30;
            button1.Text = "CERRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(393, 641);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 56);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(639, 261);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "OBSERVACIONES";
            txtObservaciones.Size = new Size(404, 110);
            txtObservaciones.TabIndex = 28;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(639, 453);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PlaceholderText = "TRATAMIENTO";
            txtTratamiento.Size = new Size(404, 115);
            txtTratamiento.TabIndex = 27;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(115, 453);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PlaceholderText = "DIAGNOSTICO";
            txtDiagnostico.Size = new Size(369, 115);
            txtDiagnostico.TabIndex = 26;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(113, 251);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "MOTIVO CONSULTA ";
            txtMotivo.Size = new Size(371, 110);
            txtMotivo.TabIndex = 25;
            txtMotivo.TextChanged += txtMotivo_TextChanged;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(639, 207);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(178, 22);
            lblObservaciones.TabIndex = 24;
            lblObservaciones.Text = "OBSERVACIONES:";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTratamiento.Location = new Point(630, 417);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(156, 22);
            lblTratamiento.TabIndex = 23;
            lblTratamiento.Text = "TRATAMIENTO:";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(115, 417);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(149, 22);
            lblDiagnostico.TabIndex = 22;
            lblDiagnostico.Text = "DIAGNOSTICO ";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotivo.Location = new Point(113, 207);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(202, 22);
            lblMotivo.TabIndex = 21;
            lblMotivo.Text = "MOTIVO CONSULTA:";
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(750, 121);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(251, 33);
            cboDoctor.TabIndex = 20;
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(274, 121);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(263, 33);
            cboPaciente.TabIndex = 19;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.BorderStyle = BorderStyle.Fixed3D;
            lblDoctor.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.Location = new Point(596, 121);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(107, 25);
            lblDoctor.TabIndex = 18;
            lblDoctor.Text = "DOCTOR:";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BorderStyle = BorderStyle.Fixed3D;
            lblPaciente.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(115, 125);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(130, 25);
            lblPaciente.TabIndex = 17;
            lblPaciente.Text = "PACIENTE: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Location = new Point(-2, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(97, 673);
            panel3.TabIndex = 33;
            // 
            // RegistrarConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 741);
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
    }
}