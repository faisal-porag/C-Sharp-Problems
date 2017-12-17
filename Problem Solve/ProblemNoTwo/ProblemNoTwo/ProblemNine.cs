using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemNine
    {
        public void guessSecretNumberGame()
        {
            var r = new Random();
            var num = r.Next(1,100);
            Console.WriteLine(num);

            var flag = true;
            var count = 0;
            Console.WriteLine("Enter your guess number between 1 to 100 ");

            do
            {
                Console.WriteLine("Enter your guess number ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                count++;

                if (inputNumber > num)
                {
                    Console.WriteLine("The number is large ");
                }
                else if (inputNumber < num )
                {
                    Console.WriteLine("The number is small ");
                }


                else
                {
                    Console.WriteLine("Your guessing number is matched");
                    Console.WriteLine("The namdom Number was : " + num);
                    Console.WriteLine("the number of tries " + count);
                    flag = false;
                }

            } while (flag);
        }

       

        public void guessSecretNumber()
        {
            var r = new Random();
            var num = r.Next(1, 100);
            //Console.WriteLine(num);

            var flag = true;
            Console.WriteLine("Note : Same number multiple times does not count.");
            Console.WriteLine("Enter your guess number between 1 to 100 ");
            List<int> list = new List<int>();

            do
            {
                Console.WriteLine("Enter your guess number ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                list.Add(inputNumber);

                if (inputNumber > num)
                {
                    Console.WriteLine("The number is large ");
                }

                else if (inputNumber < num)
                {
                    Console.WriteLine("The number is small ");
                }

                else
                {
                    Console.WriteLine("Your guessing number is matched");
                    Console.WriteLine("The namdom Number was : " + num);
                    Console.WriteLine("Number of tries : "+ list.Distinct().Count() + " times");

                    flag = false;
                }

            } while (flag);
        }

        //Get distinct element from a list 
        public void getDistincet()
        {
            List<int> list = new List<int> { 4, 3, 6, 9, 5, 2, 2};
            Console.WriteLine(list.Distinct().Count());
        }

        public void makeAList()
        {
            int num = 1;
            List<int> numberList = new List<int>();
            Console.WriteLine("Enter value which you want to store : ");

            do
            {
                int inputNum = Convert.ToInt32(Console.ReadLine());
                numberList.Add(inputNum);
                num++;

            } while (num < 5);

            Console.WriteLine(numberList[0] + " " + numberList[1]);
            

        }

    }
}
