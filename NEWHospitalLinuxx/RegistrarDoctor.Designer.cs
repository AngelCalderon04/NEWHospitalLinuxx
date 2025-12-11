namespace CapaPresentacion
{
    partial class RegistrarDoctor
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
            label1 = new Label();
            Especialidad = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtExequatur = new TextBox();
            txtTarifa = new TextBox();
            txtCedula = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            cboEspecialidad = new ComboBox();
            btnGuardar = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            label9 = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 110);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Especialidad
            // 
            Especialidad.AutoSize = true;
            Especialidad.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Especialidad.Location = new Point(16, 153);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(131, 23);
            Especialidad.TabIndex = 1;
            Especialidad.Text = "Especialidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 204);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 2;
            label3.Text = "Exequatur:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 250);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 3;
            label4.Text = "Tarifa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 305);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 4;
            label5.Text = "Cedula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(437, 362);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 5;
            label6.Text = "Usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(458, 420);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 6;
            label7.Text = "Clave:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo ";
            txtNombre.Size = new Size(232, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtExequatur
            // 
            txtExequatur.Location = new Point(156, 199);
            txtExequatur.Name = "txtExequatur";
            txtExequatur.PlaceholderText = "Exequatur";
            txtExequatur.Size = new Size(232, 31);
            txtExequatur.TabIndex = 8;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(156, 245);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.PlaceholderText = "Tarifa";
            txtTarifa.Size = new Size(232, 31);
            txtTarifa.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(156, 305);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "cedula";
            txtCedula.Size = new Size(238, 31);
            txtCedula.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(532, 356);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(238, 32);
            txtUsuario.TabIndex = 11;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(532, 412);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(238, 31);
            txtClave.TabIndex = 12;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Medicina Interna", "Pediatría", "Ginecología y Obstetricia", "Cardiología", "Neumología", "Gastroenterología", "Dermatología", "Neurología", "Endocrinología", "Psiquiatría", "Oftalmología", "Otorrinolaringología", "Urología", "Nefrología", "Oncología", "Hematología", "Infectología" });
            cboEspecialidad.Location = new Point(156, 149);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(232, 33);
            cboEspecialidad.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(241, 511);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 47);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(409, 511);
            button2.Name = "button2";
            button2.Size = new Size(117, 47);
            button2.TabIndex = 15;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 81);
            panel1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(148, 17);
            label8.Name = "label8";
            label8.Size = new Size(481, 47);
            label8.TabIndex = 0;
            label8.Text = "REGISTRAR DOCTOR ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 360);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 17;
            label2.Text = "Telefono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(67, 416);
            label9.Name = "label9";
            label9.Size = new Size(71, 23);
            label9.TabIndex = 18;
            label9.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(156, 356);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(238, 31);
            txtTelefono.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 412);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(232, 31);
            txtEmail.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(451, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 299);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // RegistrarDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 628);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnGuardar);
            Controls.Add(cboEspecialidad);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtCedula);
            Controls.Add(txtTarifa);
            Controls.Add(txtExequatur);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Especialidad);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegistrarDoctor";
            Text = "RegistrarDoctor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Especialidad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtExequatur;
        private TextBox txtTarifa;
        private TextBox txtCedula;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private ComboBox cboEspecialidad;
        private Button btnGuardar;
        private Button button2;
        private Panel panel1;
        private Label label8;
        private Label label2;
        private Label label9;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
    }
}