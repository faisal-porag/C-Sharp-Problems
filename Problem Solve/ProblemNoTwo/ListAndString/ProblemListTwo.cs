using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListTwo
    {
        public void listReverse() {
            var numList = new List<int>() { 1, 2, 3, 4, 7, 8, 10, 12, 13, 14, 16 };

            numList.Reverse();

            foreach(var revList in numList)
            {
                Console.Write(revList + "\t");
            }
            Console.WriteLine();


        }
    }
}
