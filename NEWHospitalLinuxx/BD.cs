using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();

            progressBar1.Visible = false; // Oculta la barra al iniciar
        }

        // MÉTODO DE BARRA DE CARGA (3 segundos)
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30); // 30ms * 100 = 3 segundos
            }

            progressBar1.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync(); // Simulación de carga

            VerDoctores form = new VerDoctores();
            form.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();

            VerEnfermeros form = new VerEnfermeros();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}