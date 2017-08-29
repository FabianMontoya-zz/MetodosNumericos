using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Funcion
{
    /// <summary>
    /// Ejecuta la función F(x) = xe^x recibe valor para X y retorna resultado
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static double EjecutarFuncion1(double x)
    {
        double result = 0;
        result = (x) * Math.Exp((x));
        return result;
    }
    /// <summary>
    /// Función que retorna el valor que ha de obtener H según un valor inicial obtenido
    /// </summary>
    /// <param name="h"></param>
    /// <returns></returns>
    public static double obtenerH(double h)
    {
        double result = 0;
        result = (h) * Math.Pow(10, (-1));
        return result;
    }
    /// <summary>
    /// Función que devuelve la diferencial entre el resultado de la funciones F(x) y F(x+h) dividido en el valor de H
    /// </summary>
    /// <param name="Fx"></param>
    /// <param name="fxh"></param>
    /// <param name="h"></param>
    /// <returns></returns>
    public static double obtenerDiferencial(double Fx, double Fxh, double h)
    {
        double result = 0;
        result = ((Fxh) - (Fx)) / (h);
        return result;
    }
}
