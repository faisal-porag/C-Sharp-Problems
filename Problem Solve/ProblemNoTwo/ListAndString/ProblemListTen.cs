using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListTen
    {

        public void DoCombineList()
        {
            List<string> list1 = new List<string> { "a", "b", "c" };
            List<string> list2 = new List<string> { "1", "2", "3" };
            getList1(list1);
            getList2(list2);
            
            var resList = list1.Concat(list2).ToList();
            // a b c 1 2 3
            // a 1 b 2 c 3
            //List<string> storeResult = new List<string>();
            string[] storeResult = new string[resList.Count];
            int m = 0, n = 0;

            for (int i = 0; i < resList.Count; i++)
            {
                if(i % 2 == 0)
                {
                    storeResult[i] = list1[m++];
                }
                else
                {
                    storeResult[i] = list2[n++];
                }
            }

            foreach (var item in storeResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }



        public void getList1(List<string> list1)
        {
            foreach (var item in list1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void getList2(List<string> list2)
        {
            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        
        }
        
    }

