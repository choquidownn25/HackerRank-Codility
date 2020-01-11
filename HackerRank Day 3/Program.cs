using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 2 && N < 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && N > 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }

            Console.ReadKey();
        }
    }
}

///* Objetivo
//En este desafío, comenzamos con declaraciones condicionales. ¡Mira la pestaña Tutorial para materiales de aprendizaje y un video instructivo!

//Tarea
//Dado un número entero, realice las siguientes acciones condicionales:

//Si es extraño, imprima Extraño
//Si es par y está en el rango inclusivo de to, imprima Not Weird
//Si es par y está en el rango inclusivo de to, imprime Weird
//Si es par y mayor que, imprima Not Weird
//Complete el código auxiliar provisto en su editor para imprimir si es extraño o no.

//Formato de entrada

//Una sola línea que contiene un entero positivo,.

//Restricciones

//Formato de salida

//Imprimir raro si el número es raro; de lo contrario, imprima Not Weird.
