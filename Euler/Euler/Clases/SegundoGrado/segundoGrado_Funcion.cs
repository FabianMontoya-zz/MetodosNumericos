using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class segundoGrado_Funcion
{
    /// <summary>
    /// Función encargada de calcular el resultado de la función 2 + xy + (Cos(x) * u)
    /// </summary>
    /// <param name="x0"></param>
    /// <param name="y0"></param>
    /// <param name="u0"></param>
    /// <returns></returns>
    public double calcularFuncion(double x0, double y0, double u0)
    {
        double result = 0;
        result = 2 + (x0 * y0) + (Math.Cos(x0) * u0);
        return result;
    }

    /// <summary>
    /// Función que se encarga de calcular U1 de acuerdo a unos parametros que recibe
    /// </summary>
    /// <param name="u0"></param>
    /// <param name="H"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public double obtenerU1_Adelante(double u0, double H, double f)
    {
        double result = u0 + (H * f);
        return result;
    }
    /// <summary>
    /// Función encargada de calcular Y1 deacuerdo a los parametros recibidos
    /// </summary>
    /// <param name="y0"></param>
    /// <param name="H"></param>
    /// <param name="u0"></param>
    /// <returns></returns>
    public double obtenerY1_Adelante(double y0, double H, double u0)
    {
        double result = y0 + (H * u0);
        return result;
    }

    /// <summary>
    /// Función que se encarga de calcular U1 de acuerdo a unos parametros que recibe
    /// </summary>
    /// <param name="u0"></param>
    /// <param name="H"></param>
    /// <param name="f"></param>
    /// <returns></returns>
    public double obtenerU1_Atras(double u0, double H, double f)
    {
        double result = u0 - (H * f);
        return result;
    }
    /// <summary>
    /// Función encargada de calcular Y1 deacuerdo a los parametros recibidos
    /// </summary>
    /// <param name="y0"></param>
    /// <param name="H"></param>
    /// <param name="u0"></param>
    /// <returns></returns>
    public double obtenerY1_Atras(double y0, double H, double u0)
    {
        double result = y0 - (H * u0);
        return result;
    }
}

