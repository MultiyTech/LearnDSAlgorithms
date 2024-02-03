using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Recursion
{
    internal class HeadRecursion
    {
        public void Calculate(int n)
        {
            if (n > 0)
            {
                Calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        static void Main()
        {
            HeadRecursion p2 = new HeadRecursion();
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iteration of " + n + "is" + " ");
            p2.Calculate(n);
            Console.ReadKey();
        }
    }
}
