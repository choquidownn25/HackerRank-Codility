using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_dos
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] A = {4,1,3,2};
            solution(A);
            Console.ReadKey();
        }

        public static int solution(int[] A)
        {
            int result = 1;
            int[] count = new int[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= A.Length && count[A[i]] == 0)
                {
                    count[A[i]]++;
                    Console.Write(count[A[i]] + " \n");
                }
            }
            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] == 0)
                {
                    result = 0;
                    Console.Write(count[i] + " \n");
                    break;
                }
            }
            return result;
        }
    }
}
