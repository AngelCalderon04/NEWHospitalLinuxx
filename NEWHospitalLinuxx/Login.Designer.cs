namespace NEWHospitalLinuxx
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(244, 11);
            label1.Name = "label1";
            label1.Size = new Size(333, 42);
            label1.TabIndex = 0;
            label1.Text = "HOSPITA LINUX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 107);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 1;
            label2.Text = "USUARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 173);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 2;
            label3.Text = "CLAVE:";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(366, 103);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "USUARIO";
            textUsuario.Size = new Size(232, 31);
            textUsuario.TabIndex = 3;
            // 
            // textClave
            // 
            textClave.Location = new Point(366, 169);
            textClave.Name = "textClave";
            textClave.PlaceholderText = "contrasena";
            textClave.Size = new Size(232, 31);
            textClave.TabIndex = 4;
            textClave.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(259, 255);
            button1.Name = "button1";
            button1.Size = new Size(147, 34);
            button1.TabIndex = 5;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(473, 255);
            button2.Name = "button2";
            button2.Size = new Size(141, 34);
            button2.TabIndex = 6;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CapaPresentacion.Properties.Resources._new;
            pictureBox1.Location = new Point(-36, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 252);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 368);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textClave);
            Controls.Add(textUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
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
    }
}
