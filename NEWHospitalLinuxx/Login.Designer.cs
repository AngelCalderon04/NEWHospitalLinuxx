namespace NEWHospitalLinuxx
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUsuario = new TextBox();
            textClave = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 35);
            label1.TabIndex = 0;
            label1.Text = "HOSPITA LINUX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F);
            label2.Location = new Point(198, 86);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "USUARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F);
            label3.Location = new Point(207, 138);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "CLAVE:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(293, 82);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "USUARIO";
            textUsuario.Size = new Size(186, 27);
            textUsuario.TabIndex = 3;
            // 
            // textClave
            // 
            textClave.Location = new Point(293, 135);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "contrasena";
            textClave.Size = new Size(186, 27);
            textClave.TabIndex = 4;
            textClave.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Century", 10F);
            button1.Location = new Point(207, 204);
            button1.Name = "button1";
            button1.Size = new Size(118, 27);
            button1.TabIndex = 5;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Century", 10F);
            button2.Location = new Point(378, 204);
            button2.Name = "button2";
            button2.Size = new Size(113, 27);
            button2.TabIndex = 6;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CapaPresentacion.Properties.Resources._new;
            pictureBox1.Location = new Point(-29, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(207, 274);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(272, 16);
            progressBar1.TabIndex = 8;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 300);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textClave);
            Controls.Add(textUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUsuario;
        private TextBox textClave;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}