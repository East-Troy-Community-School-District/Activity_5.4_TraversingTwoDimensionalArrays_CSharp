/*
 * Print 2D Array
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the following program and observe the output. In
 * your own words, describe how the program executes. 
 * (HINT: You may want to run the program in debugging
 * mode with a breakpoint so you can step through the
 * program one line at a time.) Finally, be prepared
 * to answer the following questions...
 * 1. What is the point of line 42?
 * 2. Why is line  use Write instead of WriteLine?
 * Modify the program by adding another row of values
 * to the 2D array in the initializer list. Have the
 * row store 55, 43, 34, and 89. Try running the program.
 * Your row was not displayed! Why? How could you fix
 * this problem?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] temperatures = { { 77, 56, 66, 79 }, { 23, 25, 19, 40 }, { 0, 1, -2, 1 } };

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(temperatures[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
