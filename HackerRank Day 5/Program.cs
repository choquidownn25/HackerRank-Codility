using System;

namespace HackerRank_Day_5
{
    class Program
    {
        public int age;
        public Program(int initialAge)
        {
            // Add some more code to run some checks on initialAge

            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                Console.WriteLine("La edad no es válida, estableciendo la edad en 0.");
                age = 0;
            }

        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 

            if (age < 13)
            {
                Console.WriteLine("Eres joven.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("Eres un adolescente.");
            }
            else
            {
                Console.WriteLine("Eres viejo.");
            }

        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age += 1;
        }

        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Program  p = new Program(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
