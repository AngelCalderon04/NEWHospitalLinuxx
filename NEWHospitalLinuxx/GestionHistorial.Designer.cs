namespace CapaPresentacion
{
    partial class GestionHistorial
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            cboPaciente = new ComboBox();
            btnBuscar = new Button();
            btnSalir = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvHistorial = new DataGridView();
            label3 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.RoyalBlue;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(0, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1116, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 102);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 1;
            label2.Text = "PACIENTE:";
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(157, 99);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(193, 33);
            cboPaciente.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(374, 101);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(132, 31);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(524, 100);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 33);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(12, 150);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.Size = new Size(990, 434);
            dgvHistorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(454, 47);
            label3.TabIndex = 1;
            label3.Text = "HISTORIAL MEDICO";
            // 
            // GestionHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 650);
            Controls.Add(dgvHistorial);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(cboPaciente);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Name = "GestionHistorial";
            Text = "GestionHistorial";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ComboBox cboPaciente;
        private Button btnBuscar;
        private Button btnSalir;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvHistorial;
        private Label label3;
    }
}