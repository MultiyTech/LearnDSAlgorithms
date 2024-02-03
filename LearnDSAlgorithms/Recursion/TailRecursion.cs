using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Recursion
{
    internal class TailRecursion
    {
        public void CalculateIterative(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateIterative(n-1);
            }
        }
        static void Main()
        {
            TailRecursion p = new TailRecursion();
            Console.WriteLine("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iteration of "+num+ "is"+" ");
            p.CalculateIterative(num);
            Console.ReadKey();
        }
    }
}
