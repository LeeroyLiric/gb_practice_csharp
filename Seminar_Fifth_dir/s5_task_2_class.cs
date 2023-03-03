/*
    Задача 2: Задайте одномерный массив, заполненный случайными числами.
    Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
namespace gb_practice_csharp.SeminarFifthDir
{
    class s5_task_2_class
    {
        public static void Solution_s5_t2()
        {
            Random rnd = new Random();
            int arrayLength = rnd.Next(1, 20);
            int[] arrayRandNumbers = s5_task_1_class.FillArray(new int[arrayLength]);
            s5_task_1_class.ArrayWrite(arrayRandNumbers);
            int result = OddSumm(arrayRandNumbers);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Считает сумму элементов стоящих на нечётной позиции
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static int OddSumm(int[] numbers)
        {
            int summ = 0;
            for (int i = 1; i < numbers.Length; i += 2)
            {
                summ += numbers[i];
            }
            return summ;
        }
    }
}