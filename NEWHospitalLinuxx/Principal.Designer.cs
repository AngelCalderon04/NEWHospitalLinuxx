namespace CapaPresentacion
{
    partial class Principal
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
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnRegistrarCONS = new Button();
            btnSalir = new Button();
            btnHistorial = new Button();
            btnAgendarCita = new Button();
            btnRegistrarPaciente = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(532, 368);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(122, 27);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(290, 368);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(350, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 21);
            label2.TabIndex = 19;
            label2.Text = "BIENVENIDO AL SISTEMA";
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(4, 252);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(198, 27);
            button1.TabIndex = 18;
            button1.Text = "AGREGAR PERSONAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-21, -33);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(751, 79);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(424, 35);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL LINUX";
            // 
            // btnRegistrarCONS
            // 
            btnRegistrarCONS.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarCONS.Location = new Point(4, 156);
            btnRegistrarCONS.Margin = new Padding(2);
            btnRegistrarCONS.Name = "btnRegistrarCONS";
            btnRegistrarCONS.Size = new Size(198, 27);
            btnRegistrarCONS.TabIndex = 16;
            btnRegistrarCONS.Text = "REGISTRAR CONSULTA";
            btnRegistrarCONS.UseVisualStyleBackColor = true;
            btnRegistrarCONS.Click += btnRegistrarCONS_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.8F);
            btnSalir.Location = new Point(42, 349);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 27);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(4, 207);
            btnHistorial.Margin = new Padding(2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(198, 27);
            btnHistorial.TabIndex = 14;
            btnHistorial.Text = "HISTORIAL PACIENTE ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendarCita.Location = new Point(4, 112);
            btnAgendarCita.Margin = new Padding(2);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(198, 27);
            btnAgendarCita.TabIndex = 13;
            btnAgendarCita.Text = "AGENDAR CITA";
            btnAgendarCita.UseVisualStyleBackColor = true;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarPaciente.Location = new Point(4, 74);
            btnRegistrarPaciente.Margin = new Padding(2);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(198, 27);
            btnRegistrarPaciente.TabIndex = 12;
            btnRegistrarPaciente.Text = "REGISTRAR PACIENTE ";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(350, 82);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 249);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(7, 305);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(195, 26);
            button2.TabIndex = 23;
            button2.Text = "BASE DATOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(7, 397);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(195, 13);
            progressBar1.TabIndex = 24;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(722, 420);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(btnRegistrarCONS);
            Controls.Add(btnSalir);
            Controls.Add(btnHistorial);
            Controls.Add(btnAgendarCita);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button btnRegistrarCONS;
        private Button btnSalir;
        private Button btnHistorial;
        private Button btnAgendarCita;
        private Button btnRegistrarPaciente;
        private PictureBox pictureBox1;
        private Button button2;
        private ProgressBar progressBar1;
    }
}