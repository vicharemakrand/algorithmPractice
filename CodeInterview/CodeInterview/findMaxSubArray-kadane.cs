using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class findMaxSubArraykadane
    {
        // Function to find contiguous sub-array with the largest sum
        // in given set of integers
        static void Main(string[] args)
        {
             var arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
 
            Console.WriteLine("find contiguous sub-array with the largest sum");
            Console.WriteLine("Array  :" + string.Join(",", arr));
 
            while (true) {
                var input = Console.ReadLine();
                (int maxSoFar, int start, int end) result = (0,0,0);
                Console.ForegroundColor = ConsoleColor.White;
                 if (input == "0")
                {

                    Console.WriteLine("exiting the app");
                    break;
                }
                switch (input)
                {
                    case "1":
                        {
                            result= method1(arr);
                            break;
                        }
                }

                Console.WriteLine("The sum of contiguous sub-array with the " +
                "largest sum is " + result.maxSoFar);
                Console.Write("The contiguous sub-array with the largest sum is : ");
                var final = arr.Where((o, i) => i >= result.start && i <= result.end).ToArray();
                Console.Write(string.Join(",", final));
            }

        }

 
        private static (int maxSoFar, int start, int end) method1(int[] arr)
        {
            // stores maximum sum sub-array found so far
            int maxSoFar = 0;

            // stores maximum sum of sub-array ending at current position
            int maxEndingHere = 0;
            // stores end-points of maximum sum sub-array found so far
            int start = 0, end = 0;

            // stores starting index of a positive sum sequence
            int beg = 0;


            // traverse the given array
            for (int i=0; i < arr.Length;i++)
            {
                // update maximum sum of sub-array "ending" at index i (by adding
                // current element to maximum sum ending at previous index i-1)
                maxEndingHere = maxEndingHere + arr[i];

                // if maximum sum is negative, set it to 0 (which represents
                // an empty sub-array)
                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;  // empty sub-array
                    beg = i + 1;
                }

                // update result if current sub-array sum is found to be greater
                if (maxSoFar < maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                    start = beg;
                    end = i;
                }
            }

            return  ( maxSoFar, start, end );
        }
    }
}















