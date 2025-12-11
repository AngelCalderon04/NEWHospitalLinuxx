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
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarDoctor form = new RegistrarDoctor();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarEnfermero Form = new RegistrarEnfermero();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formPersonalAdministrativo form = new formPersonalAdministrativo();
            form.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
