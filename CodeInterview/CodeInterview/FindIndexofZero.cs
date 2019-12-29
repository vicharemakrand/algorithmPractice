using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class FindIndexofZero
    {
        // Find index of 0 to replaced with 1 to get maximum sequence
	    // of continuous 1's
        static void Main(string[] args)
        {
             var arr = new int[] { 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
 
            Console.WriteLine("Find index of 0 to replaced with 1 to get maximum sequence");
            Console.WriteLine("Array  :" + string.Join(",", arr));
 
            while (true) {
                var input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                var result = 0;
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
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("In-place merged two sorted arrays");
                if (result != -1)
                {
                    Console.WriteLine("Index to be replaced is " + result);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

 
        private static int method1(int[] A)
        {

            int max_count = 0;  // stores maximum number of 1's (including 0)
            int max_index = -1;   // stores index of 0 to be replaced

            int prev_zero_index = -1;   // stores index of previous zero
            int count = 0;              // store current count of zeros

            // consider each index i of the array
            for (int i = 0; i < A.Length; i++)
            {
                // if current element is 1
                if (A[i] == 1)
                {
                    count++;
                }
                else
                // if current element is 0
                {
                    // reset count to 1 + no. of ones to the left of current 0
                    count = i - prev_zero_index;

                    // update prev_zero_index to current index
                    prev_zero_index = i;
                }

                // update maximum count & index of 0 to be replaced if required
                if (count > max_count)
                {
                    max_count = count;
                    max_index = prev_zero_index;
                }
            }

            // return index of 0 to be replaced or -1 if array contains all 1's
            return max_index;
        }

    }
}















