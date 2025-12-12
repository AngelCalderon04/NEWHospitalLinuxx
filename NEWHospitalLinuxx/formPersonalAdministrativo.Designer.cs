namespace CapaPresentacion
{
    partial class FormPersonalAdministrativo
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
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            textClave = new TextBox();
            textUsuario = new TextBox();
            textSalario = new TextBox();
            comboDepartamento = new ComboBox();
            textCedula = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            comboCargo = new ComboBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(369, 413);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 33;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(213, 413);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 27);
            button1.TabIndex = 32;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(382, 202);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 31;
            label8.Text = "CLAVE:";
            // 
            // textClave
            // 
            textClave.Location = new Point(463, 198);
            textClave.Margin = new Padding(2, 2, 2, 2);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "CLAVE";
            textClave.Size = new Size(146, 27);
            textClave.TabIndex = 30;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(463, 151);
            textUsuario.Margin = new Padding(2, 2, 2, 2);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "USUARIO";
            textUsuario.Size = new Size(146, 27);
            textUsuario.TabIndex = 29;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(463, 95);
            textSalario.Margin = new Padding(2, 2, 2, 2);
            textSalario.Name = "textSalario";
            textSalario.PlaceholderText = "$$$$$$";
            textSalario.Size = new Size(146, 27);
            textSalario.TabIndex = 28;
            textSalario.KeyPress += textSoloNumeros_KeyPress;
            // 
            // comboDepartamento
            // 
            comboDepartamento.FormattingEnabled = true;
            comboDepartamento.Items.AddRange(new object[] { "Administración General", "Recursos Humanos", "Finanzas / Contabilidad", "Compras y Suministros", "Archivo Clínico", "Gestión de Calidad", "Planificación y Desarrollo", "Servicios Generales", "Tecnología de la Información (TI)", "Facturación y Cobros", "Atención al Usuario", "Gestión de Riesgos", "Logística", "Mantenimiento", "Seguridad", "Relaciones Públicas" });
            comboDepartamento.Location = new Point(149, 284);
            comboDepartamento.Margin = new Padding(2, 2, 2, 2);
            comboDepartamento.Name = "comboDepartamento";
            comboDepartamento.Size = new Size(171, 28);
            comboDepartamento.TabIndex = 27;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(149, 150);
            textCedula.Margin = new Padding(2, 2, 2, 2);
            textCedula.Name = "textCedula";
            textCedula.PlaceholderText = "CEDULA";
            textCedula.Size = new Size(173, 27);
            textCedula.TabIndex = 26;
            textCedula.KeyPress += textSoloNumeros_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(369, 158);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 25;
            label7.Text = "USUARIO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(373, 98);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 24;
            label6.Text = "SALARIO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 23;
            label5.Text = "CEDULA:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(149, 98);
            textNombre.Margin = new Padding(2, 2, 2, 2);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "NOMBRE COMPLETO";
            textNombre.Size = new Size(179, 27);
            textNombre.TabIndex = 22;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 342);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 21;
            label4.Text = "CARGO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 287);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 20;
            label3.Text = "DPTO: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 102);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 19;
            label9.Text = "NOMBRE:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label10);
            panel1.Location = new Point(2, -2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 62);
            panel1.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(96, 19);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(430, 28);
            label10.TabIndex = 0;
            label10.Text = "REGISTRAR ADMINISTRATIVOS";
            // 
            // comboCargo
            // 
            comboCargo.FormattingEnabled = true;
            comboCargo.Items.AddRange(new object[] { "Administrador General", "Subadministrador", "Director de Recursos Humanos", "Analista de Recursos Humanos", "Gerente Financiero", "Contador", "Auxiliar Contable", "Encargado de Compras", "Auxiliar de Compras", "Jefe de Archivo Clínico", "Técnico de Archivo", "Coordinador de Calidad", "Analista de Calidad", "Encargado de Servicios Generales", "Supervisor de Limpieza", "Especialista en Facturación", "Cajero", "Analista de Cobros", "Recepcionista", "Servicio al Cliente", "Coordinador de Logística", "Técnico de Mantenimiento", "Encargado de Seguridad", "Relacionista Público", "Soporte Técnico", "Administrador de Sistemas" });
            comboCargo.Location = new Point(149, 336);
            comboCargo.Margin = new Padding(2, 2, 2, 2);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(173, 28);
            comboCargo.TabIndex = 17;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(149, 195);
            txtTelefono.Margin = new Padding(2, 2, 2, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "TELEFONO ";
            txtTelefono.Size = new Size(173, 27);
            txtTelefono.TabIndex = 34;
            txtTelefono.KeyPress += textSoloNumeros_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 241);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "EMAIL";
            txtEmail.Size = new Size(173, 27);
            txtEmail.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 198);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 36;
            label1.Text = "TELEFONO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 243);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 37;
            label2.Text = "EMAIL";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(233, 393);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(202, 15);
            progressBar1.TabIndex = 38;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // FormPersonalAdministrativo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 452);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textClave);
            Controls.Add(textUsuario);
            Controls.Add(textSalario);
            Controls.Add(comboDepartamento);
            Controls.Add(textCedula);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(comboCargo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormPersonalAdministrativo";
            Text = "FormPersonalAdministrativo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label8;
        private TextBox textClave;
        private TextBox textUsuario;
        private TextBox textSalario;
        private ComboBox comboDepartamento;
        private TextBox textCedula;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textNombre;
        private Label label4;
        private Label label3;
        private Label label9;
        private Panel panel1;
        private Label label10;
        private ComboBox comboCargo;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
    }
}