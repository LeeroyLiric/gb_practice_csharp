namespace gb_practice_csharp.Seminar_7_dir
{
    /// <summary>
    /// Задача 3. Задайте двумерный массив из целых
    /// чисел. Найдите среднее арифметическое элементов
    /// в каждом столбце.
    /// Например, задан массив:
    /// 1 4 7 2
    /// 5 9 2 3
    /// 8 4 2 4
    /// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    /// </summary>
    public static class Task_3
    {
        /// <summary>
        /// Решение третьей задачи в седьмом семинаре
        /// </summary>
        public static void Solution()
        {
            Random random = new();
            System.Int32 m = random.Next(2, 11);
            System.Int32 n = random.Next(2, 11);
            System.Int32[,] intsArray = new System.Int32[m, n];
            System.Int32 rows = intsArray.GetUpperBound(0) + 1;
            System.Int32 columns = intsArray.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    intsArray[i, j] = random.Next(-10, 11);
                    Console.Write($"{intsArray[i, j]} ");
                }
                Console.WriteLine("");
            }

            System.Double[] avereages = new System.Double[columns];

            for (int j = 0, k = 0; j < columns && k < avereages.Length; j++, k++)
            {
                for (int i = 0; i < rows; i++)
                {

                    
                    
                }
                
            }
        }
    }
}