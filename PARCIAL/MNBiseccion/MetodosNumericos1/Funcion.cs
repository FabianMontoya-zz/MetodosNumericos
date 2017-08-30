using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Funcion
{  
   //*********************SECANTE

    public static double Secante(double x0, double x1)
    {
        double result = 0;
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
                    result = x2;
                    break;
                }
            }

            x1 = x2;
            x2Old = x2;
            loops++;
        }
        return result;
    }

   
    public static double EjecutarFuncion(double x)
    {
        double result = 0;
        result = Math.Log(Math.Abs(2*x)) + (3* Math.Cos(8*x));
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

   //****************DERIVADA


    public static double Derivada(double x, double x0, double x1)
    {

        //Donde X
        double result = 0;
        double h = 1;

        double xh = 0;
        double Fx = 0;
        double Fxh = 0;
        double df = 0;
        double dfOld = 0;

        List<MetodosNumericos1.DiferencialClass> results = new List<MetodosNumericos1.DiferencialClass>();
        int loops = 1;

        while (loops <= 20)
        {
            Console.WriteLine("- Loop: " + loops);
            Console.WriteLine("");
            Console.WriteLine("H = " + h + "  -  X = " + x);
            xh = x + h;
            Fx = Funcion.EjecutarFuncion(x);
            Fxh = Funcion.EjecutarFuncion(xh);
            df = Funcion.obtenerDiferencial(Fx, Fxh, h);
            Console.WriteLine("X+H = " + xh + "  -  F(x) = " + Fx + "  -  F(x+h) = " + Fxh);
            Console.WriteLine("DF = " + df);
            if (loops > 1)
            {
                double abs = Math.Abs(df - dfOld);
                if (abs != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Absoluto = " + abs);
                    MetodosNumericos1.DiferencialClass res = new MetodosNumericos1.DiferencialClass();
                    res.Resultado = abs;
                    res.Diferencial = df;
                    results.Add(res);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Absoluto = " + abs);
                    break;
                }
            }
            Console.WriteLine("====================================================");
            h = Funcion.obtenerH(h);
            dfOld = df;
            loops++;
        }
        Console.WriteLine("");
        Console.WriteLine("==================**************************======================");
        int tam = results.Count - 1;
        double numMenor = results[0].Resultado;
        for (int i = 1; i <= tam; i++)
        {
            Console.WriteLine("- Result[" + i + "] = " + results[i].Resultado);
            Console.WriteLine("- Diferencial = " + results[i].Diferencial);
            Console.WriteLine("=====================");
            if (results[i].Resultado < numMenor)
            {
                numMenor = results[i].Resultado;
            }
        }
        for (int i = 1; i <= tam; i++)
        {
            if (results[i].Resultado == numMenor)
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("********************** RESPUESTA ***********************");
                Console.WriteLine("========================================================");
                Console.WriteLine("El número más pequeño es: " + numMenor);
                Console.WriteLine("Corresponde al Diferencial: " + results[i].Diferencial);
                result = results[i].Diferencial;
                break;
            }
        }

        return result;

    }

    public static double obtenerH(double h)
    {
        double result = 0;
        result = (h) * Math.Pow(10, (-1));
        return result;
    }

    public static double obtenerDiferencial(double Fx, double Fxh, double h)
    {
        double result = 0;
        result = ((Fxh) - (Fx)) / (h);
        return result;
    }
}

