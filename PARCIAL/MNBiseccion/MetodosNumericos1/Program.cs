﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos1
{
    class Program
    {
        Funcion funcion = new Funcion();


        static void Main(string[] args)
        {
            //PARCIAL PRIMER PUNTO, FABIAN FALTA HACER QUE EN EL PROCEDIMEINTO BISECCIÓN X2 SE GUARDE EN UNA MATRIZ Y QUE CADA VEZ QUE EL CICLO SE REPITA X1 O X0 AUMENTE 0.5 
            double x0 = 0;
            double x1 = 4;
            int cont=0;

            double ejecutar = 0;

            do
            {
                Funcion.Biseccion(x0, x1);
                cont++;
            } while (cont <= 6);
           
            //Console.WriteLine("Rango inicial para X0");

           

            Console.ReadLine();
        }

    }
        }
    
