using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Funcion
{
    /// <summary>
    /// Función encargada de ejecutar la operación matemática con base en una variable que recibe
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static double ejecutarFuncion(double x)
    {
        double result = 0;
        result = (2 * x) - (Math.Cos(Math.Pow(x, 2)));
        return result;
    }

    /// <summary>
    /// Función encargada de obtener el defecto de los resultados de las dos funciones
    /// </summary>
    /// <param name="delta"></param>
    /// <param name="fx0"></param>
    /// <param name="fx1"></param>
    /// <returns></returns>
    public static double getDefecto(double delta, double fx0, double fx1)
    {
        double result = Math.Abs(fx0) <= Math.Abs(fx1) ? fx0 * delta : fx1 * delta;
        return result;
    }

    /// <summary>
    /// Función encargada de obtener el exceso de los resultados de las dos funciones
    /// </summary>
    /// <param name="delta"></param>
    /// <param name="fx0"></param>
    /// <param name="fx1"></param>
    /// <returns></returns>
    public static double getExceso(double delta, double fx0, double fx1)
    {
        double result = Math.Abs(fx0) <= Math.Abs(fx1) ? fx1 * delta : fx0 * delta;
        return result;
    }

    /// <summary>
    /// Función que retorna el valor total del calculo del trapecio
    /// </summary>
    /// <param name="delta"></param>
    /// <param name="fx0"></param>
    /// <param name="fx1"></param>
    /// <returns></returns>
    public static double getTrapecio(double delta, double fx0, double fx1)
    {
        double result = ((fx0 + fx1) * delta) / 2;
        return result;
    }

}

