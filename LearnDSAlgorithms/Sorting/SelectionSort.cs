using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Sorting
{
    internal class SelectionSort
    {
        public void selectionSort(int[] a, int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                int pos = i;

                for (int j = i+1; j < n; j++)
                {
                    if(a[j] < a[pos])
                        pos = j;
                }
                int temp = a[i];
                a[i] = a[pos];
                a[pos] = temp;
            }
        }

        public void display(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            SelectionSort s = new SelectionSort();
            int[] a = { 3,5,8,9,6,2};
            Console.WriteLine("Original Array: ");
            s.display(a, a.Length);
            s.selectionSort(a, a.Length);
            Console.WriteLine("Sorted Array: ");
            s.display(a, a.Length);
            Console.ReadKey();
        }
    }
}
