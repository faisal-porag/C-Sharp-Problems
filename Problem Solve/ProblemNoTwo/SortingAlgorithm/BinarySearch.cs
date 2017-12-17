using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class BinarySearch
    {
        public int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then it can only
                // be present in left subarray
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present in right
                // subarray
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present in array
            return -1;
        }

        public void printResult()
        {
            int[] arr = new int[] { 2, 3, 4, 10, 40, 8, 41, 85, 36, 46 };
            int limit = arr.Length - 1;
            Console.WriteLine("Search here your number : ");
            int searchingNumber = Convert.ToInt32(Console.ReadLine());
            
            int getResult = binarySearch(arr, 0, limit, searchingNumber);
            if (getResult == -1)
            {
                Console.WriteLine("Element not present");
            }
            else {
                Console.WriteLine("Element present at index no : " + getResult);
            }
                
        }

        /*
         
            We basically ignore half of the elements just after one comparison.

            Compare x with the middle element.
            If x matches with middle element, we return the mid index.
            Else If x is greater than the mid element, then x can only lie in right half subarray after the mid element. So we recur for right half.
            Else (x is smaller) recur for the left half.
            Recursive implementation of Binary Search

        
        */


    }
}
