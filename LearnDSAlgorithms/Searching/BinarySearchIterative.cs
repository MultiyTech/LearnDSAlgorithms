using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Searching
{
    internal class BinarySearchIterative
    {
        public int binarySearch(int[] a, int n, int key)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (key == a[mid])
                    return mid;
                else if (key < a[mid])
                    r = mid - 1;
                else if(key > a[mid])
                    l = mid + 1;
            }
            return -1;
        }

        static void Main()
        {
            BinarySearchIterative iterative = new BinarySearchIterative();
            int[] a = { 25, 21, 86, 47, 96, 15 };
            int found = iterative.binarySearch(a, 6, 25);
            Console.WriteLine("Result :" + found);
            Console.ReadKey();
        }
    }
}
