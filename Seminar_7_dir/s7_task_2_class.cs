namespace gb_practice_csharp.Seminar_7_dir
{
    /// <summary>
    /// Напишите программу, которая на вход принимает позиции
    /// элемента в двумерном массиве, и возвращает значение
    /// этого элемента или же указание, что такого элемента
    /// нет. 
    /// Например, задан массив:
    /// 1 4 7 2
    /// 5 9 2 3
    /// 8 4 2 4
    /// 1, 7 -> такого числа в массиве нет
    /// </summary>
    public static class TaskSecond
    {
        /// <summary>
        /// Решение второй задачи в Седьмом семинаре
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

            System.Int32 x = PromptClass.Prompt("Введите строку элемента:");
            System.Int32 y = PromptClass.Prompt("Введите столбец элемента:");
            
            if (x >= rows || y >= columns)
            {
                Console.WriteLine("Такого элемента нет в массиве!");
            }
            else
            {
                Console.WriteLine($"{intsArray[x, y]}");
            }
        }
    }
}