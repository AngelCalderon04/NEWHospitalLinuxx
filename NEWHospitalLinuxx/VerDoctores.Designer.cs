namespace CapaPresentacion
{
    partial class VerDoctores
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
            dgvDoctores = new DataGridView();
            btnSalir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDoctores
            // 
            dgvDoctores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctores.Location = new Point(8, 91);
            dgvDoctores.Name = "dgvDoctores";
            dgvDoctores.RowHeadersWidth = 62;
            dgvDoctores.Size = new Size(782, 250);
            dgvDoctores.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(357, 392);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR ";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 20);
            label1.Name = "label1";
            label1.Size = new Size(461, 38);
            label1.TabIndex = 0;
            label1.Text = "DOCTORES REGISTRADOS ";
            // 
            // VerDoctores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(dgvDoctores);
            Name = "VerDoctores";
            Text = "VerDoctores";
            ((System.ComponentModel.ISupportInitialize)dgvDoctores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDoctores;
        private Button btnSalir;
        private Panel panel1;
        private Label label1;
    }
}