using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class QuickSort
    {
        public int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1); // index of smaller element
            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high]
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

       
        public void sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);

                // Recursively sort elements before
                // partition and after partition
                sort(arr, low, pi - 1);
                sort(arr, pi + 1, high);
            }
        }

        public void printResult()
        {
            int[] arr = new int[] { 10, 7, 8, 9, 1, 5 };
            PrintMethod.printArray1("Quick Sort", arr);
            sort(arr, 0, arr.Length - 1);
            PrintMethod.printArray("Quick Sort", arr);
        }
    }
}
