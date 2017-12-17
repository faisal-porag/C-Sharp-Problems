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
            ProblemListOne listOne = new ProblemListOne();
            //Console.WriteLine(listOne.PrintLargest() + " is the largest element.");

            ProblemListTwo listTwo = new ProblemListTwo();
            //listTwo.listReverse();

            ProblemListThree listThree = new ProblemListThree();
            //listThree.checknumber();

            ProblemListFour listFour = new ProblemListFour();
            //listFour.GetOddPositionElement(); 
            
            ProblemListFive listFive = new ProblemListFive();
            //listFive.countTotalNumberOfList();                                                                                                                                                                                                                                                                                                                     


            ProblemListSix listSix = new ProblemListSix();
            //listSix.getStatus();
            //var flag = listSix.getStatus1("BBA");
            //Console.WriteLine(flag);


            //-------------------
            int[] arr = new int[] { 2, 4, 6, 8, 10 }; //Result 30
            int counter = arr.Length;
            List<int> list = new List<int> { 2, 4, 6, 8, 10 }; //Result 30
            int counter1 = list.Count;
            int sum = 0;

            ProblemListSeven listSeven = new ProblemListSeven();

            //Console.WriteLine(listSeven.forLoopMethod1(counter1, list) + " From For loop Method");
            //Console.WriteLine(listSeven.whileLoopMethod1(counter1, list) + " From While loop Method");
            //Console.WriteLine(listSeven.recursiveMethod(sum,counter1, list.ToArray()) + " From Recursive Method");


            ProblemListEight listEight = new ProblemListEight();


            ProblemListNine listNine = new ProblemListNine();
            //listNine.ConcatenationOfList();

            
            ProblemListTen listTen = new ProblemListTen();
            listTen.DoCombineList();

            ProblemListEleven listEleven = new ProblemListEleven();
            //listEleven.MargeSortedList();

            ProblemListTwelve listTwelve = new ProblemListTwelve();
            //listTwelve.SwapListElement();
            //listTwelve.RotateWiithArray(2);
            //listTwelve.RotateWithList(2);

            ProblemListThirteen listThirteen = new ProblemListThirteen();
            //listThirteen.GetFibonacci();

            ProblemListForteen listForteen = new ProblemListForteen();
            //var list2 = listForteen.NumberToList();
            //list2.Reverse();
            //Console.Write("[");
            //foreach (var item in list2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("]");



            ProblemListNineteen listNineteen = new ProblemListNineteen();
            //listNineteen.Print1();

        }
    }
}
