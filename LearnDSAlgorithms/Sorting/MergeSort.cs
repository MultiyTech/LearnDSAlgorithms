using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Sorting
{
    internal class MergeSort
    {
        public void mergeSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                mergeSort(a, left, mid);
                mergeSort(a, mid + 1, right);
                merge(a, left, mid, right);
            }
        }

        public void merge(int[] a, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] b = new int[right + 1];
            while(i<=mid && j <= right)
            {
                if (a[i] < a[j])
                {
                    b[k] = a[i];
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                b[k] = a[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                b[k]= a[j];
                j = j + 1;
                k = k + 1;
            }
            for(int x = left; x < right+1; x++)
                a[x]= b[x];
        }

        public void display(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            MergeSort ms = new MergeSort();
            int[] a = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            ms.display(a, a.Length);
            ms.mergeSort(a, 0, a.Length - 1);
            Console.WriteLine("Sorted Array: ");
            ms.display(a, a.Length);
            Console.ReadKey();
        }
    }
}
