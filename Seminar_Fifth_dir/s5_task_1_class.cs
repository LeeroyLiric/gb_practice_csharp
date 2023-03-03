/*
    Задача 1: Задайте массив заполненный случайными положительными
    трёхзначными числами. Напишите программу, которая покажет
    количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
namespace gb_practice_csharp.SeminarFifthDir
{
    public static class s5_task_1_class
    {
        
        public static void Solution_s5_t1()
        {
            Random rnd = new Random();
            int arrayLength = rnd.Next(1, 100);
            int[] numbersList = FillArray(new int[arrayLength]);
            ArrayWrite(numbersList);
            int evens = evenCount(numbersList);
            Console.WriteLine(evens);
        }

        public static void ArrayWrite(int[] numbers)
        {   
            foreach (var num in numbers)
            {
                Console.Write(num.ToString() + " ");
            }
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Заполняет массив случайными трёхзначными числами
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] FillArray(int[] numbers)
        {
            Random rnd = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100, 1000);
            }
            return numbers;
        }

        /// <summary>
        /// Считает количество чётных элементов массива
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private static int evenCount(int[] numbers)
        {
            int count = 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    count++;
                } 
            }
            return count;
        }
        
    }
}