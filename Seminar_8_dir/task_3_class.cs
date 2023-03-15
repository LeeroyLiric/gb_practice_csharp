using System;

namespace gb_practice_csharp.Seminar_8_dir
{
    /// <summary>
    /// Задача 3 * : Задайте две матрицы.
    /// Напишите программу, которая будет находить
    /// произведение двух матриц.
    /// </summary>
    public static class TaskThird
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Solution()
        {
            Random random = new();
            // Sizes of matrix A
            int matrixARow = random.Next(1, 10);
            int matrixAColumn = random.Next(1, 10);
            
            // Sizes of matrix B
            int matrixBRow = matrixAColumn;
            int matrixBColumn = random.Next(1, 10);

            int[,] matrixA = MatrixFill(matrixARow, matrixAColumn);
            Console.WriteLine("");
            int[,] matrixB = MatrixFill(matrixBRow, matrixBColumn);
            Console.WriteLine("");

            int[,] matrixProduct = new int[matrixARow, matrixBColumn];

            for (int i = 0; i < matrixARow; i++)
            {
                for (int j = 0; j < matrixBColumn; j++)
                {
                    for (int k = 0;k < matrixAColumn; k++)
                    {
                        matrixProduct[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                    Console.Write(matrixProduct[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }

        }

        static int[,] MatrixFill(int row, int column)
        {
            int[,] matrix = new int[row, column];
            Random random = new();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(-10, 11);
                    Console.Write(matrix[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }
            return matrix;
        }
    }
}