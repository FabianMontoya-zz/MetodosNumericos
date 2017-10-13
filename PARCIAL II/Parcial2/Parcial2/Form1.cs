using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimerPunto p = new PrimerPunto();
            p.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SegundoPunto p = new SegundoPunto();
            p.ShowDialog();
        }
    }
}
