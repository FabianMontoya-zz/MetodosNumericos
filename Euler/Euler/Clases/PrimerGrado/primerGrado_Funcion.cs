using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class primerGrado_Funcion
{
    /// <summary>
    /// Función encargada de devolver el cálculo resultante de la función RaizCuadrada(x/(Cos^2(x)+1))
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public double CalcularFuncion(double x)
    {
        double result = 0;
        result = Math.Sqrt(x / ((Math.Pow(Math.Cos(x), 2)) + 1));
        return result;
    }

    /// <summary>
    /// Función encargada de calcular el Y1 de acuerdo a los datos recibidos
    /// </summary>
    /// <param name="y0"></param>
    /// <param name="H"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public double obtenerY1_Adelante(double y0, double H, double f)
    {
        double result = y0 + (H*f);
        return result;
    }

    /// <summary>
    /// Función encargada de calcular el Y1 de acuerdo a los datos recibidos
    /// </summary>
    /// <param name="y0"></param>
    /// <param name="H"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public double obtenerY1_Atras(double y0, double H, double f)
    {
        double result = y0 - (H * f);
        return result;
    }
}

