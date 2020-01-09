using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanck02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = 10; //Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20,20 }; // Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
            Console.WriteLine($"total pair of socks : {result}");
            Console.ReadKey();



        }

        static int sockMerchant(int n, int[] ar)
        {
            var socksOrderBy = ar.ToList().GroupBy(p => p);
            int totalPairOfSocks = 0;
            foreach (var i in socksOrderBy)
            {
                totalPairOfSocks += i.Count() / 2;
            }

            return totalPairOfSocks;
        }
    }
}
