namespace gb_practice_csharp.Seminar_9_dir
{
    /// <summary>
    /// Задача 3: Напишите программу вычисления функции
    /// Аккермана с помощью рекурсии.
    /// Даны два неотрицательных числа m и n.
    /// m = 2, n = 3 -> A(m,n) = 9
    /// m = 3, n = 2 -> A(m,n) = 29
    /// </summary>
    public static class TaskThirdClass
    {
        /// <summary>
        /// Решение задача 3 семинар 9
        /// </summary>
        public static void Solution()
        {
            long m = Convert.ToInt64(PromptClass.Prompt("M = "));
            long n = Convert.ToInt64(PromptClass.Prompt("N = "));
            long result = Ackermann(m, n);
            System.Console.WriteLine(result.ToString());
        }

        static long Ackermann(long m, long n) 
        {
            while (m != 0L)
            {
                if (n == 0L)
                    n = 1L;
                else
                    n = Ackermann(m, n - 1L);
                m--;
            }
            return n + 1L;
        }
        
        
    }
}