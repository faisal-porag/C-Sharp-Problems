using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListFive
    {
        public void countTotalNumberOfList()
        {
            List<int> listElement = new List<int>() {1, 2, 5, 8, 3, 9, 4, 2, 56, 7, 2};
            var count = listElement.Count;
            Console.Write("[ ");
            foreach (var list in listElement)
            {
                Console.Write(list + " ");
            }
            Console.Write("]");
            Console.WriteLine("\n");

            Console.WriteLine("Total of a list is " + count);

        }
    }
}
