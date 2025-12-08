using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts._2D_Array
{
    internal class Multiplymatrix
    {
        public void multiplymat()
        {
            int[,] A = {
            { 1, 2, 3 },
            { 4, 5, 6 }
            };  // 2 × 3 matrix

            

            int[,] B = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
            };  // 3 × 2 matrix

            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);

            Console.WriteLine("Matrix A is");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    Console.Write($"{A[i, j],4} ");  // Right-align with width 4
                }
                Console.WriteLine();  // New line after each row
            }

            Console.WriteLine("Matrix B is");
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"{B[i, j],4} ");  // Right-align with width 4
                }
                Console.WriteLine();  // New line after each row
            }

            if (colsA != rowsB){ 
        
                Console.WriteLine("Matrix multiplication not possible");
                return;
            }
            int[,] c = new int[rowsA, colsB];

            for(int i= 0; i < rowsA; i++)
            {
                for(int j = 0; j<colsB; j++)
                {
                    for(int k = 0; k < colsA; k++)
                    {
                        c[i, j] += A[i,k] * B[k, j];
                    }
                }
            }

            Console.WriteLine("Ans matrix is after multiplication : ");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write($"{c[i, j],4} ");  // Right-align with width 4
                }
                Console.WriteLine();  // New line after each row
            }
        }

        

    }
}
