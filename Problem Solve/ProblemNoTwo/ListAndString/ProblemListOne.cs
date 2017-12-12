using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListOne
    {
        public int PrintLargest()
        {
            var numberList = new List<int>() { 5, 8, 2, 12, 4, 9, 23, 1, 32, 05, 7 };
            int large = numberList[0];
            int lengthCount = numberList.Count;
            if (lengthCount > 0)
            {
                for (int i = 0; i < lengthCount; i++)
                {
                    if (large < numberList[i])
                    {
                        int tmp = large;
                        large = numberList[i];
                        numberList[i] = large;
                    }
                }

            }
            return large;
        }
    }
}
