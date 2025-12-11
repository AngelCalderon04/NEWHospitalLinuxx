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
    public partial class BD : Form
    {
        public BD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerDoctores form = new VerDoctores();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerEnfermeros form = new VerEnfermeros();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
