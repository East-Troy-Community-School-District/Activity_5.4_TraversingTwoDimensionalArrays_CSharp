/*
 * Dance Floor
 * 1/30/2023
 * C#.NET I
 * 
 * Instructions:
 * The 2D array danceFloor represents the lights of a 
 * dance floow that is 10 lights tall and 10 lights wide.
 * If a light is on, the bool value in the 2D array is 
 * true. If a light is off, the bool value in the 2D 
 * array is false. Read over the code and run the 
 * program a few times. What does the program do? How?
 * Is there a pattern for lines 31 through 40? How
 * could we use this pattern to rewrite that section
 * of code? What is this process called?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] danceFloor = new bool[10, 10];
            danceFloor[0, 0] = true;
            danceFloor[1, 1] = true;
            danceFloor[2, 2] = true;
            danceFloor[3, 3] = true;
            danceFloor[4, 4] = true;
            danceFloor[5, 5] = true;
            danceFloor[6, 6] = true;
            danceFloor[7, 7] = true;
            danceFloor[8, 8] = true;
            danceFloor[9, 9] = true;

            int lightsOn = 0;
            for (int i = 0; i < danceFloor.GetLength(0); i++)
            {
                for(int j = 0; j < danceFloor.GetLength(1); j++)
                {
                    if (danceFloor[i, j])
                    {
                        lightsOn++;
                    }
                }
            }
            Console.WriteLine(lightsOn);
        }
    }
}
