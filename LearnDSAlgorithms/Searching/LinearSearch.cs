using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Searching
{
    internal class LinearSearch
    {
        public int linearSearch(int[] a,int n, int key)
        {
            int index = 0;
            while(index < n)
            {
                if(a[index] == key)
                    return index;
                index++;
            }
            return -1;
        }

        static void Main()
        {
            LinearSearch ls = new LinearSearch();
            int[] a = { 84, 21, 25, 47, 96, 15 };
            int n = ls.linearSearch(a, 6, 25);
            Console.WriteLine("Result:" + n);
            Console.ReadKey();
        }
    }
}
