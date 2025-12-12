using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
            progressBar1.Visible = false; // Ocultar al inicio
        }

        // ============================================================
        //              MÉTODO DE BARRA DE PROGRESO GLOBAL
        // ============================================================
        private async Task BarraDeCargaAsync()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(30); // Duración total 3 segundos
            }

            progressBar1.Visible = false;
        }

        // ============================================================
        //          BOTÓN REGISTRAR DOCTOR
        // ============================================================
        private async void button1_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();

            RegistrarDoctor form = new RegistrarDoctor();
            form.ShowDialog();
        }

        // ============================================================
        //          BOTÓN REGISTRAR ENFERMERO
        // ============================================================
        private async void button2_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();

            RegistrarEnfermero form = new RegistrarEnfermero();
            form.ShowDialog();
        }

        // ============================================================
        //      BOTÓN REGISTRAR PERSONAL ADMINISTRATIVO
        // ============================================================
        private async void button3_Click(object sender, EventArgs e)
        {
            await BarraDeCargaAsync();

            FormPersonalAdministrativo form = new FormPersonalAdministrativo();
            form.ShowDialog();
        }

        // ============================================================
        //      BOTÓN SALIR
        // ============================================================
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}