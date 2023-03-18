namespace gb_practice_csharp.Seminar_9_dir
{
    /// <summary>
    /// Задача 2: Задайте значения M и N.
    /// Напишите программу, которая найдёт сумму
    /// натуральных элементов в промежутке от M до N.
    /// M = 1; N = 15 -> 120
    /// M = 4; N = 8 -> 30
    /// </summary>
    public static class TaskSecondClass
    {
        /// <summary>
        /// Решение задача 2 семинар 9
        /// </summary>
        public static void Solution()
        {
            int m = PromptClass.Prompt("M = ");
            int n = PromptClass.Prompt("N = ");
            int summ = RecursionSum(m, n);
            Console.WriteLine(summ);
        }

        static int RecursionSum(int m, int n)
        {
            int summ = m;

            if (m < n)
            {
               summ += RecursionSum(m + 1, n);
            }

            return summ;
        }
    }
}