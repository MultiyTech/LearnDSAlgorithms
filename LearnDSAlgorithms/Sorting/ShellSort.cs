 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Sorting
{
    internal class ShellSort
    {
        public void shellSort(int[] a, int n)
        {
            int gap = n / 2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = a[i];
                    int j = i - gap;
                    while (j >= 0 && a[j] > temp)
                    {
                        a[j + gap] = a[j];
                        j = j - gap;
                    }
                    a[j + gap] = temp;
                    i = i + 1;
                }
                gap = gap / 2;
            }
        }

        public void display(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            ShellSort shell = new ShellSort();
            int[] a = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            shell.display(a, a.Length);
            shell.shellSort(a, a.Length);
            Console.WriteLine("Sorted Array: ");
            shell.display(a, a.Length);
            Console.ReadKey();
        }
    }
}
