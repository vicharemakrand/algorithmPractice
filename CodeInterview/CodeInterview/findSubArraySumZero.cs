using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class findSubArraySumZero
    {
        //Check if subarray with 0 sum is exists or not
        static void Main(string[] args)
        {
             var arr = new int[] {  4, -6, 3, -1, 4, 2, 7  };
           // var arr = new int[] { 0 -6, 6 };
            Console.WriteLine("Check if subarray with 0 sum is exists or not");
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
            Console.ForegroundColor = ConsoleColor.White;
            for (int lindex = 0; lindex < arr.Length; lindex++)
            {
                for (int hindex = lindex; hindex < arr.Length; hindex++)
                {
                    var subArray = arr.Where((o, i) => i <= hindex && i >= lindex).ToList();
                    var subArraySum = subArray.Sum();//Aggregate((first, second) => first + second);
                    if (subArraySum == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("sub array - {0} = {1}", string.Join(",", subArray).PadRight(arr.Length * 3), subArraySum);

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("sub array - {0} = {1}", string.Join(",", subArray).PadRight(arr.Length * 3), subArraySum);
                }
            }

        }

        private static void method1(int[] arr)
        {
            //logic 
            // sub array sum should match with array item
            var sumByIndex = new List<int>() { 0 };
            int sum = 0;
            var subArrayFound = false;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = +arr[i];
                if (sumByIndex.Contains(sum)){
                    Console.WriteLine("Sub array found");
                    subArrayFound = true;
                }
                sumByIndex.Add(sum);
            }

            if(!subArrayFound)
            Console.WriteLine("No sub array found");

        }


    }
}
