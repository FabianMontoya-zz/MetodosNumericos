using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Funcion
{

    public static double EjecutarFuncionQuiz(double x)
    {
        double result = 0;
        double elevado = Math.Pow(x, 2);
        result = Math.Pow(x, elevado);
        return result;
    }

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

    public static double EjecutarFuncion2(double x)
    {
        //F(x) = 60(x^45)-32(x^33)+233(x^5)-47(x^2)-77
        double result = 0;
        result = (60 * (Math.Pow(x, 45))) - (32 * (Math.Pow(x, 33))) + (233 * (Math.Pow(x, 5))) - (47 * (Math.Pow(x, 2))) -77;
        return result;
    }

    public static double EjecutarFuncion3(double x)
    {
         //tan(cos((sqrt(5+sen(x))/(1+x2))
        double result = 0;
        result = Math.Tan(Math.Cos((Math.Sqrt(5) + Math.Sin(x)) / (1 + (Math.Pow(x, 2)))));
        return result;
    }

    public static double EjecutarFuncion4(double x)
    {
       //sen(cos(1/x))
        double result = 0;
        result = Math.Sin(Math.Cos(1 / x));
        return result;
    }

    public static double EjecutarFuncion5(double x)
    {
        //sen((x^3)-7(x^2)+6(x)+8) 
        double result = 0;
        result = Math.Sin((Math.Pow(x, 3))+ (7*(Math.Pow(x, 2))) +6*(x) + 8);
        return result;
    }

    public static double EjecutarFuncion6(double x)
    {
        //((x)^x)^x )
        double result = 0;
        result = (Math.Pow(x, ((Math.Pow(x, x)))));
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
