namespace CapaPresentacion
{
    partial class formPersonalAdministrativo
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textNombre = new TextBox();
            textCedula = new TextBox();
            textSalario = new TextBox();
            textUsuario = new TextBox();
            textClave = new TextBox();
            comboDepartamento = new ComboBox();
            combocargo = new ComboBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            label9 = new Label();
            label10 = new Label();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 23);
            label1.Name = "label1";
            label1.Size = new Size(635, 42);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR ADMINISTRATIVOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 108);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 160);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 2;
            label3.Text = "Cedula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 326);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 3;
            label4.Text = "DPTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 385);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 4;
            label5.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 98);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 5;
            label6.Text = "Salario: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 157);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 6;
            label7.Text = "Usuario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(468, 209);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 7;
            label8.Text = "Clave:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(135, 104);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "NOMBRE COMPLETO";
            textNombre.Size = new Size(228, 31);
            textNombre.TabIndex = 9;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(135, 160);
            textCedula.Name = "textCedula";
            textCedula.PlaceholderText = "CEDULA";
            textCedula.Size = new Size(228, 31);
            textCedula.TabIndex = 10;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(532, 98);
            textSalario.Name = "textSalario";
            textSalario.PlaceholderText = "$$$$$$$$";
            textSalario.Size = new Size(165, 31);
            textSalario.TabIndex = 12;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(534, 157);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "USUARIO";
            textUsuario.Size = new Size(163, 31);
            textUsuario.TabIndex = 13;
            // 
            // textClave
            // 
            textClave.Location = new Point(532, 209);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "CLAVE";
            textClave.Size = new Size(165, 31);
            textClave.TabIndex = 14;
            // 
            // comboDepartamento
            // 
            comboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartamento.FormattingEnabled = true;
            comboDepartamento.Items.AddRange(new object[] { "Administración General", "Recursos Humanos", "Finanzas / Contabilidad", "Compras y Suministros", "Archivo Clínico", "Gestión de Calidad", "Planificación y Desarrollo", "Servicios Generales", "Tecnología de la Información (TI)", "Facturación y Cobros", "Atención al Usuario", "Gestión de Riesgos", "Logística", "Mantenimiento", "Seguridad", "Relaciones Públicas" });
            comboDepartamento.Location = new Point(134, 326);
            comboDepartamento.Name = "comboDepartamento";
            comboDepartamento.Size = new Size(230, 33);
            comboDepartamento.TabIndex = 15;
            // 
            // combocargo
            // 
            combocargo.DropDownStyle = ComboBoxStyle.DropDownList;
            combocargo.FormattingEnabled = true;
            combocargo.Items.AddRange(new object[] { "Administrador General", "Subadministrador", "Director de Recursos Humanos", "Analista de Recursos Humanos", "Gerente Financiero", "Contador", "Auxiliar Contable", "Encargado de Compras", "Auxiliar de Compras", "Jefe de Archivo Clínico", "Técnico de Archivo", "Coordinador de Calidad", "Analista de Calidad", "Encargado de Servicios Generales", "Supervisor de Limpieza", "Especialista en Facturación", "Cajero", "Analista de Cobros", "Recepcionista", "Servicio al Cliente", "Coordinador de Logística", "Técnico de Mantenimiento", "Encargado de Seguridad", "Relacionista Público", "Soporte Técnico", "Administrador de Sistemas" });
            combocargo.Location = new Point(135, 385);
            combocargo.Name = "combocargo";
            combocargo.Size = new Size(230, 33);
            combocargo.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(286, 472);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 34);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.System;
            btnSalir.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(452, 472);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "SALIR ";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 209);
            label9.Name = "label9";
            label9.Size = new Size(94, 23);
            label9.TabIndex = 19;
            label9.Text = "Telefono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(48, 261);
            label10.Name = "label10";
            label10.Size = new Size(71, 23);
            label10.TabIndex = 20;
            label10.Text = "Email:";
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(135, 209);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "TELEFONO";
            textTelefono.Size = new Size(229, 31);
            textTelefono.TabIndex = 21;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(134, 261);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "EMAIL";
            textEmail.Size = new Size(229, 31);
            textEmail.TabIndex = 22;
            // 
            // formPersonalAdministrativo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(combocargo);
            Controls.Add(comboDepartamento);
            Controls.Add(textClave);
            Controls.Add(textUsuario);
            Controls.Add(textSalario);
            Controls.Add(textCedula);
            Controls.Add(textNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "formPersonalAdministrativo";
            Text = "formPersonalAdministrativo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textNombre;
        private TextBox textCedula;
        private TextBox textSalario;
        private TextBox textUsuario;
        private TextBox textClave;
        private ComboBox comboDepartamento;
        private ComboBox combocargo;
        private Button btnGuardar;
        private Button btnSalir;
        private Label label9;
        private Label label10;
        private TextBox textTelefono;
        private TextBox textEmail;
    }
}