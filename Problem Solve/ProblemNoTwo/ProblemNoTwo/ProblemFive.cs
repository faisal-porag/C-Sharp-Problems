using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemFive
    {
        public void summationFunction()
        {
            Console.WriteLine("Enter a number ");
            int getNum = Convert.ToInt32(Console.ReadLine());
            int storeResult = 0;
            

            for (int i = 1; i <= getNum; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    //Console.WriteLine(i);
                    storeResult = storeResult + i;
                }
                    
            }

            Console.WriteLine(storeResult);
        }
    }
}
