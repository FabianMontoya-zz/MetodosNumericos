using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos1
{
    class Program
    {
        Funcion funciones = new Funcion();
        static void Main(string[] args)
        {

            double x0 = 0;
            double x1 = 4;
            double x2 = 0;

            double fx0 = 0;
            double fx1 = 0;
            double fx2 = 0;
            //Console.WriteLine("Rango inicial para X0");
            //x0 = Double.Parse(Console.ReadLine());
            int Maxloops = 50;
            int loops = 0;

            while (loops <= Maxloops)
            {
                fx0 = Funcion.EjecutarFuncion(x0);
                fx1 = Funcion.EjecutarFuncion(x1);
                x2 = Funcion.ObtenerX2(x0, x1);
                fx2 = Funcion.EjecutarFuncion(x2);

                if()

                loops++;
            }
        }

        
    }
}
