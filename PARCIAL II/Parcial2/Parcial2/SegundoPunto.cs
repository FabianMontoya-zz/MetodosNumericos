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
    public partial class SegundoPunto : Form
    {
        public SegundoPunto()
        {
            InitializeComponent();
        }

        private void CalcularEcuaciones()
        {
            try
            {
                double T0 = double.Parse(txtTempInicial.Text.ToString().Replace('.', ','));
                double C0 = double.Parse(txtConcInicial.Text.ToString().Replace('.', ','));
                double H = double.Parse(txtH.Text.ToString().Replace('.', ','));
                double Inicial = double.Parse(txtTiempoInicio.Text.ToString().Replace('.', ','));
                double Final = double.Parse(txtTiempoFin.Text.ToString().Replace('.', ','));
                double contador = Inicial;

                List<TemperaturaClass> listTemperatura = new List<TemperaturaClass>();
                List<ConcetracionClass> listConcentracion = new List<ConcetracionClass>();

                SegundoClass operaciones = new SegundoClass();
                TemperaturaClass temperatura;
                ConcetracionClass concentracion;

                double T = T0;
                double C = C0;

                while (contador <= Final)
                {
                    temperatura = new TemperaturaClass();
                    concentracion = new ConcetracionClass();

                    temperatura.Tiempo = contador;
                    concentracion.Tiempo = contador;

                    temperatura.Temperatura = T;
                    concentracion.Concentracion = C;

                    temperatura.Funcion = operaciones.ejecutar_FuncionTemperatura(T, C);
                    concentracion.Funcion = operaciones.ejecutar_FuncionConcentracion(T, C);

                    temperatura.K1 = temperatura.Funcion; //Se ejecuta la función
                    concentracion.K1 = concentracion.Funcion; //Se ejecuta la función

                    temperatura.K2 = operaciones.obtener_K2(temperatura.Funcion, H);
                    concentracion.K2 = operaciones.obtener_K2(concentracion.Funcion, H);
                    
                    temperatura.K3 = operaciones.obtener_K3(temperatura.Funcion, H);
                    concentracion.K3 = operaciones.obtener_K3(concentracion.Funcion, H);

                    temperatura.K4 = operaciones.obtener_K4(temperatura.Funcion, H);
                    concentracion.K4 = operaciones.obtener_K4(concentracion.Funcion, H);

                    temperatura.ResultadoTemperatura = operaciones.obtener_Y1(T, H, temperatura.K1, temperatura.K2, temperatura.K3, temperatura.K4);
                    concentracion.ResultadoConcentracion = operaciones.obtener_Y1(C, H, concentracion.K1, concentracion.K2, concentracion.K3, concentracion.K4);

                    T = temperatura.ResultadoTemperatura;
                    C = concentracion.ResultadoConcentracion;

                    listConcentracion.Add(concentracion);
                    listTemperatura.Add(temperatura);

                    contador = contador + H;
                }

                dataGridConcentración.DataSource = listConcentracion;
                dataGridTemperatura.DataSource = listTemperatura;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridConcentración.DataSource = null;
            dataGridTemperatura.DataSource = null;
            CalcularEcuaciones();
        }
    }
}
