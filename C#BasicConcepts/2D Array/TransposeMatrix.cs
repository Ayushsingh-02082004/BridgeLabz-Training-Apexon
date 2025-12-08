using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts._2D_Array
{
    public class TransposeMatrix
    {

        public int[,] transpose(int[,] arr)
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
            
            int[,] result = new int[cols, rows];
            Console.WriteLine("Matrix after transpose");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = arr[j, i];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{result[i, j],4} ");  // Right-align with width 4
                }
                Console.WriteLine();  // New line after each row
            }

            return result;
        }
    }
}
