using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Recursion
{
    internal class TreeRecursion
    {
        public void Calculate(int n)
        {
            if (n > 0)
            {
                Calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                Calculate(n-1);
            }
        }

        static void Main()
        {
            TreeRecursion t = new TreeRecursion();
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Output is");
            t.Calculate(num);
            Console.ReadKey();
        }
    }
}
