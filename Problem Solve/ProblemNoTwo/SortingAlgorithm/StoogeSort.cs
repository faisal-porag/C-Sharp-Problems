using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class StoogeSort
    {
        public void stoogesort(int[] arr, int l, int h)
        {
            if (l >= h)
                return;

            // If first element is smaller
            // than last,swap them
            if (arr[l] > arr[h])
            {
                int t = arr[l];
                arr[l] = arr[h];
                arr[h] = t;
            }

            // If there are more than 2 elements in
            // the array
            if (h - l + 1 > 2)
            {
                int t = (h - l + 1) / 3;

                // Recursively sort first 2/3 elements
                stoogesort(arr, l, h - t);

                // Recursively sort last 2/3 elements
                stoogesort(arr, l + t, h);

                // Recursively sort first 2/3 elements
                // again to confirm
                stoogesort(arr, l, h - t);
            }
        }

        public void printResult()
        {
            int[] arr = { 2, 4, 5, 3, 1 };
            PrintMethod.printArray1("Stooge Sort", arr);
            stoogesort(arr, 0, arr.Length - 1);
            
            Console.WriteLine();
            PrintMethod.printArray("Stooge Sort", arr);
            Console.WriteLine();
        }
    }
}
