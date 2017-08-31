using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos1
{
    class Program
    {
        Funcion funcion = new Funcion();


        static void Main(string[] args)
        {
           
            double x0 = 0.4;
            double x1 = 0.7;


            double x = 0.4;
            double h = 0.7;

            int contSec = 0, contDev = 0;

            List<double> resultSecante = new List<double>();
            List<double> resultDerivada = new List<double>();

            Console.WriteLine("==================================");
            Console.WriteLine("============ SECANTES ============");
            Console.WriteLine("==================================");
            do
            {
                resultSecante.Add(Funcion.Secante(x0, x1));
                x0 = x0 + 0.5;
                x1 = x1 + 0.5;
                contSec++;
            } while (resultSecante.Count <= 5);

            Console.WriteLine("===================================");
            Console.WriteLine("============ DERIVADAS ============");
            Console.WriteLine("===================================");
            do
            {
                resultDerivada.Add(Funcion.Derivada(x, h));
                x = x + 0.5;
                h = h + 0.5;
                contDev++;
            } while (resultDerivada.Count <= 15);

            Console.WriteLine("==================================");
            Console.WriteLine("============ SECANTES ============");
            Console.WriteLine("==================================");
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine("[" + i + "] - "+ resultSecante[i]);
            }
            Console.WriteLine("===================================");
            Console.WriteLine("============ DERIVADAS ============");
            Console.WriteLine("===================================");
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("[" + i + "] - " + resultDerivada[i]);
            }

            Console.ReadLine();
        }

    }
}


