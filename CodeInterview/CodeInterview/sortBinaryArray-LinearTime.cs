using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class sortBinaryArrayLinearTime
    {
        //Sort Binary Array in Linear Time
        static void Main(string[] args)
        {
             var arr = new int[] { 0, 0, 1, 0, 1, 1, 0, 1, 0, 0 };
             Console.WriteLine("Sort Binary Array in Linear Time");
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
                           // method3(arr, sum);
                            break;
                        }
                }
              }

        }
 
        private static void method2(int[] arr)
        {
            var sortedArr = arr.ToList();
            sortedArr.Sort();
            Console.WriteLine("Sorted Array :" + string.Join(",", sortedArr));
        }

        private static void method1(int[] arr)
        {
            var sortedArr = new List<int>();
             for(int i = 0; i < arr.Length; i++) {
                if (arr[i] == 1) {
                    sortedArr.Add(arr[i]);
                 } else {
                    sortedArr= sortedArr.Prepend(arr[i]).ToList();
                }
            }

            Console.WriteLine("Sorted Array :" + string.Join(",", sortedArr));
        }

    }
}
