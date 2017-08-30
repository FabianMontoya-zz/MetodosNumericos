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
            //PARCIAL PRIMER PUNTO, FABIAN FALTA HACER QUE EN EL PROCEDIMEINTO BISECCIÓN X2 SE GUARDE EN UNA MATRIZ Y QUE CADA VEZ QUE EL CICLO SE REPITA X1 O X0 AUMENTE 0.5 
            double x0 = 0.4;
            double x1 = 0.7;
            double x = 1.2;
            int contSec = 0, contDev = 0;
            List<double> resultSecante = new List<double>();
            List<double> resultDerivada = new List<double>();
            do
            {
                resultSecante.Add(Funcion.Secante(x0, x1));
                x0 = x0 + 0.5;
                x1 = x1 + 0.5;
                contSec++;
            } while (resultSecante.Count <= 6);

            x0 = 0.4;
            x1 = 0.7;

            do
            {
                resultDerivada.Add(Funcion.Derivada(x, x0, x1));
                x0 = x0 + 0.5;
                x1 = x1 + 0.5;
                contDev++;
            } while (resultDerivada.Count <= 6);


            Console.ReadLine();
        }

    }
}


