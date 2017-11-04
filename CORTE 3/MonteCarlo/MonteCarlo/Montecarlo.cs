using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo
{
    public partial class Montecarlo : Form
    {
        public Montecarlo()
        {
            InitializeComponent();
        }

        private void Montecarlo_Load(object sender, EventArgs e)
        {

        }
        private void rUnica_CheckedChanged(object sender, EventArgs e)
        {
            PVariasPruebas.Visible = false;

            txtTotalPuntos.Text = "";
            txtVolumen.Text = "";
            txtPromedio.Text = "";
            txtVarianza.Text = "";
            txtDesviaciónEstandar.Text = "";
            dataCalculosMontecarlo.DataSource = null;
            P_ResultUnico.Visible = true;
            P_ResultVarios.Visible = false;
        }

        private void rVarias_CheckedChanged(object sender, EventArgs e)
        {
            PVariasPruebas.Visible = true;

            txtTotalPuntos.Text = "";
            txtVolumen.Text = "";
            txtPromedio.Text = "";
            txtVarianza.Text = "";
            txtDesviaciónEstandar.Text = "";
            dataCalculosMontecarlo.DataSource = null;
            P_ResultUnico.Visible = false;
            P_ResultVarios.Visible = true;
            txtPruebas.Focus();
            txtPruebas.SelectAll();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double N = 0;
            double NumPruebas = 0;
            bool OK = false;
            bool varias = false;
            dataCalculosMontecarlo.DataSource = null;
            txtTotalPuntos.Text = "";
            txtVolumen.Text = "";
            txtPromedio.Text = "";
            txtVarianza.Text = "";
            try
            {
                a = double.Parse(txtA.Text.Trim());
                b = double.Parse(txtB.Text.Trim());
                c = double.Parse(txtC.Text.Trim());
                d = double.Parse(txtD.Text.Trim());
                N = double.Parse(txtN.Text.Trim());
                if (PVariasPruebas.Visible)
                {
                    NumPruebas = double.Parse(txtPruebas.Text.Trim());
                    varias = true;
                }
                OK = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos: " + ex.Message, "Error al capturar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (OK)
            {
                double Ancho = d - c;
                double Alto = b - a;

                Funciones funciones = new Funciones();
                

                double numX = funciones.getNumMayor(Math.Abs(c), Math.Abs(d)); //Para X
                double numY = funciones.getNumMayor(Math.Abs(a), Math.Abs(b)); //Para Y

                double z = funciones.getZ(numX, numY, 3); //Se envia el 3 por la función
                if (!varias)
                {
                    List<MontecarloClass> ListResult = new List<MontecarloClass>();
                    for (int i = 1; i <= N; i++)
                    {
                        MontecarloClass fila = new MontecarloClass();
                        fila.N = i;
                        fila.Xa = funciones.getXa(c, d);
                        fila.Ya = funciones.getYa(a, b);
                        fila.Za = funciones.getZa(z);
                        fila.Fxy = funciones.getFuncion(fila.Xa, fila.Ya);
                        fila.Criterio = fila.Za <= fila.Fxy ? 1 : 0;
                        ListResult.Add(fila);
                    }
                    double PuntosDentro = funciones.getTotalPuntos(ListResult);
                    double Volumen = funciones.getVolumen(PuntosDentro, N, Ancho, Alto, z);

                    dataCalculosMontecarlo.DataSource = ListResult;
                    txtTotalPuntos.Text = PuntosDentro.ToString();
                    txtVolumen.Text = Volumen.ToString();
                }
                else
                {
                    List<double> Volumenes = new List<double>();
                    for (int j = 1; j <= NumPruebas; j++)
                    {
                        List<MontecarloClass> ListResult = new List<MontecarloClass>();
                        for (int i = 1; i <= N; i++)
                        {
                            MontecarloClass fila = new MontecarloClass();
                            fila.N = i;
                            fila.Xa = funciones.getXa(c, d);
                            fila.Ya = funciones.getYa(a, b);
                            fila.Za = funciones.getZa(z);
                            fila.Fxy = funciones.getFuncion(fila.Xa, fila.Ya);
                            fila.Criterio = fila.Za <= fila.Fxy ? 1 : 0;
                            ListResult.Add(fila);
                        }
                        double PuntosDentro = funciones.getTotalPuntos(ListResult);
                        double Volumen = funciones.getVolumen(PuntosDentro, N, Ancho, Alto, z);
                        Volumenes.Add(Volumen);
                    }

                    double Promedio = funciones.getPromedio(Volumenes);
                    double Varianza = funciones.getVarianza(Volumenes, Promedio);

                    List<VolumenClass> volumenes = new List<VolumenClass>();
                    foreach(double item in Volumenes)
                    {
                        VolumenClass vol = new VolumenClass();
                        vol.Volumen = item;
                        volumenes.Add(vol);
                    }

                    dataCalculosMontecarlo.DataSource = volumenes;
                    double DE = Math.Sqrt(Varianza / (N - 1));
                    txtPromedio.Text = Promedio.ToString();
                    txtVarianza.Text = Varianza.ToString();
                    txtDesviaciónEstandar.Text = DE.ToString();
                }

            }
        }
       
    }
}
