using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNSecante
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0;
            double x1 = 4;
            double x2 = 0;
            double x2Old = 0;

            double fx0 = 0;
            double fx1 = 0;
            double M = 0;
            double B = 0;
            //Console.WriteLine("Rango inicial para X0");
            //x0 = Double.Parse(Console.ReadLine());
            int Maxloops = 200;
            int loops = 0;

            while (loops <= Maxloops)
            {
                fx0 = Funcion.EjecutarFuncion(x0);
                fx1 = Funcion.EjecutarFuncion(x1);
                M = Funcion.ObtenerM(x0, x1, fx0, fx1);
                B = Funcion.ObtenerB(x0, fx0, M);
                x2 = Funcion.ObtenerX2(M, B);
                Console.WriteLine("lop = " + loops + ") -- X0 =" + x0 + " ; X1 = " + x1 + " ; f(x0) =" + fx0 + " ; f(x1) =" + fx1 + ";");
                Console.WriteLine("M = " + M + " ; B = " + B + " ; x2 = " + x2 + " ;");
                if (loops > 0)
                {
                    string abs = "" + Math.Abs(x2 - x2Old);
                    Console.WriteLine("Absoluto = " + abs);
                    int tam = abs.Length;
                    try
                    {
                        string notacion = abs.Substring((tam - 4), 4);
                        if (notacion.ToUpper().Contains("E-11"))
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("===========================================");
                            Console.WriteLine("** La raiz es: " + x2);
                            break;
                        }
                    }
                    catch { }
                }

                x1 = x2;
                x2Old = x2;
                loops++;
            }

            Console.ReadLine();


        }
    }
}
