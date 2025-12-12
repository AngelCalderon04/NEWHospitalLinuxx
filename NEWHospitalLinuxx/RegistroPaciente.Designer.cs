namespace CapaPresentacion
{
    partial class RegistroPaciente
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
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10F);
            label5.Location = new Point(588, 201);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.Text = "Num. Seguro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Century", 14F);
            label1.Location = new Point(77, 84);
            label1.Name = "label1";
            label1.Size = new Size(303, 35);
            label1.Text = "Información Personal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 80);
            panel1.Paint += panel1_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(300, 20);
            lblTitulo.Text = "REGISTRO DE PACIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Century", 14F);
            label4.Location = new Point(592, 399);
            label4.Text = "Medidas Físicas";
            // 
            // label3
            //
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Century", 14F);
            label3.Location = new Point(573, 84);
            label3.Text = "Datos Médicos";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Century", 14F);
            label2.Location = new Point(77, 357);
            label2.Text = "Contacto";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(77, 142);
            txtNombre.Multiline = true;
            txtNombre.Size = new Size(303, 49);
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.KeyPress += SoloLetras_KeyPress;
            //
            // txtCedula
            //
            txtCedula.Location = new Point(77, 207);
            txtCedula.Multiline = true;
            txtCedula.Size = new Size(303, 48);
            txtCedula.PlaceholderText = "Cédula";
            txtCedula.KeyPress += SoloNumeros_KeyPress;
            //
            // txtTelefono
            //
            txtTelefono.Location = new Point(77, 412);
            txtTelefono.Multiline = true;
            txtTelefono.Size = new Size(303, 49);
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
            //
            // txtEmail
            //
            txtEmail.Location = new Point(77, 475);
            txtEmail.Multiline = true;
            txtEmail.Size = new Size(303, 51);
            txtEmail.PlaceholderText = "Email";
            //
            // dtpFecha
            //
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(210, 274);
            //
            // dtpFechaNacimiento
            //
            dtpFechaNacimiento.AutoSize = true;
            dtpFechaNacimiento.Font = new Font("Century", 10F);
            dtpFechaNacimiento.Location = new Point(77, 280);
            dtpFechaNacimiento.Text = "Fecha Nac:";
            //
            // lblGrupoSang
            //
            lblGrupoSang.AutoSize = true;
            lblGrupoSang.Font = new Font("Century", 10F);
            lblGrupoSang.Location = new Point(573, 142);
            lblGrupoSang.Text = "Grupo Sanguíneo";
            //
            // cbosanguineo
            //
            cbosanguineo.Location = new Point(781, 138);
            cbosanguineo.Items.AddRange(new object[] {
                "A+", "A−", "B+", "B−", "AB+", "AB−", "O+", "O−"
            });
            //
            // txtSeguro
            //
            txtSeguro.Location = new Point(780, 206);
            txtSeguro.KeyPress += SoloNumeros_KeyPress;
            //
            // txtAlergias
            //
            txtAlergias.Location = new Point(588, 264);
            txtAlergias.Multiline = true;
            txtAlergias.Size = new Size(394, 114);
            txtAlergias.PlaceholderText = "Alergias";
            //
            // txtPeso
            //
            txtPeso.Location = new Point(592, 460);
            txtPeso.Multiline = true;
            txtPeso.Size = new Size(164, 51);
            txtPeso.PlaceholderText = "Peso (Lb)";
            txtPeso.KeyPress += SoloDecimales_KeyPress;
            //
            // txtAltura
            //
            txtAltura.Location = new Point(810, 460);
            txtAltura.Multiline = true;
            txtAltura.Size = new Size(172, 51);
            txtAltura.PlaceholderText = "Altura (m)";
            txtAltura.KeyPress += SoloDecimales_KeyPress;
            //
            // txtContactoEmergencia
            //
            txtContactoEmergencia.Location = new Point(77, 545);
            txtContactoEmergencia.Multiline = true;
            txtContactoEmergencia.Size = new Size(303, 50);
            txtContactoEmergencia.PlaceholderText = "Contacto de Emergencia";
            txtContactoEmergencia.KeyPress += SoloNumeros_KeyPress;
            //
            // btnGuargar
            //
            btnGuargar.BackColor = Color.LightSkyBlue;
            btnGuargar.Font = new Font("Century", 12F, FontStyle.Bold);
            btnGuargar.Location = new Point(204, 624);
            btnGuargar.Size = new Size(176, 39);
            btnGuargar.Text = "GUARDAR";
            btnGuargar.Click += btnGuargar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.BackColor = Color.Azure;
            btnLimpiar.Font = new Font("Century", 12F, FontStyle.Bold);
            btnLimpiar.Location = new Point(428, 624);
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // btnCerrar
            //
            btnCerrar.BackColor = Color.LightCoral;
            btnCerrar.Font = new Font("Century", 12F, FontStyle.Bold);
            btnCerrar.Location = new Point(670, 620);
            btnCerrar.Text = "CERRAR";
            btnCerrar.Click += btnCerrar_Click;
            //
            // progressBar1
            //
            progressBar1.Location = new Point(200, 590);
            progressBar1.Size = new Size(600, 15);
            progressBar1.Visible = false;
            // 
            // RegistroPaciente
            //
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
            Controls.Add(txtAlergias);
            Controls.Add(lblGrupoSang);
            Controls.Add(dtpFecha);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(progressBar1);
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
        private ProgressBar progressBar1;
    }
}