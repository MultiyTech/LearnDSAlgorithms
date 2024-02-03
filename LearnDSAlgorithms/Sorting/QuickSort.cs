using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Sorting
{
    internal class QuickSort
    {
        public void quickSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int p = partition(a, low, high);
                quickSort(a, low, p - 1);
                quickSort(a, p + 1, high);
            }
        }

        public int partition(int[] a, int low, int high)
        {
            int pivot = a[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && a[i] <= pivot)
                    i = i + 1;
                while (i <= j && a[j] > pivot)
                    j = j - 1;
                if (i <= j)
                    swap(a, i, j);

            }while(i < j);
            swap(a, low, j);
            return j;
        }

        public void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public void display(int[] a, int n)
        {
            for(int i = 0;i < n;i++)
                Console.Write(a[i]+" ");
            Console.WriteLine();
        }

        static void Main()
        {
            QuickSort quick = new QuickSort();
            int[] a = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            quick.display(a, a.Length);
            quick.quickSort(a, 0, a.Length - 1);
            Console.WriteLine("Sorted Array: ");
            quick.display(a, a.Length);
            Console.ReadKey();
        }
    }
}
