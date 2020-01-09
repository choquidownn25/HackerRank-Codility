using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Day_2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor moneda local \n");
            double meal_cost = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ponrcentaje \n");
            int tip_percent = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Impuesto \n");
            int tax_percent = Int32.Parse(Console.ReadLine());
            solve(meal_cost, tip_percent, tax_percent);

          
        }

        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tip + tax;
            Console.WriteLine("El valor total  " + Math.Round(totalCost) + " en dollars.");
            Console.ReadKey();

        }
    }
}
