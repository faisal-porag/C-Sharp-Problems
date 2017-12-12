using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne one = new ProblemOne();
            //Console.WriteLine(one.PrintLargestElement() + " is largest element in this list");

            ProblemListOne listOne = new ProblemListOne();
            //Console.WriteLine(listOne.PrintLargest() + " is largest element in this list");

            ProblemListTwo listTwo = new ProblemListTwo();
            //listTwo.listReverse();


            //-------------------
            int[] arr = new int[] { 2, 4, 6, 8, 10 }; //Result 30
            int counter = arr.Length;
            int sum = 0;

            ProblemListSeven listSeven = new ProblemListSeven();

            Console.WriteLine(listSeven.forLoopMethod(counter, arr) + " From For loop Method");
            Console.WriteLine(listSeven.whileLoopMethod(counter, arr) + " From While loop Method");
            Console.WriteLine(listSeven.recursiveMethod(sum,counter, arr) + " From Recursive Method");


        }
    }
}
