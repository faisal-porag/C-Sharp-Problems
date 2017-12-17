using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class BubbleSort
    {
        public void bubbleSort(int[] arr)
        {
            int lengthCount = arr.Length;
            for (int i = 0; i < lengthCount - 1; i++)
            {
                for (int j = 0; j < lengthCount - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                    
            }
                
        }

        public void printResult()
        {
            int[] arr = new int[] { 5, 3, 7, 1, 9, 2, 4, 6, 8 };
            PrintMethod.printArray1("Bubble Sort", arr);
            bubbleSort(arr);
            PrintMethod.printArray("Bubble Sort",arr);
        }



    }
}
