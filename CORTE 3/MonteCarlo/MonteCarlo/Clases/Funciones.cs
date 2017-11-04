using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Funciones
{
    /// <summary>
    /// Función que compara dos números y devuelve cuál es el mayor entre ellos
    /// </summary>
    /// <param name="Num1"></param>
    /// <param name="Num2"></param>
    /// <returns></returns>
    public double getNumMayor(double Num1, double Num2)
    {
        double result = 0;
        result = Num1 >= Num2 ? Num1 : Num2;
        return result;
    }
    /// <summary>
    /// Obtiene el total de puntos que quedaron dentro de los rangos de la función
    /// </summary>
    /// <param name="Datos"></param>
    /// <returns></returns>
    public double getTotalPuntos(List<MontecarloClass> Datos)
    {
        double result = 0;
        for (int i = 0; i < Datos.Count; i++)
        {
            result = result + Datos[i].Criterio;
        }
        return result;
    }

    /// <summary>
    /// Obtiene el promedio de un número de datos que se reciben de una lista de doubles
    /// </summary>
    /// <param name="Datos"></param>
    /// <returns></returns>
    public double getPromedio(List<double> Datos)
    {
        double result = 0;
        double sumatoria = 0;
        for (int i = 0; i < Datos.Count; i++)
        {
            sumatoria = sumatoria + Datos[i];
        }

        result = sumatoria / Datos.Count;
        return result;
    }

    /// <summary>
    /// Obtiene la varianza de unos datos dados frente a un promedio ya calculado
    /// </summary>
    /// <param name="Datos"></param>
    /// <param name="Promedio"></param>
    /// <returns></returns>
    public double getVarianza(List<double> Datos, double Promedio)
    {
        double result = 0;

        List<double> XmenosPromedio = new List<double>();
        List<double> XmenosPromedioElevado = new List<double>();
        for (int i = 0; i < Datos.Count; i++)
        {
            double Xi = Datos[i] - Promedio;
            XmenosPromedio.Add(Xi);
            XmenosPromedioElevado.Add(Math.Pow(Xi, 2));
        }

        double numerador = 0;
        for (int j = 0; j < XmenosPromedioElevado.Count; j++)
        {
            numerador = numerador + XmenosPromedioElevado[j];
        }

        double denominador = Datos.Count - 1;

        result = numerador / denominador;

        return result;
    }

    /// <summary>
    /// Obtener el valor de Z
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public double getZ(double a, double b, double c)
    {
        double result = 0;
        //Según función
        result = Math.Pow(a, 2) + Math.Pow(b, 2) + c;
        result = result + 1;
        return result;
    }
    /// <summary>
    /// Obtener el valor aleatorio de Za
    /// </summary>
    /// <param name="Z"></param>
    /// <returns></returns>
    public double getZa(double Z)
    {
        double result = 0;
        // Wait to allow the timer to advance.
        Thread.Sleep(2);
        //Random r = new Random(DateTime.Now.Millisecond);
        Random r = new Random(DateTime.Now.Millisecond);

        double AL = r.NextDouble();
        result = AL * Z;
        return result;
    }
    /// <summary>
    /// Obtener el valor de Xa
    /// </summary>
    /// <param name="c"></param>
    /// <param name="d"></param>
    /// <returns></returns>
    public double getXa(double c, double d)
    {
        double result = 0;
        // Wait to allow the timer to advance.
        Thread.Sleep(2);
        //var r = new Random((int)DateTime.Now.Ticks);
        Random r = new Random(DateTime.Now.Millisecond);
        double AL = r.NextDouble();
        result = AL * (d - c) + c;
        return result;
    }
    /// <summary>
    /// Obtener el valor de Ya
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public double getYa(double a, double b)
    {
        double result = 0;
        // Wait to allow the timer to advance.
        Thread.Sleep(2);
        Random r = new Random(DateTime.Now.Millisecond);
        double AL = r.NextDouble();
        result = AL * (b - a) + a;
        return result;
    }
    /// <summary>
    /// Obtener el valor final de la función deacuerdo a los valores de X y Y
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public double getFuncion(double x, double y)
    {
        double result = 0;
        result = Math.Pow(x, 2) + Math.Pow(y, 2) + 3;
        return result;
    }
    /// <summary>
    /// Obtiene el valor del volumen según los datos obtenidos
    /// </summary>
    /// <param name="PuntosDentro"></param>
    /// <param name="TotalPuntos"></param>
    /// <param name="Ancho"></param>
    /// <param name="Alto"></param>
    /// <param name="Z"></param>
    /// <returns></returns>
    public double getVolumen(double PuntosDentro, double TotalPuntos, double Ancho, double Alto, double Z)
    {
        double result = 0;
        result = (PuntosDentro / TotalPuntos) * Ancho * Alto * Z;
        return result;
    }
}

