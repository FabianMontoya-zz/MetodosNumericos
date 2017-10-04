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
    public partial class SegundoGrado : Form
    {
        public SegundoGrado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FUnción encargada de ejecutar la función de cálculo de Euler (Primer grado) y muestra los resultados en un dataTable
        /// </summary>
        private void calcularEuler()
        {
            double y0 = double.Parse(TXTy0.Text.ToString());
            double x0 = double.Parse(TXTx0.Text.ToString());

            double rangInicial = double.Parse(TXTRangInicial.Text.ToString());
            double rangFinal = double.Parse(TXTRangFinal.Text.ToString());

            double N = double.Parse(txtN.Text.ToString());
            double u0 = double.Parse(txtPrimeraDerivada.Text);

            double H = (rangFinal - rangInicial) / N;

            List<Euler2Class> listAdelante = new List<Euler2Class>();
            List<Euler2Class> listAtras = new List<Euler2Class>();

            segundoGrado_Funcion Calculos = new segundoGrado_Funcion();

            double Cy0 = y0;
            double Cx0 = x0;
            double Cu0 = u0;
            while (Cx0 <= rangFinal)
            {
                Euler2Class Result = new Euler2Class();
                Result.x0 = Cx0;
                Result.y0 = Cy0;
                Result.u0 = Cu0;

                Result.f = Calculos.calcularFuncion(Cx0, Cy0, Cu0);
                Result.y1 = Calculos.obtenerY1_Adelante(Cy0, H, Cu0);
                Result.u1 = Calculos.obtenerU1_Adelante(Cu0, H, Result.f);

                listAdelante.Add(Result);

                Cx0 = Result.x0 + H;
                Cy0 = Result.y1;
                Cu0 = Result.u1;
            }

            Cy0 = y0;
            Cx0 = x0;
            Cu0 = u0;

            while (Cx0 >= rangInicial)
            {
                Euler2Class Result2 = new Euler2Class();
                Result2.x0 = Cx0;
                Result2.y0 = Cy0;
                Result2.u0 = Cu0;

                Result2.f = Calculos.calcularFuncion(Cx0, Cy0, Cu0);
                Result2.y1 = Calculos.obtenerY1_Atras(Cy0, H, Cu0);
                Result2.u1 = Calculos.obtenerU1_Atras(Cu0, H, Result2.f);

                listAtras.Add(Result2);

                Cx0 = Result2.x0 - H;
                Cy0 = Result2.y1;
                Cu0 = Result2.u1;
            }

            dataGridAdelante.DataSource = listAdelante;
            dataGrid_Atras.DataSource = listAtras;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dataGridAdelante.DataSource = null;
            dataGrid_Atras.DataSource = null;
            if (TXTRangInicial.Text.Length > 0 && TXTRangFinal.Text.Length > 0
                && TXTy0.Text.Length > 0 && TXTx0.Text.Length > 0 
                && txtN.Text.Length > 0 && txtPrimeraDerivada.Text.Length > 0)
            {
                calcularEuler();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos para poder ejecutar la función de Cálculo.\nFavor validar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
