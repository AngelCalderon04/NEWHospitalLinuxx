using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            progressBar1.Visible = false; // Oculto al iniciar
        }

        // MÉTODO ASÍNCRONO (3 segundos)
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30);  // 30ms * 100 = 3 segundos
            }

            progressBar1.Visible = false;
        }

        private async void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();
            RegistroPaciente form = new RegistroPaciente();
            form.ShowDialog();
        }

        private async void btnAgendarCita_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();
            GestionCitas form = new GestionCitas();
            form.ShowDialog();
        }

        private async void btnRegistrarCONS_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();
            RegistrarConsulta form = new RegistrarConsulta();
            form.ShowDialog();
        }

        private async void btnHistorial_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();
            GestionHistorial form = new GestionHistorial();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();
            REGISTRO form = new REGISTRO();
            form.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();
            BD form = new BD();
            form.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}