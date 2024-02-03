using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Sorting
{
    internal class InsertionSort
    {
        public void insertionSort(int[] a, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = a[i];
                int pos = i;

                while(pos > 0 && a[pos - 1] > temp)
                {
                    a[pos] = a[pos - 1];
                    pos = pos - 1;
                }
                a[pos] = temp;
            }
        }

        public void display(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            InsertionSort sort = new InsertionSort();
            int[] a = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            sort.display(a, a.Length);
            sort.insertionSort(a, a.Length);
            Console.WriteLine("Sorted Array: ");
            sort.display(a, a.Length);
            Console.ReadKey();
        }
    }
}
