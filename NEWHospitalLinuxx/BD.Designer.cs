namespace CapaPresentacion
{
    partial class BD
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(258, 24);
            label1.Name = "label1";
            label1.Size = new Size(246, 42);
            label1.TabIndex = 0;
            label1.Text = "REGISTROS";
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(299, 178);
            button1.Name = "button1";
            button1.Size = new Size(177, 34);
            button1.TabIndex = 1;
            button1.Text = "DOCTORES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(299, 237);
            button2.Name = "button2";
            button2.Size = new Size(177, 34);
            button2.TabIndex = 2;
            button2.Text = "ENFERMEROS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(323, 336);
            button3.Name = "button3";
            button3.Size = new Size(141, 37);
            button3.TabIndex = 3;
            button3.Text = "SALIR ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 478);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "BD";
            Text = "BD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}