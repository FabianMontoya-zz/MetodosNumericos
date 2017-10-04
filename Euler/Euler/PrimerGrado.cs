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
    public partial class PrimerGrado : Form
    {
        public PrimerGrado()
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

            double H = (rangFinal - rangInicial) / N;

            List<Euler1Class> listAdelante = new List<Euler1Class>();
            List<Euler1Class> listAtras = new List<Euler1Class>();
            
            primerGrado_Funcion Calculos = new primerGrado_Funcion();

            double Cy0 = y0;
            double Cx0 = x0;
            while (Cx0 <= rangFinal)
            {
                Euler1Class Result = new Euler1Class();
                Result.x0 = Cx0;
                Result.y0 = Cy0;

                Result.f = Calculos.CalcularFuncion(Cx0);
                Result.y1 = Calculos.obtenerY1_Adelante(Cy0, H, Result.f);

                listAdelante.Add(Result);

                Cx0 = Result.x0 + H;
                Cy0 = Result.y1;
            }

            Cy0 = y0;
            Cx0 = x0;
            while (Cx0 >= rangInicial)
            {
                Euler1Class Result2 = new Euler1Class();
                Result2.x0 = Cx0;
                Result2.y0 = Cy0;

                Result2.f = Calculos.CalcularFuncion(Cx0);
                Result2.y1 = Calculos.obtenerY1_Atras(Cy0, H, Result2.f);

                listAtras.Add(Result2);

                Cx0 = Result2.x0 - H;
                Cy0 = Result2.y1;
            }

            dataGridAdelante.DataSource = listAdelante;
            dataGrid_Atras.DataSource = listAtras;
        }

        #region "Key Changes"
        private void txtRangInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Para obligar a que sólo se introduzcan números 
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan 
            //    e.Handled = true;
            //}
        }

        private void TXTRangFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Para obligar a que sólo se introduzcan números 
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan 
            //    e.Handled = true;
            //}
        }

        private void TXTy0_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Para obligar a que sólo se introduzcan números 
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan 
            //    e.Handled = true;
            //}
        }

        private void TXTx0_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Para obligar a que sólo se introduzcan números 
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan 
            //    e.Handled = true;
            //}
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////Para obligar a que sólo se introduzcan números 
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    //el resto de teclas pulsadas se desactivan 
            //    e.Handled = true;
            //}
        }
        #endregion

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dataGridAdelante.DataSource = null;
            dataGrid_Atras.DataSource = null;
            if (TXTRangInicial.Text.Length > 0 && TXTRangFinal.Text.Length > 0
                && TXTy0.Text.Length > 0 && TXTx0.Text.Length > 0 && txtN.Text.Length > 0)
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
