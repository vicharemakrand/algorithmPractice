using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeInterview
{
    class findBuySaleDeal
    {
        // find best buy and sale deal
         static void Main(string[] args)
        {
             var arr = new int[] { 40, 50, 30, 70, 60 };
 
            Console.WriteLine("find best buy and sale deal");
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

         private static void method1(int[] test1)
        {
            var result = new List<dynamic>();
            for (var itemIndex = 0; itemIndex < test1.Length; itemIndex++) {

                var test2 = test1.Where((y, j) => (j > itemIndex - 1)).Select((x, i) => new { diff = x - test1[itemIndex], bIndex = itemIndex, sindex = i, bItem = test1[itemIndex], sItem = x }).Aggregate((i1, i2) => i1.diff > i2.diff ? i1 : i2);
                result.Add(test2);
                 Console.WriteLine(test2.sItem + " - " + test2.bItem + "=" + test2.diff + "(" + test2.bIndex + " , " + test2.sindex + ")");
            }

            var test3 = result.Aggregate((i1, i2) => i1.diff > i2.diff ? i1 : i2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(test3.sItem + " - " + test3.bItem + "=" + test3.diff + "(" + test3.bIndex + " , " + test3.sindex + ")");
          }
    }
}















