/*
 * Total Diagonals
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and see what it does. How is this
 * program similar and different from the programs
 * called TotalRows and TotalColumns? Will this program
 * work with rectangular 2D arrays? (HINT: Modify the
 * original array and see!)
 * Finally, modify the program to calculate the total of
 * the other diagonal.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 2, 4, 7 }, { 2, 3, 46 }, { 22, 34, 5 } };

            int diagonalTotal = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                diagonalTotal += data[i, i];
            }
            Console.WriteLine("Total: " + diagonalTotal);
        }
    }
}
