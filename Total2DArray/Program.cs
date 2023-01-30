/*
 * Total 2D Array
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. What
 * does the program do? How does the foreach loop
 * traverse the 2D array? (HINT: Add a breakpoint
 * and run the program in debugging mode!)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 2, 4, 7 }, { 2, 3, 46 }, { 22, 34, 5 } };

            int total = 0;
            foreach(int number in data)
            {
                total += number;
            }
            Console.WriteLine("Total: " + total);
        }
    }
}
