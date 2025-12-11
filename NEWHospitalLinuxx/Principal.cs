using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            RegistroPaciente form = new RegistroPaciente();
            form.ShowDialog();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            GestionCitas form = new GestionCitas();
            form.ShowDialog();
        }

        private void btnRegistrarCONS_Click(object sender, EventArgs e)
        {
            RegistrarConsulta form = new RegistrarConsulta();
            form.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            GestionHistorial form = new GestionHistorial();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REGISTRO form = new REGISTRO();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BD form = new BD();
            form.ShowDialog();
        }
    }
}
