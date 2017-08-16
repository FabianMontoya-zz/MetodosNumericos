using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Funcion
{
    /// <summary>
    /// Ejecuta la función 3.2(x)^2 + 2.7(x) - 1.3 ; recibe valor para X y retorna resultado
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static double EjecutarFuncion(double x)
    {
        double result = 0;
        result = 3.2 * (Math.Pow(x, 2)) + 2.7 * (x) - 1.3;
        return result;
    }

    public static double ObtenerX2(double x0, double x1)
    {
        double result = 0;
        result = (x0 + x1) / 2;
        return result;
    }
}

