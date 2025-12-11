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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(665, 460);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(151, 31);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(362, 460);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 31);
            dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(437, 76);
            label2.Name = "label2";
            label2.Size = new Size(279, 23);
            label2.TabIndex = 19;
            label2.Text = "BIENVENIDO AL SISTEMA";
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(5, 315);
            button1.Name = "button1";
            button1.Size = new Size(248, 34);
            button1.TabIndex = 18;
            button1.Text = "AGREGAR PERSONAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-26, -41);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 99);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(507, 42);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL LINUX";
            // 
            // btnRegistrarCONS
            // 
            btnRegistrarCONS.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarCONS.Location = new Point(5, 195);
            btnRegistrarCONS.Margin = new Padding(2);
            btnRegistrarCONS.Name = "btnRegistrarCONS";
            btnRegistrarCONS.Size = new Size(248, 34);
            btnRegistrarCONS.TabIndex = 16;
            btnRegistrarCONS.Text = "REGISTRAR CONSULTA";
            btnRegistrarCONS.UseVisualStyleBackColor = true;
            btnRegistrarCONS.Click += btnRegistrarCONS_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.8F);
            btnSalir.Location = new Point(52, 436);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(5, 259);
            btnHistorial.Margin = new Padding(2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(248, 34);
            btnHistorial.TabIndex = 14;
            btnHistorial.Text = "HISTORIAL PACIENTE ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendarCita.Location = new Point(5, 140);
            btnAgendarCita.Margin = new Padding(2);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(248, 34);
            btnAgendarCita.TabIndex = 13;
            btnAgendarCita.Text = "AGENDAR CITA";
            btnAgendarCita.UseVisualStyleBackColor = true;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarPaciente.Location = new Point(5, 92);
            btnRegistrarPaciente.Margin = new Padding(2);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(248, 34);
            btnRegistrarPaciente.TabIndex = 12;
            btnRegistrarPaciente.Text = "REGISTRAR PACIENTE ";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(437, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 311);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(8, 358);
            button2.Name = "button2";
            button2.Size = new Size(244, 32);
            button2.TabIndex = 23;
            button2.Text = "BASE DATOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(903, 525);
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
    }
}