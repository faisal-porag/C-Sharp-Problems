using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListThree
    {
        public void checknumber()
        {
            var storedList = new List<int>() { 5,3,6,4,2,9,15,13,17,15,25,14,4 };
            Console.Write("[ ");
            foreach (var list in storedList)
            {
                Console.Write(list + " ");
            }
            Console.Write("]");
            Console.WriteLine("\n");


            Console.WriteLine("Enter your number here ...");
            int input = Convert.ToInt32(Console.ReadLine());

            var count = 0;
            foreach (var result in storedList)
            {
                if (input == result)
                {
                    count++;
                }
                
            }
            if(count > 0)
            {
                Console.WriteLine("Exist");
                Console.WriteLine(count + " Times");
            }
            else
            {
                Console.WriteLine("Not exist");
            }
            
        }

    }
}
