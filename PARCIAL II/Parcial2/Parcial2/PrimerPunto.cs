﻿using System;
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
    public partial class PrimerPunto : Form
    {
        public PrimerPunto()
        {
            InitializeComponent();
        }

        private void CalcularFuncion()
        {
            double A = double.Parse(txtA.Text.ToString().Replace('.', ','));
            double B = double.Parse(txtB.Text.ToString().Replace('.', ','));
            double C = double.Parse(txtC.Text.ToString().Replace('.', ','));
            double D = double.Parse(txtD.Text.ToString().Replace('.', ','));

            double N = double.Parse(txtN.Text.ToString());

            double deltaX = (D - C) / N;
            double deltaY = (B - A) / N;

            List<VolumenClass> listVolumen = new List<VolumenClass>();
            VolumenClass volumen;
            PrimerClass operaciones = new PrimerClass();

            volumen = new VolumenClass();

            volumen.X = C;
            volumen.Y = C;
            double y0 = C;
            double x0 = C;
            volumen.Fxy = operaciones.ejecutar_Funcion(volumen.X, volumen.Y);
            volumen.volumen = deltaX * deltaY * volumen.Fxy;
            double volumenTotal = volumen.volumen;

            listVolumen.Add(volumen);

            for (double j = A; j <= B; j = j + deltaX)
            {
                for (double i = C; i < D; i = i + deltaY)
                {
                    volumen = new VolumenClass();
                    y0 = y0 + deltaY;
                    volumen.X = x0;
                    volumen.Y = y0;
                    volumen.Fxy = operaciones.ejecutar_Funcion(volumen.X, volumen.Y);
                    volumen.volumen = deltaX * deltaY * volumen.Fxy;
                    listVolumen.Add(volumen);
                    volumenTotal = volumenTotal + volumen.volumen;
                }

                if (x0 < B)
                {
                    x0 = x0 + deltaX;
                    y0 = C;
                }
            }
            dataGridResult.DataSource = listVolumen;
            txtVolFinal.Text = volumenTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridResult.DataSource = null;
            CalcularFuncion();
        }
    }
}
