namespace gb_practice_csharp.Seminar_7_dir
{
    /// <summary>
    /// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    /// m = 3, n = 4.
    /// 0,5 7 -2 -0,2
    /// 1 -3,3 8 -9,9
    /// 8 7,8 -7,1 9
    /// </summary>
    public static class S7_task_1_Class
    {
        /// <summary>
        /// Решение
        /// </summary>
        public static void Solution_S7_T1()
        {
            Console.Write("m=");
            System.Int32 m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            System.Int32 n = Convert.ToInt32(Console.ReadLine());
            System.Double[,] doublesArray = new System.Double[m, n];
            Random rnd = new();
            System.Int32 rows = doublesArray.GetUpperBound(0) + 1;
            System.Int32 columns = doublesArray.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    doublesArray[i, j] = Convert.ToDouble(rnd.Next(-10, 11)) + Math.Round(rnd.NextDouble(), 2);
                    Console.Write($"{doublesArray[i, j]} ");
                }
                Console.WriteLine("");
            }   
        }
    }
}