using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemOne
    {
        public int PrintLargestElement()
        {
            int[] arr = { 5, 8, 2, 12, 4, 9, 23, 1, 32, 05, 7 };
            int large = arr[0];
            int lengthCount = arr.Length;
            if (lengthCount > 0)
            {              
                for (int i = 0; i < lengthCount; i++)
                {
                    if (large < arr[i])
                    {
                        int tmp = large;
                        large = arr[i];
                        arr[i] = large;
                    }
                }              
                
            }
            return large;
        }
    }
}
