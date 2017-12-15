using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemNine
    {
        public void guessSecretNumber()
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

       



        public void guessSecretNumber1()
        {
            var r = new Random();
            var num = r.Next(1, 100);
            Console.WriteLine(num);

            var flag = true;
            //var count = 0;
            Console.WriteLine("Enter your guess number between 1 to 100 ");

            do
            {
                Console.WriteLine("Enter your guess number ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                List<int> list = new List<int>();
                //count++;


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
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("the number of tries " + list.Count());
                    flag = false;
                }

            } while (flag);
        }
    }
}
