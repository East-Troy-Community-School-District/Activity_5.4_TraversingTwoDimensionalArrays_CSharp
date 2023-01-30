/*
 * Total Rows
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program, observe the output, and read over
 * the code. What does this program do? How does it work?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 2, 4, 7 }, { 2, 3, 46 }, { 22, 34, 5 }, { 3, 3, 3 } };
            for(int i = 0; i < data.GetLength(0); i++)
            {
                int rowTotal = 0;
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    rowTotal += data[i, j];
                }
                Console.WriteLine("Row " + i + "'s Total: " + rowTotal);
            }
        }
    }
}
