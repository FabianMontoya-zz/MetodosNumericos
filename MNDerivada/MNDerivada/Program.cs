using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNDerivada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Donde X
            double x = 1.2;
            double h = 1;

            double xh = 0;
            double Fx = 0;
            double Fxh = 0;
            double df = 0;
            double dfOld = 0;

            List<DiferencialClass> results = new List<DiferencialClass>();
            int loops = 1;

            while(loops <= 20)
            {
                Console.WriteLine("- Loop: "+loops);
                Console.WriteLine("");
                Console.WriteLine("H = "+h+"  -  X = "+x);
                xh = x + h;
                Fx = Funcion.EjecutarFuncion1(x);
                Fxh = Funcion.EjecutarFuncion1(xh);
                df = Funcion.obtenerDiferencial(Fx, Fxh, h);
                Console.WriteLine("X+H = "+xh+"  -  F(x) = "+Fx+"  -  F(x+h) = "+Fxh);
                Console.WriteLine("DF = "+df);
                if (loops > 1)
                {
                    double abs = Math.Abs(df - dfOld);
                    if (abs != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Absoluto = " + abs);
                        DiferencialClass res = new DiferencialClass();
                        res.Resultado = abs;
                        res.Diferencial = df;
                        results.Add(res);
                    }else
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
            int tam = results.Count -1;
            double numMenor = results[0].Resultado;
            for (int i = 1; i <= tam; i++)
            {
                Console.WriteLine("- Result["+i+"] = "+results[i].Resultado);
                Console.WriteLine("- Diferencial = " + results[i].Diferencial);
                Console.WriteLine("=====================");
                if(results[i].Resultado < numMenor)
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
                    Console.WriteLine("El número más pequeño es: "+numMenor);
                    Console.WriteLine("Corresponde al Diferencial: " + results[i].Diferencial);
                    break;
                }
            }

            Console.ReadLine();
            
        }
    }
}
