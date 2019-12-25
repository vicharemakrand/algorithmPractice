using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class findPairSuminArray
    {
        //Find Pair with given Sum in the Array
        static void Main(string[] args)
        {
            var arr = new int[] { 8, 7, 2, 5, 3, 1 };
            var sum = 10;
            Console.WriteLine("Find Pair with given Sum in the Array");
            Console.WriteLine("Array :" + string.Join(",", arr));
            Console.WriteLine("sum :" + sum);

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
                            method1(arr, sum);
                            break;
                        }
                    case "2":
                        {
                            method2(arr, sum);
                            break;
                        }
                    case "3":
                        {
                            method3(arr, sum);
                            break;
                        }
                }
              }

        }

        private static void method3(int[] arr, int sum)
        {
            var rowIndex = 0;
            var collection = new Hashtable();
            while (rowIndex < arr.Length)
            {
                if (collection.ContainsKey(sum - arr[rowIndex])){

                    Console.WriteLine("Indexes [{0}, {1}] - Values [ {2}, {3}]", collection[sum - arr[rowIndex]], rowIndex, sum - arr[rowIndex], arr[rowIndex]);
                }
                collection.Add(arr[rowIndex], rowIndex);
                rowIndex++;
            }
        }

        private static void method2(int[] arr, int sum)
        {

            var sorted =  arr.OrderBy(o=>o).ToList();
            var pairFound = false;

            var lowerIndex = 0;
            var higherIndex = sorted.Count - 1;

            while(lowerIndex < higherIndex)
            {
                if (sorted[lowerIndex] + sorted[higherIndex] == sum)
                {
                    Console.WriteLine("Indexes [{0}, {1}] - Values [ {2}, {3}]", lowerIndex, higherIndex, sorted[lowerIndex], sorted[higherIndex]);
                    lowerIndex++;
                    higherIndex--;
                    pairFound = true;
                }
                else if(sorted[lowerIndex] < sorted[higherIndex])
                {
                    lowerIndex++;
                }
                else if (sorted[lowerIndex] > sorted[higherIndex])
                {
                    higherIndex--;
                }

            }

            if (!pairFound)
            {
                Console.WriteLine("No pair found.");
            }

        }

        private static void method1(int[] arr, int sum)
        {
            var pairFound = false;
            for(int i =0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine("Indexes [{0}, {1}] - Values [ {2}, {3}]",i, j, arr[i] , arr[j]);
                        pairFound = true;
                    }
                }
            }

            if (!pairFound)
            {
                Console.WriteLine("No pair found.");
            }
         }


    }
}
