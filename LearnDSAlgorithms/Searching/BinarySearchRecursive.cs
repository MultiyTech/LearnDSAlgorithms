using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Searching
{
    internal class BinarySearchRecursive
    {
        public int binarySearch(int[] a, int key, int l, int r)
        {
            if (l > r)
                return -1;
            else
            {
                int mid = (l + r)/2;
                if (key == a[mid])
                    return mid;
                else if (key < a[mid])
                    return binarySearch(a, key, l, mid - 1);
                else if (key > a[mid])
                    return binarySearch(a, key, mid + 1, r);
            }
            return - 1;
        }

        static void Main()
        {
            BinarySearchRecursive recursive = new BinarySearchRecursive();
            int[] a = { 25, 21, 86, 47, 96, 15 };
            int found = recursive.binarySearch(a, 25, 0, a.Length - 1);
            Console.WriteLine("Result :" + found);
            Console.ReadKey();
        }
    }
}
