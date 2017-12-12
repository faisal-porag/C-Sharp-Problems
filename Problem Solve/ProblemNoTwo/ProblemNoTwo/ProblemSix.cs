using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemSix
    {
        public void getProuctOrSum()
        {
            Console.WriteLine("Enter a number > 1.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What you want to do ? Sum or Product.");
            string input = Console.ReadLine();


            if (input.Equals("sum"))
            {
                Console.WriteLine("Summation is " + ((n + 1) * (n) / 2));
            }
            else if (input.Equals("product"))
            {
                int product = 1;
                for (int i = 1; i < n; i++)
                {
                    product = product * i;
                }
                Console.WriteLine("Product is " + product);
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }
        }
    }
}
