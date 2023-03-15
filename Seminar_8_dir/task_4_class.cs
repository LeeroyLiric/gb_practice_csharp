namespace gb_practice_csharp.Seminar_8_dir
{
    /*
     * 
     * 
     */
    /// <summary>
    /// Задача 4 * :
    /// Напишите программу,
    /// которая заполнит спирально квадратный массив.
    /// </summary>
    public static class TaskFourth
    {
        /// <summary>
        /// Решение семинар 8 задание 4 
        /// </summary>
        public static void Solution()
        {
            int n = 10;
            int[,] spiral = new int[n, n];
            Random random = new();
            int copyN = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(spiral[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }

        }
    }
}