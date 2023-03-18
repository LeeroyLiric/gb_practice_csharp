namespace gb_practice_csharp.Seminar_9_dir
{
    /// <summary>
    /// Задача 1: Задайте значения M и N.
    /// Напишите программу, которая выведет все чётные
    /// натуральные числа в промежутке от M до N с
    /// помощью рекурсии.
    /// M = 1; N = 5 -> "2, 4"
    /// M = 4; N = 8 -> "4, 6, 8"
    /// </summary>
    public static class TaskFirstClass
    {
        /// <summary>
        /// Решение задача 1 семинар 9
        /// </summary>
        public static void Solution()
        {
            int m = PromptClass.Prompt("M = ");
            int n = PromptClass.Prompt("N = ");
            Recursion(m, n);
        }
        static void Recursion(int m, int n)
        {

            if (m % 2 == 0)
            {
                Console.WriteLine(m);
            }
            if (m < n)
            {
                Recursion(m + 1, n);
            }
        }
    }
}