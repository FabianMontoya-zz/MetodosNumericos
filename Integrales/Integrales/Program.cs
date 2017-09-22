using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrales
{
    class Program
    {
        static void Main(string[] args)
        {

            double A = -1; //Rango Inicial
            double B = 0; //Rango final
            double N = 10; //Cantidad de rectangulos
            double DELTA = (B - A) / N;

            double x0 = A;
            double x1 = x0 + DELTA;
            double Fx0 = 0;
            double Fx1 = 0;
            double DEFEC = 0;
            double EXCES = 0;
            double TRAP = 0;

            double TotalDEFEC = 0;
            double TotalEXCES = 0;
            double TotalTRAP = 0;

            //Comenzamos a realizar cada uno de los registros hasta alcanzar la cantidad requerida
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i+")  x0: " + x0 + "  ||  x1:" + x1);
                Fx0 = Funcion.ejecutarFuncion(x0);
                Fx1 = Funcion.ejecutarFuncion(x1);
                Console.WriteLine("Fx0: " + Fx0 + "  ||  Fx1:" + Fx1);

                DEFEC = Funcion.getDefecto(DELTA, Fx0, Fx1);
                EXCES = Funcion.getExceso(DELTA, Fx0, Fx1);
                TRAP = Funcion.getTrapecio(DELTA, Fx0, Fx1);
                Console.WriteLine("DEFEC: " + DEFEC + "  ||  EXCES:" + EXCES + "  ||  TRAP:" + TRAP);

                TotalDEFEC = TotalDEFEC + DEFEC;
                TotalEXCES = TotalEXCES + EXCES;
                TotalTRAP = TotalTRAP + TRAP;

                x0 = x1;
                x1 = x0 + DELTA;
                Console.WriteLine("====================================================================");
                Console.WriteLine("====================================================================");
            }
            Console.WriteLine("");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("*======================= RESULTADOS ===============================*");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("TotalDEFEC: " + TotalDEFEC + "  ||  TotalEXCES:" + TotalEXCES + "  ||  TotalTRAP:" + TotalTRAP);
            Console.ReadLine();
        }
    }
}
