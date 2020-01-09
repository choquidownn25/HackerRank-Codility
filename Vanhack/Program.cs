using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanhack
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24;

            fizzBuzz(n);
            Console.ReadKey();
        }
        public static void fizzBuzz(int n)
        {




            // repita hasta n
            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz" + " \n");

                }
                else
                {
                   

                    // numero divisible por 3
                    if (i % 3 == 0)
                        Console.Write("Fizz" + " \n");

                    // numero divisible por 5
                    else if (i % 5 == 0)
                        Console.Write("Buzz" + " \n");

                    // imprimir otros numeros 
                    else
                        Console.Write(i + " \n");
                }


            }


        }
    }
}
