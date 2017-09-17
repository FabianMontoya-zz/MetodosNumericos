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
<<<<<<< HEAD
            //PARCIAL PRIMER PUNTO, FABIAN FALTA HACER QUE EN EL PROCEDIMEINTO BISECCIÓN X2 SE GUARDE EN UNA MATRIZ Y QUE CADA VEZ QUE EL CICLO SE REPITA X1 O X0 AUMENTE 0.5 
            double x0 = 0.4;
            double x1 = 0.7;
            double x = 1.2;
            int contSec = 0, contDev = 0;
=======
           
            double x0 = 0.4;
            double x1 = 0.7;
>>>>>>> 0f96f939c997a6fe5cf4ffe3302fd7a1fc7564e3


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

<<<<<<< HEAD
        //    do
          //  {
          //      Funcion.Derivada (x,x0, x1);
           //     contSec++;
           // } while (contDev <= 14);
           
=======
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
>>>>>>> 0f96f939c997a6fe5cf4ffe3302fd7a1fc7564e3

            Console.ReadLine();
        }

    }
}


