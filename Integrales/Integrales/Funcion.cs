using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Funcion
    {
        public static double EjecutarFuncion(double x)
        {
            double result = 0;
            result =(2 * x) -(Math.Cos(Math.Pow(x, 2)));
            return result;
        }

    }

