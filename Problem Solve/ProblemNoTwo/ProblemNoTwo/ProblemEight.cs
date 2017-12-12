using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemEight
    {
        public void getAllPrimeNumber()
        {
            const int setNumber = 2000;
            bool isPrime = true;
            Console.WriteLine("Prime numbers represent from 1 to 2000 :");
            for (int i = 2; i <= setNumber; i++)
            {
                for (int j = 2; j < setNumber; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + "\t");
                }
                
                isPrime = true;
            }
            Console.WriteLine();
        }

    }
}
