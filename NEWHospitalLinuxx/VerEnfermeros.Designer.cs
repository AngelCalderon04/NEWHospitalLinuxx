namespace CapaPresentacion
{
    partial class VerEnfermeros
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
            dgvEnfermeros = new DataGridView();
            btnSalir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEnfermeros).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEnfermeros
            // 
            dgvEnfermeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnfermeros.Location = new Point(2, 83);
            dgvEnfermeros.Name = "dgvEnfermeros";
            dgvEnfermeros.RowHeadersWidth = 62;
            dgvEnfermeros.Size = new Size(791, 258);
            dgvEnfermeros.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(323, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(144, 43);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 57);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 19);
            label1.Name = "label1";
            label1.Size = new Size(513, 38);
            label1.TabIndex = 0;
            label1.Text = "ENFERMEROS REGISTRADOS ";
            // 
            // VerEnfermeros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(dgvEnfermeros);
            Name = "VerEnfermeros";
            Text = "VerEnfermeros";
            ((System.ComponentModel.ISupportInitialize)dgvEnfermeros).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEnfermeros;
        private Button btnSalir;
        private Panel panel1;
        private Label label1;
    }
}