using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts._2D_Array
{
    internal class Rotateby90
    {
        public void rotate90(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            Console.WriteLine("Matrix before transpose");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j],4} ");  // Right-align with width 4
                }
                Console.WriteLine();  // New line after each row
            }

            Console.WriteLine("Matrix after transpose");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;

                }
            }

            for (int i = 0; i < rows / 2; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[cols - 1 - i, j];
                    arr[cols - 1 - i, j] = temp;

                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{arr[i, j],4} ");  // Right-align with width 4
                }
                Console.WriteLine();  // New line after each row
            }



        }
    }
}
