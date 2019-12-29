using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class mergeSortedArray
    {
        //In-place merge two sorted arrays
        //Given two sorted arrays X[]  and  Y[]  of size m and n each, merge elements of  X[]  with elements of array  Y[]  by maintaining the sorted order. i.e. fill  X[]  with first m smallest elements and fill  Y[]  with remaining elements.
        //The conversion should be done in-place and without using any other data structure
        static void Main(string[] args)
        {
             var arr1 = new int[] { 1, 4, 7, 8, 10 };
            var arr2 = new int[] { 2, 3, 9 };

            Console.WriteLine("In-place merge two sorted arrays");
            Console.WriteLine("Array 1 :" + string.Join(",", arr1));
            Console.WriteLine("Array 2 :" + string.Join(",", arr2));

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
                            method1(arr1,arr2);
                            break;
                        }
                    case "2":
                        {
                            method2(ref arr1, ref arr2);
                            break;
                        }
                }
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("In-place merged two sorted arrays");
                Console.WriteLine("Array 1 :" + string.Join(",", arr1));
                Console.WriteLine("Array 2 :" + string.Join(",", arr2));

            }

        }

        private static void method2( ref int[] X,ref int[] Y)
        {
            int m = X.Length;
 
            int maxY = Y.Max();
            var lowItemsOfX = X.Where(o => o <= maxY).ToArray();
            if (m > lowItemsOfX.Count())
            {
                var newXitems = Y.Where((o, i) => i <= (m - lowItemsOfX.Count())).ToArray();
                var newYitems = X.Where((o, i) => i > newXitems.Count()).ToArray();
                Y = Y.Except(newXitems).Concat(newYitems).OrderBy(o=> o).ToArray();
                X = X.Except(newYitems).Concat(newXitems).OrderBy(o => o).ToArray();
 
            }
        }

        private static void method1(int[] X, int[] Y)
        {

            int m = X.Length;
            int n = Y.Length;

            // consider each element X[i] of array X and ignore the element
            // if it is already in correct order else swap it with next smaller
            // element which happens to be first element of Y
                for (int i = 0; i < m; i++)
                {
                    // compare current element of X[] with first element of Y[]
                    if (X[i] > Y[0])
                    {
                        // swap (X[i], Y[0])
                        int temp = X[i];
                        X[i] = Y[0];
                        Y[0] = temp;

                        int first = Y[0];

                        // move Y[0] to its correct position to maintain sorted
                        // order of Y[]. Note: Y[1..n-1] is already sorted
                        int k;
                        for (k = 1; k < n && Y[k] < first; k++)
                        {
                            Y[k - 1] = Y[k];
                        }

                        Y[k - 1] = first;
                    }
                }
        }

    }
}
