using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Codility_Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24;

            solution(n);

            Console.ReadKey();
        }

        public static void solution(int N)
        {
            // repita hasta n
            for (int i = 1; i <= N; i++)
            {

                if ( i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CodilityTest" + " \n");

                }
                else
                {
                    // numero divisible por 2  

                    if (i % 2 == 0)
                        Console.Write("Codility" + " \n");

                    // numero divisible por 3
                    else if (i % 3 == 0)
                        Console.Write("Test" + " \n");

                    // numero divisible por 5
                    else if (i % 5 == 0)
                        Console.Write("CodilityCoders" + " \n");

                    // imprimir otros numeros 
                    else
                        Console.Write(i + " \n");
                }


            }
        }

    }
}
