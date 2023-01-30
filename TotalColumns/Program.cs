/*
 * Total Columns
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and see what it does. How is this
 * program similar and different from the program
 * called TotalRows?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = { { 2, 4, 7 }, { 2, 3, 46 }, { 22, 34, 5 }, { 3, 3, 3 } };
            int[] columnTotals = new int[data.GetLength(1)];
            
            for (int i = 0; i < data.GetLength(1); i++)
            {
                int columnTotal = 0;
                for (int j = 0; j < data.GetLength(0); j++)
                {
                    columnTotal += data[j, i];
                }
                columnTotals[i] = columnTotal;
            }

            for(int i = 0; i < columnTotals.Length; i++)
            {
                Console.WriteLine("Column " + i + "'s Total: " + columnTotals[i]);
            }
        }
    }
}
