namespace gb_practice_csharp.Seminar_8_dir
{
    /// <summary>
    /// 
    /// </summary>
    public static class TaskFirst
    {
        /// <summary>
        /// 
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