/*
 * Rollercoaster
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program a few times to see what it does
 * and how it works. Be prepared to discuss the following
 * questions...
 * 1. This program allows the user to populate the array. 
 *    What does this mean? 
 * 2. In what order is the array populated?
 * 3. What does ToLower() do?
 * 4. Why did Mr. P add 1 to the row and column
 *    numbers when he displayed them to the console?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollercoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] occupiedSeats = new bool[8, 2];

            for(int i = 0; i < occupiedSeats.GetLength(0); i++)
            {
                for(int j = 0; j < occupiedSeats.GetLength(1); j++)
                {
                    Console.Write("Is seat " + (j + 1) + " in row " + (i + 1) + " filled? (yes/no) >> ");
                    string reply = Console.ReadLine().ToLower();
                    if (reply == "yes" || reply == "y")
                    {
                        occupiedSeats[i, j] = true;
                    }
                }
            }

            for (int i = 0; i < occupiedSeats.GetLength(0); i++)
            {
                for (int j = 0; j < occupiedSeats.GetLength(1); j++)
                {
                    Console.Write(occupiedSeats[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
