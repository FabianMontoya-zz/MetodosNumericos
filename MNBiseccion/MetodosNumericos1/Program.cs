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
            double x2Old = 0;

            double fx0 = 0;
            double fx1 = 0;
            double fx2 = 0;
            //Console.WriteLine("Rango inicial para X0");
            //x0 = Double.Parse(Console.ReadLine());
            int Maxloops = 200;
            int loops = 0;

            while (loops <= Maxloops)
            {
                fx0 = Funcion.EjecutarFuncion(x0);
                fx1 = Funcion.EjecutarFuncion(x1);
                x2 = Funcion.ObtenerX2(x0, x1);
                fx2 = Funcion.EjecutarFuncion(x2);
                Console.WriteLine("lop = " + loops + ") -- X0 =" + x0 + " ; X1 = " + x1 + " ; f(x0) =" + fx0 + " ; f(x1) =" + fx1 + ";");
                Console.WriteLine("x2 = " + x2 + " ; f(x2) = " + fx2);
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
                if (fx0 * fx2 >= 0)
                {
                    x0 = x2;
                    Console.WriteLine("**Cambiamos x0 por x2");

                }
                else
                {
                    x1 = x2;

                    Console.WriteLine("**Cambiamos x1 por x2");
                }
                x2Old = x2;
                loops++;
            }

            Console.ReadLine();
        }


    }
}
