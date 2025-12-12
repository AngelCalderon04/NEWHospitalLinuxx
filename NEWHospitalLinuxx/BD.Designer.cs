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
            progressBar1 = new ProgressBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(206, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 35);
            label1.TabIndex = 0;
            label1.Text = "REGISTROS";
            // 
            // button1
            // 
            button1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(239, 142);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(142, 27);
            button1.TabIndex = 1;
            button1.Text = "DOCTORES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(239, 190);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(142, 27);
            button2.TabIndex = 2;
            button2.Text = "ENFERMEROS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(258, 269);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(113, 30);
            button3.TabIndex = 3;
            button3.Text = "SALIR ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(239, 356);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(142, 14);
            progressBar1.TabIndex = 4;
            progressBar1.Visible = false;
            progressBar1.Click += progressBar1_Click;
            // 
            // BD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 382);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
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
        private ProgressBar progressBar1;
    }
}