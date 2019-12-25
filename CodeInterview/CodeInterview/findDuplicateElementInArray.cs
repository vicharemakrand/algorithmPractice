using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class findDuplicateElementInArray
    {
        //Find a duplicate element in a limited range array
        //Given a limited range array of size n where array contains elements between 1 to n-1
        //with one element repeating, find the duplicate number in it.
        static void Main(string[] args)
        {
             var arr = new int[] { 1, 2, 3, 4, 4,5,3 };
             Console.WriteLine("Find a duplicate element in a limited range array");
            Console.WriteLine("Array :" + string.Join(",", arr));
  
            while (true) {
                var input = Console.ReadLine();

                if(input == "0")
                {

                    Console.WriteLine("exiting the app");
                    break;
                }
                switch (input)
                {
                    case "1":
                        {
                            method1(arr);
                            break;
                        }
                    case "2":
                        {
                            method2(arr);
                            break;
                        }
                    case "3":
                        {
                            method3FindSingleDuplicateItem();
                            break;
                        }
                }
              }

        }

        private static void method3FindSingleDuplicateItem()
        {
            //Given a limited range array of size n where array contains elements between 1 to n-1
            //with one element repeating, find the duplicate number in it.
            var arr = new int[] { 1, 2, 3, 4, 4 };
            int actual_sum = arr.Sum();
            int expected_sum = arr.Length * (arr.Length - 1) / 2;

            Console.WriteLine("duplicate element   : {0}" , actual_sum - expected_sum);
         }

        private static void method2(int[] arr)
        {
           var duplicateItems = new Dictionary<int,int>();
            foreach(var item in arr)
            {
                    duplicateItems[item] = duplicateItems.ContainsKey(item) ? duplicateItems[item] + 1 : 1;
            }
            Console.WriteLine("duplicate element of the Array :" + string.Join(",", duplicateItems.Where(o=>o.Value>1).Select(o=>o.Key).ToList()));
        }

        private static void method1(int[] arr)
        {
            var duplicateItems = arr.GroupBy(o => o).Where(o => o.Count() > 1).Select(o=>o.Key).ToList();

            Console.WriteLine("duplicate element of the Array :" + string.Join(",", duplicateItems));
        }

    }
}
