/*
 * Tic Tac Toe Board
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * Run this program a few times and observe the output.
 * What does this program do? How?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3, 3];
            Random generator = new Random();

            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    int number = generator.Next(0, 2);
                    if (number == 0)
                    {
                        board[i, j] = "X";
                    }
                    else
                    {
                        board[i, j] = "O";
                    }
                }
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
