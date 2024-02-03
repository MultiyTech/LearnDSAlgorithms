using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDSAlgorithms.Sorting
{
    internal class BubbleSort
    {
        public void bubbleShort(int[] a, int n)
        {
            for(int pass = n-1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
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
            BubbleSort bubble = new BubbleSort();
            int[] a = { 3, 5, 9, 8, 6, 2 };
            Console.WriteLine("Original Array :");
            bubble.display(a, a.Length);
            bubble.bubbleShort(a, a.Length);
            Console.WriteLine("Sorted Array :");
            bubble.display(a, a.Length);
            Console.ReadKey();
        }
    }
}
