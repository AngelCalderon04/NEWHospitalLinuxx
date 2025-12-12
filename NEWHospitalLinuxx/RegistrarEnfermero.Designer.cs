namespace CapaPresentacion
{
    partial class RegistrarEnfermero
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new System.Windows.Forms.PictureBox();
            cboTurno = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            textclave = new System.Windows.Forms.TextBox();
            textusuario = new System.Windows.Forms.TextBox();
            textcedula = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            lblArea = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            cboArea = new System.Windows.Forms.ComboBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // pictureBox1
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Image = Properties.Resources._new;
            pictureBox1.Location = new System.Drawing.Point(445, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(332, 383);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;

            // cboTurno
            cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTurno.Font = new System.Drawing.Font("Century", 10F);
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new System.Drawing.Point(155, 219);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new System.Drawing.Size(245, 31);
            cboTurno.TabIndex = 33;

            // button2 (SALIR)
            button2.Font = new System.Drawing.Font("Century", 10F);
            button2.Location = new System.Drawing.Point(257, 500);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(143, 34);
            button2.TabIndex = 32;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);

            // button1 (GUARDAR)
            button1.Font = new System.Drawing.Font("Century", 10F);
            button1.Location = new System.Drawing.Point(79, 500);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 34);
            button1.TabIndex = 31;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);

            // textclave
            textclave.Location = new System.Drawing.Point(155, 401);
            textclave.Name = "textclave";
            textclave.PlaceholderText = "Clave";
            textclave.Size = new System.Drawing.Size(245, 31);
            textclave.TabIndex = 30;

            // textusuario
            textusuario.Location = new System.Drawing.Point(155, 341);
            textusuario.Name = "textusuario";
            textusuario.PlaceholderText = "Usuario";
            textusuario.Size = new System.Drawing.Size(245, 31);
            textusuario.TabIndex = 29;

            // textcedula
            textcedula.Location = new System.Drawing.Point(155, 165);
            textcedula.Name = "textcedula";
            textcedula.PlaceholderText = "Cedula";
            textcedula.Size = new System.Drawing.Size(245, 31);
            textcedula.TabIndex = 28;
            textcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textcedula_KeyPress);

            // label6
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century", 10F);
            label6.Location = new System.Drawing.Point(62, 405);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 23);
            label6.TabIndex = 27;
            label6.Text = "Clave:";

            // label5
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century", 10F);
            label5.Location = new System.Drawing.Point(47, 345);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 23);
            label5.TabIndex = 26;
            label5.Text = "Usuario";

            // label3
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century", 10F);
            label3.Location = new System.Drawing.Point(55, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 23);
            label3.TabIndex = 25;
            label3.Text = "Cedula:";

            // panel1
            panel1.BackColor = System.Drawing.Color.RoyalBlue;
            panel1.Controls.Add(label4);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(806, 77);
            panel1.TabIndex = 24;

            // label4
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(129, 17);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(523, 42);
            label4.TabIndex = 7;
            label4.Text = "REGISTRAR ENFERMERO";

            // lblArea
            lblArea.AutoSize = true;
            lblArea.Font = new System.Drawing.Font("Century", 10F);
            lblArea.Location = new System.Drawing.Point(70, 275);
            lblArea.Name = "lblArea";
            lblArea.Size = new System.Drawing.Size(60, 23);
            lblArea.TabIndex = 23;
            lblArea.Text = "Area:";

            // label2
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century", 10F);
            label2.Location = new System.Drawing.Point(55, 219);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 23);
            label2.TabIndex = 22;
            label2.Text = "Turno:";

            // label1
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century", 10F);
            label1.Location = new System.Drawing.Point(51, 117);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 23);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";

            // txtNombre
            txtNombre.Location = new System.Drawing.Point(155, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre Completo";
            txtNombre.Size = new System.Drawing.Size(245, 31);
            txtNombre.TabIndex = 19;
            txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);

            // cboArea
            cboArea.Font = new System.Drawing.Font("Century", 10F);
            cboArea.Items.AddRange(new object[] {
            "Emergencias",
            "Urgencias",
            "Cuidados Intensivos (UCI)",
            "Cuidados Intensivos Neonatales (UCIN)",
            "Quirófano",
            "Recuperación Postquirúrgica",
            "Sala de Hospitalización"});
            cboArea.Location = new System.Drawing.Point(155, 275);
            cboArea.Name = "cboArea";
            cboArea.Size = new System.Drawing.Size(245, 33);
            cboArea.TabIndex = 35;

            // progressBar1
            progressBar1.Location = new System.Drawing.Point(79, 460);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(321, 20);
            progressBar1.TabIndex = 36;
            progressBar1.Visible = false;

            // RegistrarEnfermero
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 568);
            this.Controls.Add(progressBar1);
            this.Controls.Add(cboArea);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(cboTurno);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(textclave);
            this.Controls.Add(textusuario);
            this.Controls.Add(textcedula);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(panel1);
            this.Controls.Add(lblArea);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(txtNombre);
            this.Name = "RegistrarEnfermero";
            this.Text = "RegistrarEnfermero";
            this.Load += new System.EventHandler(this.RegistrarEnfermero_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textclave;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textcedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}