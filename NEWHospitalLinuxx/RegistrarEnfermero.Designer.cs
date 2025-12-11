namespace CapaPresentacion
{
    partial class RegistrarEnfermero
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
            pictureBox1 = new PictureBox();
            cboTurno = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            textclave = new TextBox();
            textusuario = new TextBox();
            textcedula = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            lblArea = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            cboArea = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new Point(445, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 383);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Manana", "Tarde ", "Noche " });
            cboTurno.Location = new Point(155, 219);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(245, 31);
            cboTurno.TabIndex = 33;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(257, 500);
            button2.Name = "button2";
            button2.Size = new Size(143, 34);
            button2.TabIndex = 32;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(79, 500);
            button1.Name = "button1";
            button1.Size = new Size(136, 34);
            button1.TabIndex = 31;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textclave
            // 
            textclave.Location = new Point(155, 401);
            textclave.Name = "textclave";
            textclave.PlaceholderText = "Clave";
            textclave.Size = new Size(245, 31);
            textclave.TabIndex = 30;
            // 
            // textusuario
            // 
            textusuario.Location = new Point(155, 341);
            textusuario.Name = "textusuario";
            textusuario.PlaceholderText = "Usuario";
            textusuario.Size = new Size(245, 31);
            textusuario.TabIndex = 29;
            // 
            // textcedula
            // 
            textcedula.Location = new Point(155, 165);
            textcedula.Name = "textcedula";
            textcedula.PlaceholderText = "Cedula";
            textcedula.Size = new Size(245, 31);
            textcedula.TabIndex = 28;
            textcedula.KeyPress += textcedula_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 405);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 27;
            label6.Text = "Clave:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 345);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 26;
            label5.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 165);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 25;
            label3.Text = "Cedula:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 77);
            panel1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(129, 17);
            label4.Name = "label4";
            label4.Size = new Size(523, 42);
            label4.TabIndex = 7;
            label4.Text = "REGISTRAR ENFERMERO ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(70, 275);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(60, 23);
            lblArea.TabIndex = 23;
            lblArea.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 219);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 22;
            label2.Text = "Turno: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 117);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(245, 31);
            txtNombre.TabIndex = 19;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // cboArea
            // 
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Emergencias", "Urgencias", "Cuidados Intensivos (UCI)", "Cuidados Intensivos Neonatales (UCIN)", "Quirófano", "Recuperación Postquirúrgica", "Sala de Hospitalización" });
            cboArea.Location = new Point(155, 275);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(245, 33);
            cboArea.TabIndex = 35;
            // 
            // RegistrarEnfermero
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 568);
            Controls.Add(cboArea);
            Controls.Add(pictureBox1);
            Controls.Add(cboTurno);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textclave);
            Controls.Add(textusuario);
            Controls.Add(textcedula);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "RegistrarEnfermero";
            Text = "RegistrarEnfermero";
            Load += RegistrarEnfermero_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cboTurno;
        private Button button2;
        private Button button1;
        private TextBox textclave;
        private TextBox textusuario;
        private TextBox textcedula;
        private Label label6;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label lblArea;
        private Label label2;
        private Label label1;
        private TextBox textArea;
        private TextBox txtNombre;
        private ComboBox cboArea;
    }
}