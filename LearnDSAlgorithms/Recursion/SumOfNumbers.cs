using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Recursion
{
    internal class SumOfNumbers
    {
        //using formula
        public int Sum(int n)
        {
            return n * (n + 1) / 2;
        }

        //using iteration
        public int SumIteration(int n)
        {
            int sum = 0;
            int i = 1;
            while (i <= n)
            {
                sum= sum + i;
                i++;
            }
            return sum; 
        }

        //using recursion
        public int SumRecursion(int n)
        {
            if (n == 0)
                return 0;
            return SumRecursion(n - 1) + n;
        }

        static void Main()
        {
            SumOfNumbers s =new SumOfNumbers();
            Console.WriteLine("Sum: " + s.Sum(5));
            Console.WriteLine("Sum: " + s.SumIteration(5));
            Console.WriteLine("Sum: " + s.SumRecursion(5));
            Console.ReadKey();
        }
    }
}
