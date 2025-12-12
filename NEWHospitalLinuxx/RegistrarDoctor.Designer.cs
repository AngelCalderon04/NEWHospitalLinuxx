namespace CapaPresentacion
{
    partial class RegistrarDoctor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label2 = new Label();
            label9 = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F);
            label1.Location = new Point(46, 88);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.Text = "Nombre:";

            // Especialidad
            Especialidad.AutoSize = true;
            Especialidad.Font = new Font("Century", 10F);
            Especialidad.Location = new Point(13, 122);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(115, 21);
            Especialidad.Text = "Especialidad:";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F);
            label3.Location = new Point(34, 163);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.Text = "Exequatur:";

            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9F);
            label4.Location = new Point(64, 200);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.Text = "Tarifa:";

            // label5
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F);
            label5.Location = new Point(46, 244);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.Text = "Cedula:";

            // label6
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F);
            label6.Location = new Point(350, 290);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.Text = "Usuario:";

            // label7
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10F);
            label7.Location = new Point(366, 336);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.Text = "Clave:";

            // txtNombre
            txtNombre.Location = new Point(125, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(186, 27);
            txtNombre.KeyPress += txtNombre_KeyPress;

            // txtExequatur
            txtExequatur.Location = new Point(125, 159);
            txtExequatur.Name = "txtExequatur";
            txtExequatur.PlaceholderText = "Exequatur";
            txtExequatur.Size = new Size(186, 27);
            txtExequatur.KeyPress += txtSoloNumeros_KeyPress;

            // txtTarifa
            txtTarifa.Location = new Point(125, 196);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.PlaceholderText = "Tarifa";
            txtTarifa.Size = new Size(186, 27);
            txtTarifa.KeyPress += txtSoloNumeros_KeyPress;

            // txtCedula
            txtCedula.Location = new Point(125, 244);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Cedula";
            txtCedula.Size = new Size(191, 27);
            txtCedula.KeyPress += txtSoloNumeros_KeyPress;

            // txtUsuario
            txtUsuario.Location = new Point(426, 285);
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(191, 27);

            // txtClave
            txtClave.Location = new Point(426, 330);
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(191, 27);

            // cboEspecialidad
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.Location = new Point(125, 119);
            cboEspecialidad.Size = new Size(186, 28);
            cboEspecialidad.Items.AddRange(new object[]
            {
                "Medicina Interna", "Pediatría", "Ginecología y Obstetricia",
                "Cardiología", "Neumología", "Gastroenterología", "Dermatología",
                "Neurología", "Endocrinología", "Psiquiatría", "Oftalmología",
                "Otorrinolaringología", "Urología", "Nefrología", "Oncología",
                "Hematología", "Infectología"
            });

            // button1 (GUARDAR)
            button1.Font = new Font("Century", 10F);
            button1.Location = new Point(193, 409);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.Text = "GUARDAR";
            button1.Click += button1_Click;

            // button2 (SALIR)
            button2.Font = new Font("Century", 10F);
            button2.Location = new Point(327, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.Text = "SALIR";
            button2.Click += button2_Click;

            // panel1
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 2);
            panel1.Size = new Size(642, 65);

            // label8
            label8.AutoSize = true;
            label8.Font = new Font("Century", 20F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(118, 14);
            label8.Text = "REGISTRAR DOCTOR";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F);
            label2.Location = new Point(35, 288);
            label2.Text = "Telefono:";

            // label9
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10F);
            label9.Location = new Point(54, 333);
            label9.Text = "Email:";

            // txtTelefono
            txtTelefono.Location = new Point(125, 285);
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(191, 27);
            txtTelefono.KeyPress += txtSoloNumeros_KeyPress;

            // txtEmail
            txtEmail.Location = new Point(125, 330);
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(186, 27);

            // pictureBox1
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(361, 38);
            pictureBox1.Size = new Size(279, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // progressBar1
            progressBar1.Location = new Point(193, 476);
            progressBar1.Size = new Size(228, 13);
            progressBar1.Visible = false;

            // RegistrarDoctor
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 502);

            Controls.Add(progressBar1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label8;
        private Label label2;
        private Label label9;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}
