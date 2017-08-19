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
    /// <summary>
    /// Obtiene la pendiente
    /// </summary>
    /// <param name="x0"></param>
    /// <param name="x1"></param>
    /// <param name="fx0"></param>
    /// <param name="fx1"></param>
    /// <returns></returns>
    public static double ObtenerM(double x0, double x1, double fx0, double fx1)
    {
        double result = 0;
        result = ((fx1) - (fx0)) / ((x1) - (x0));
        return result;
    }
    /// <summary>
    /// Obtiene el punto de corte
    /// </summary>
    /// <param name="x0"></param>
    /// <param name="fx0"></param>
    /// <param name="fx1"></param>
    /// <returns></returns>
    public static double ObtenerB(double x0, double fx0, double M)
    {
        double result = 0;
        result = (fx0) - (M) * (x0);
        return result;
    }
    public static double ObtenerX2(double M, double B)
    {
        double result = 0;
        result = -(B) / (M);
        return result;
    }
}
