using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace CaminosAleatorios
{
    public partial class CaminosAleatorios : Form
    {

        List<Experimento> Experimento = new List<Experimento>();
        public CaminosAleatorios()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            bool datos = false;
            int experimentos = 0;
            int pasos = 0;
            dataGridDatos.DataSource = null;
            try
            {
                experimentos = int.Parse(txtExperimentos.Text);
                pasos = int.Parse(txtPasos.Text);
                datos = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, " + ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Si la captura de datos estuvo bien
            if (datos)
            {
                //Matriz Donde guardaremos todos los datos del experimento
                List<Experimento> Caminos = new List<Experimento>();
                //Cantidad de experimentos a realizar (Veces que se inicia desde el punto cero)            
                for (int i = 1; i <= experimentos; i++)
                {
                    //Paso que va a dar
                    for (int j = 1; j <= pasos; j++)
                    {
                        Experimento paso = new Experimento();
                        paso.NumeroExperimento = i;
                        paso.NumeroPaso = j;

                        //Generamos número aleatorio
                        Thread.Sleep(2);
                        Random r = new Random(DateTime.Now.Millisecond);
                        double AL = r.NextDouble();

                        //Seleccionamos dirección deseada según criterio
                        if (AL <= 0.25)//Izquierda
                        {
                            paso.PasoHacia = "Izquierda";
                        }
                        else if (AL > 0.25 && AL <= 0.5)//Arriba
                        {
                            paso.PasoHacia = "Arriba";
                        }
                        else if (AL > 0.5 && AL <= 0.75)//Derecha
                        {
                            paso.PasoHacia = "Derecha";
                        }
                        else //Abajo
                        {
                            paso.PasoHacia = "Abajo";
                        }

                        Caminos.Add(paso);
                    }
                }
                //Guardamos los resultados en la variable global
                Experimento = Caminos;
                //Mostramos los datos obtenidos en la tabla de la pantalla
                dataGridDatos.DataSource = Experimento;
            }
        }

        private void btnDowload_Click(object sender, EventArgs e)
        {
            if (Experimento.Count > 0)
            {
                MessageBox.Show("Recuerde que si ha descargado algún resultado antes y no lo ha movido o renombrado el sistema lo remplazará automaticamente", "Información Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ExportToExcel.CreateExcelFile.CreateExcelDocument(Experimento, @"C:\Users\Public\Documents\DatosExperimentoPasos.xlsx");
                
                MessageBox.Show(@"El archivo « DatosExperimentoPasos.xlsx » se ha creado en la ruta C:\Users\Acceso Público\Documentos públicos", "Archivo Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(@"C:\Users\Public\Documents\");
            }
            else
            {
                MessageBox.Show("Lo sentimos, aún no ha generado ningún experimento, por lo cual no se tienen datos para descargar.", "Sin Datos disponibles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
