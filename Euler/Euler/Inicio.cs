using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_PrimerGrado_Click(object sender, EventArgs e)
        {
            PrimerGrado pr = new PrimerGrado();
            pr.ShowDialog();
        }

        private void btn_SegundoGrado_Click(object sender, EventArgs e)
        {
            SegundoGrado sg = new SegundoGrado();
            sg.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Desarrollado por Fabian Montoya :D
        }
    }
}
