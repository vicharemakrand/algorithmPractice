using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class findLargestSubArray
    {
        //Find largest sub-array formed by consecutive integers
        //Given an array of integers, find largest sub-array formed by consecutive integers. 
        //The sub-array should contain all distinct values.
         static void Main(string[] args)
        {
             var arr = new int[] { 2, 0, 2, 1, 4, 3, 1, 0 };
           // var arr = new int[] { 2, 0, 1 , 2, 4, 3, 4, 0 };

            Console.WriteLine("Find largest sub-array formed by consecutive integers");
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
                    //case "2":
                    //    {
                    //        method2(arr);
                    //        break;
                    //    }
                }
              }

        }

        private static void method1(int[] arr)
        {
            Console.ForegroundColor = ConsoleColor.White;

            var consectiveArrays = new List<List<int>>();
            for (int lindex = 0; lindex < arr.Length; lindex++)
            {
                for (int hindex = lindex; hindex < arr.Length; hindex++)
                {
                    var subArray = arr.Where((o, i) => i <= hindex && i >= lindex).ToList();                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("sub array - {0}", string.Join(",", subArray).PadRight(arr.Length * 3));
                    
                    if (isConsecutive(subArray))
                    {
                        consectiveArrays.Add(subArray);
                    }
                 }
            }

            if (consectiveArrays.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var item in consectiveArrays)
                {
                    Console.WriteLine("sub array (consective values) - {0} ", string.Join(",", item).PadRight(arr.Length * 3));
                }

                var largestArray = consectiveArrays.Aggregate((largest, item) => item.Count > largest.Count ? item : largest);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("largest sub array - {0} ", string.Join(",", largestArray).PadRight(arr.Length * 3));
            }
        }

        private static bool isConsecutive(List<int> subArray)
        {
            var sorted = subArray.OrderBy(o => o).ToList();
            return sorted.Count > 0 && sorted.Where((o, i) => {
                return  i < sorted.Count-1 && Math.Abs(o - sorted[i + 1]) == 1;
                }).Count() == sorted.Count -1;
        }
    }
}
