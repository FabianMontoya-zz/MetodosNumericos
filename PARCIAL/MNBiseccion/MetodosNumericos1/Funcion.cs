using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Funcion
{  
    public static void Biseccion(double x0, double x1)
    {
        double x2 = 0;
        double x2Old = 0;

        double fx0 = 0;
        double fx1 = 0;
        double fx2 = 0;

        int Maxloops = 200;
        int loops = 0;
        while (loops <= Maxloops)
        {
            fx0 = Funcion.EjecutarFuncion(x0);
            fx1 = Funcion.EjecutarFuncion(x1);
            x2 = Funcion.ObtenerX2Bis(x0, x1);
            fx2 = Funcion.EjecutarFuncion(x2);
            Console.WriteLine("lop = " + loops + ") -- X0 =" + x0 + " ; X1 = " + x1 + " ; f(x0) =" + fx0 + " ; f(x1) =" + fx1 + ";");
            Console.WriteLine("x2 = " + x2 + " ; f(x2) = " + fx2);

            if (loops > 0)
            {
                //string abs = "" + Math.Abs(x2 - x2Old);

                double abs = Math.Abs(x2 - x2Old);

                Console.WriteLine("Absoluto = " + abs);

                //Console.WriteLine("Elevado: " + (xx * Math.Pow(10, 10)));

                if ((abs * Math.Pow(10, 10)) < 1 && (abs * Math.Pow(10, 10)) > 0) //Llegamos a E-11
                {
                    Console.WriteLine("===========================================");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("** La raiz es: " + x2);
                    break;
                }
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
    }

    public static void Secante(double x0, double x1)
    {

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
            x2 = Funcion.ObtenerX2Sec(M, B);
            Console.WriteLine("lop = " + loops + ") -- X0 =" + x0 + " ; X1 = " + x1 + " ; f(x0) =" + fx0 + " ; f(x1) =" + fx1 + ";");
            Console.WriteLine("M = " + M + " ; B = " + B + " ; x2 = " + x2 + " ;");
            if (loops > 0)
            {
                double abs = Math.Abs(x2 - x2Old);

                Console.WriteLine("Absoluto = " + abs);
                //Console.WriteLine("Elevado: " + (xx * Math.Pow(10, 10)));
                if ((abs * Math.Pow(10, 10)) < 1 && (abs * Math.Pow(10, 10)) > 0) //Llegamos a E-11
                {
                    Console.WriteLine("===========================================");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("** La raiz es: " + x2);
                    break;
                }
            }

            x1 = x2;
            x2Old = x2;
            loops++;
        }
    }
    public static double EjecutarFuncion(double x)
    {
        double result = 0;
        result = Math.Log(Math.Abs(2*x)) + (3* Math.Cos(8*x));
        return result;
    }

    //****************************************************************
    public static double ObtenerX2Bis(double x0, double x1)
    {
        double result = 0;
        result = (x0 + x1) / 2;
        return result;
    }
    public static double ObtenerM(double x0, double x1, double fx0, double fx1)
    {
        double result = 0;
        result = ((fx1) - (fx0)) / ((x1) - (x0));
        return result;
    }
    public static double ObtenerB(double x0, double fx0, double M)
    {
        double result = 0;
        result = (fx0) - (M) * (x0);
        return result;
    }

    public static double ObtenerX2Sec(double M, double B)
    {
        double result = 0;
        result = -(B) / (M);
        return result;
    }
   
}

