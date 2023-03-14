namespace gb_practice_csharp.Seminar_8_dir
{
    /// <summary>
    /// Задача 2: Задайте прямоугольный двумерный массив.
    /// Напишите программу, которая будет находить строку
    /// с наименьшей суммой элементов.
    /// </summary>
    public static class TaskSecond
    {
        /// <summary>
        /// Решение задача 2 семинар 8
        /// </summary>
        public static void Solution() 
        {
            int n = 10;
            int m = 5;
            int[,] ints = new int[n, m];
            Random random = new();
            int copyN = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ints[i, j] = random.Next(1, 11);
                    Console.Write(ints[i, j].ToString() + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            int minimalStrokeIndex = 0;
            int minimalSum = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int summ = 0;
                for (int j = 0; j < m; j++)
                {
                    summ += ints[i, j];
                }
                if (summ < minimalSum)
                {
                    minimalSum = summ;
                    minimalStrokeIndex = i;
                }    
            }
            Console.WriteLine("");
            Console.WriteLine("Индекс строки с минимальной суммой:" + minimalStrokeIndex);
            
            for (int i = 0; i < m; i++)
            {
                Console.Write(ints[minimalStrokeIndex, i].ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}