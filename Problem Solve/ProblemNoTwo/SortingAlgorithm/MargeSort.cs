using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class MargeSort
    {
        public void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int p = 0; p < n1; ++p)
            {
                L[p] = arr[l + p];
            }
                
            for (int q = 0; q < n2; ++q)
            {
                R[q] = arr[m + 1 + q];
            }
               
            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays
            int i = 0, j = 0;

            // Initial index of merged subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that sorts arr[l..r] using
        // merge()
        public void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point
                int m = (l + r) / 2;

                // Sort first and second halves
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }

        public void printResult()
        {
            int[] arr = new int[] { 12, 11, 13, 5, 6, 7 };
            PrintMethod.printArray1("Marge Sort", arr);
            sort(arr, 0, arr.Length - 1);
            PrintMethod.printArray("Marge Sort", arr);
        }
    }
}
