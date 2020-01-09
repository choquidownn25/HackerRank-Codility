using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int j;    // Declaration of second Integer, Double, and String variables.
            double e;
            string NewString;
            j = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());
            NewString = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(j + i);
            Console.WriteLine("{0:F1}", d + e);
            Console.WriteLine(s + NewString);
            // Print the sum of the double variables on a new line.
            Console.ReadKey();
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
        }
    }
}
