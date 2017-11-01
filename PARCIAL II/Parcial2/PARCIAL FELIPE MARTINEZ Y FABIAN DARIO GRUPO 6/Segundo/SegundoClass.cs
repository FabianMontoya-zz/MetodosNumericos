using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SegundoClass
{
    /// <summary>
    /// Función que ejecuta formula para cálculo de temperatura en cierta porción de tiempo
    /// </summary>
    /// <param name="T"></param>
    /// <param name="C"></param>
    /// <returns></returns>
    public double ejecutar_FuncionTemperatura(double T, double C)
    {
        double result = 1000 * (Math.Exp(-1 / (T + 273))) * C - (10 * (T - 20));
        return result;
    }

    /// <summary>
    /// Función que calcula la concentración en cierto momento en el tiempo
    /// </summary>
    /// <param name="T"></param>
    /// <param name="C"></param>
    /// <returns></returns>
    public double ejecutar_FuncionConcentracion(double T, double C)
    {
        double result = -(Math.Exp(-1 / (T + 273))) * C;
        return result;
    }

    
    
    public double obtener_K2(double resultFuncion, double H)
    {
        double result = resultFuncion + (H/2);
        return result;
    }
    public double obtener_K3(double resultFuncion, double H)
    {
        double result = resultFuncion + (H / 2);
        return result;
    }
    public double obtener_K4(double resultFuncion, double H)
    {
        double result = resultFuncion + H;
        return result;
    }

    public double obtener_Y1(double y0,double H, double K1,double K2, double K3, double K4)
    {
        double result = y0+(H/6)*(K1+(2*K2)+(2*K3)+K4);
        return result;
    }
}

