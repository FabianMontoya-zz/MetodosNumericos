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

            

           

            do
            {
                Funcion.Secante (x0, x1);
                contSec++;
            } while (contSec <= 5);

        //    do
          //  {
          //      Funcion.Derivada (x,x0, x1);
           //     contSec++;
           // } while (contDev <= 14);
           

            Console.ReadLine();
        }

    }
        }
    

