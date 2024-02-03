using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Recursion
{
    internal class Factorial
    {
        public int factorialiterative(int n)
        {
            int fact = 1;
            for(int i = 1;i<= n;i++)
                fact = fact*i;
            return fact;
        }

        public int factorialRecursive(int n)
        {
            if (n == 0)
                return 1;
            return factorialiterative(n-1) * n;
        }

        static void Main()
        {
            Factorial factorial = new Factorial();
            Console.WriteLine("Factorial:" + factorial.factorialiterative(5));
            Console.WriteLine("Factorial:" + factorial.factorialRecursive(5));
            Console.ReadKey();
        }
    }
}
