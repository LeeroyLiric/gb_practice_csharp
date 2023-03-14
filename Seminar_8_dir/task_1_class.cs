namespace gb_practice_csharp.Seminar_8_dir
{
    /// <summary>
    /// Задача 1: Задайте двумерный массив.
    /// Напишите программу, которая упорядочивает
    /// по убыванию элементы каждой строки двумерного
    /// массива.
    /// </summary>
    public static class TaskFirst
    {
        /// <summary>
        /// Решение задача 1 семинар 8
        /// </summary>
        public static void Solution() 
        {
            int n = 10;
            int[,] ints = new int[n, n];
            Random random = new();
            int copyN = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ints[i, j] = random.Next(1, 11);
                    Console.Write(ints[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for(int k = j; k < n; k++)
                    {
                        if (ints[i, j] < ints[i, k])
                        {
                            int temp = ints[i, j];
                            ints[i, j] = ints[i, k];
                            ints[i, k] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ints[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }

        }
    }
}