namespace CapaPresentacion
{
    partial class RegistroPaciente
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
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblTitulo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            btnGuargar = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtContactoEmergencia = new TextBox();
            lblContacto = new Label();
            txtAlergias = new TextBox();
            lblGrupoSang = new Label();
            dtpFecha = new DateTimePicker();
            dtpFechaNacimiento = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            cbosanguineo = new ComboBox();
            txtSeguro = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(588, 201);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 54;
            label5.Text = "Num. Seguro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(77, 84);
            label1.Name = "label1";
            label1.Size = new Size(303, 35);
            label1.TabIndex = 49;
            label1.Text = "Informacion Personal ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(-38, -71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 141);
            panel1.TabIndex = 53;
            panel1.Paint += panel1_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(299, 29);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(506, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(592, 399);
            label4.Name = "label4";
            label4.Size = new Size(226, 35);
            label4.TabIndex = 52;
            label4.Text = "Medidas Fisicas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(573, 84);
            label3.Name = "label3";
            label3.Size = new Size(213, 35);
            label3.TabIndex = 51;
            label3.Text = "Datos Medicos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Century", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 357);
            label2.Name = "label2";
            label2.Size = new Size(140, 35);
            label2.TabIndex = 50;
            label2.Text = "Contacto ";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightCoral;
            btnCerrar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(670, 620);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(167, 46);
            btnCerrar.TabIndex = 48;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Azure;
            btnLimpiar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(428, 624);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(181, 46);
            btnLimpiar.TabIndex = 47;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuargar
            // 
            btnGuargar.BackColor = Color.LightSkyBlue;
            btnGuargar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuargar.Location = new Point(204, 624);
            btnGuargar.Margin = new Padding(2);
            btnGuargar.Name = "btnGuargar";
            btnGuargar.Size = new Size(176, 39);
            btnGuargar.TabIndex = 46;
            btnGuargar.Text = "GUARDAR";
            btnGuargar.UseVisualStyleBackColor = false;
            btnGuargar.Click += btnGuargar_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(810, 460);
            txtAltura.Margin = new Padding(2);
            txtAltura.Multiline = true;
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Altura(m)";
            txtAltura.Size = new Size(172, 51);
            txtAltura.TabIndex = 45;
            txtAltura.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(592, 460);
            txtPeso.Margin = new Padding(2);
            txtPeso.Multiline = true;
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso (Lb)";
            txtPeso.Size = new Size(164, 51);
            txtPeso.TabIndex = 44;
            txtPeso.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtContactoEmergencia
            // 
            txtContactoEmergencia.Location = new Point(77, 545);
            txtContactoEmergencia.Margin = new Padding(2);
            txtContactoEmergencia.Multiline = true;
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.PlaceholderText = "Contacto Emergencia ";
            txtContactoEmergencia.Size = new Size(303, 50);
            txtContactoEmergencia.TabIndex = 43;
            txtContactoEmergencia.KeyPress += SoloNumeros_KeyPress;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 10.8F);
            lblContacto.Location = new Point(284, 498);
            lblContacto.Margin = new Padding(2, 0, 2, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(0, 30);
            lblContacto.TabIndex = 42;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(588, 264);
            txtAlergias.Margin = new Padding(2);
            txtAlergias.Multiline = true;
            txtAlergias.Name = "txtAlergias";
            txtAlergias.PlaceholderText = "Alergias";
            txtAlergias.Size = new Size(394, 114);
            txtAlergias.TabIndex = 40;
            // 
            // lblGrupoSang
            // 
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrupoSang.Location = new Point(573, 142);
            lblGrupoSang.Margin = new Padding(2, 0, 2, 0);
            lblGrupoSang.Name = "lblGrupoSang";
            lblGrupoSang.Size = new Size(171, 23);
            lblGrupoSang.TabIndex = 38;
            lblGrupoSang.Text = "Grupo Sanguineo";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(210, 274);
            dtpFecha.Margin = new Padding(2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(170, 31);
            dtpFecha.TabIndex = 37;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Location = new Point(77, 280);
            dtpFechaNacimiento.Margin = new Padding(2, 0, 2, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(113, 23);
            dtpFechaNacimiento.TabIndex = 36;
            dtpFechaNacimiento.Text = "Fecha Nac:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 475);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(303, 51);
            txtEmail.TabIndex = 35;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(77, 412);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(303, 49);
            txtTelefono.TabIndex = 34;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(77, 207);
            txtCedula.Margin = new Padding(2);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Cedula";
            txtCedula.Size = new Size(303, 48);
            txtCedula.TabIndex = 33;
            txtCedula.KeyPress += SoloNumeros_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(77, 142);
            txtNombre.Margin = new Padding(2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new Size(303, 49);
            txtNombre.TabIndex = 32;
            txtNombre.KeyPress += SoloLetras_KeyPress;
            // 
            // cbosanguineo
            // 
            cbosanguineo.FormattingEnabled = true;
            cbosanguineo.Items.AddRange(new object[] { "A+", "A−", "B+", "B−", "AB+", "AB−", "O+", "O−" });
            cbosanguineo.Location = new Point(781, 138);
            cbosanguineo.Name = "cbosanguineo";
            cbosanguineo.Size = new Size(224, 33);
            cbosanguineo.TabIndex = 55;
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(780, 206);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(225, 31);
            txtSeguro.TabIndex = 56;
            txtSeguro.KeyPress += SoloNumeros_KeyPress;
            // 
            // RegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 733);
            Controls.Add(txtSeguro);
            Controls.Add(cbosanguineo);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuargar);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(txtContactoEmergencia);
            Controls.Add(lblContacto);
            Controls.Add(txtAlergias);
            Controls.Add(lblGrupoSang);
            Controls.Add(dtpFecha);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Name = "RegistroPaciente";
            Text = "RegistroPaciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Panel panel1;
        private Label lblTitulo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCerrar;
        private Button btnLimpiar;
        private Button btnGuargar;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private TextBox txtContactoEmergencia;
        private Label lblContacto;
        private TextBox txtAlergias;
        private Label lblGrupoSang;
        private DateTimePicker dtpFecha;
        private Label dtpFechaNacimiento;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private ComboBox cbosanguineo;
        private TextBox txtSeguro;
    }
}