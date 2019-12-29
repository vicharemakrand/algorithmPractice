using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class rearrangeArray
    {
        // Rearrange the array with alternate high and low elements
         static void Main(string[] args)
        {
             var arr = new int[] { 9, 6, 8, 3, 7 };
 
            Console.WriteLine("Rearrange the array with alternate high and low elements");
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
 
                }
            }
        }

        private static void swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        private static void method1(int[] A)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // start from second element and increment index
            // by 2 for each iteration of loop
            for (int i = 1; i < A.Length; i += 2)
            {
                // If the prev element is greater than current element,
                // swap the elements
                if (A[i - 1] > A[i])
                {
                    swap(A, i - 1, i);
                }

                // if next element is greater than current element,
                // swap the elements
                if (i + 1 < A.Length && A[i + 1] > A[i])
                {
                    swap(A, i + 1, i);
                }
            }

            Console.WriteLine(" Result Array  :" + string.Join(",", A));

        }


    }
}















