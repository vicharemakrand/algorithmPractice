using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class replacearraywithproductofitems
    {
        // Recursive function to replace each element of the array with product
        // of every other element without using division operator
        static void Main(string[] args)
        {
             var arr = new int[] { 5, 3, 4, 2, 6, 8 };
 
            Console.WriteLine("Recursive function to replace each element of the array with product");
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

 
        private static void method1(int[] arr)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ReplacedArray(arr,0);
            Console.WriteLine("Array  :" + string.Join(",", arr));
        }

        private static int ReplacedArray(int[] arr, int index)
        {

            var x= arr.Where((o, i) => i != index).Aggregate((product, item) => product * item);
            if (index < arr.Length-1)
            {
                ReplacedArray(arr, index + 1);
            }

            arr[index] = x;
            return x;
        }
    }
}















