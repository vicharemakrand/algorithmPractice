using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class equilibriumIndex
    {
        // find equilibrium index of an array
        static void Main(string[] args)
        {
             var arr = new int[] { 0, -3, 5, -4, -2, 3, 1, 0 };
 
            Console.WriteLine("find equilibrium index of an array");
            Console.WriteLine("Array  :" + string.Join(",", arr));
 
            while (true) {
                var input = Console.ReadLine();
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
                            method1(arr);
                            break;
                        }
                    case "2":
                        {
                            method2(arr);
                            break;
                        }
                }
            }
        }

        private static void method2(int[] A)
        {
            // total stores sum of all elements of the array
            int total = A.Sum();   

            // right stores sum of elements of sub-array A[i+1..n)
            int right = 0;

            // traverse array from right to left
            for (int i = A.Length - 1; i >= 0; i--)
            {
                /* i is equilibrium index if sum of elements of sub-array
                   A[0..i-1] is equal to the sum of elements of sub-array
                   A[i+1..n) i.e. (A[0] + A[1] + .. + A[i-1]) =
                   (A[i+1] + A[i+2] + .. + A[n-1]) */

                // sum of elements of left sub-array A[0..i-1] is
                // (total - (A[i] + right))
                if (right == total - (A[i] + right))
                {
                    Console.WriteLine("Equilibrium Index found at " + i);
                }

                // new right = A[i] + (A[i+1] + A[i+2] + .. + A[n-1])
                right += A[i];
            }
        }

        private static void method1(int[] A)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // left[i] stores sum of elements of sub-array A[0..i-1]
            int[] left = new int[A.Length];

            left[0] = 0;

            // traverse array from left to right
            for (int i = 1; i < A.Length; i++)
            {
                left[i] = left[i - 1] + A[i - 1];
            }

            // right stores sum of elements of sub-array A[i+1..n)
            int right = 0;

            // traverse array from right to left
            for (int i = A.Length - 1; i >= 0; i--)
            {
                /* if sum of elements of sub-array A[0..i-1] is equal to
                   the sum of elements of sub-array A[i+1..n) i.e.
                   (A[0] + .. + A[i-1]) = (A[i+1] + A[i+2] + .. + A[n-1]) */

                if (left[i] == right)
                {
                    Console.WriteLine("Equilibrium Index found at " + i);
                }

                // new right = A[i] + (A[i+1] + A[i+2] + .. + A[n-1])
                right += A[i];
            }
        }

    }
}















