using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemFour
    {
        public void addNumber()
        {
            
            int storeResult = 0;
            Console.WriteLine("Enter a number ");
            int getNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= getNum; i++)
            {
                storeResult =storeResult + i;
            }

            Console.WriteLine(" the sum of the numbers 1 to n is : " + storeResult);
        }
    }
}
