/*
    Задача 3: Задайте массив вещественных чисел.
    Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
namespace gb_practice_csharp.SeminarFifthDir
{
    class s5_task_3_class
    {
        public static void Solution_s5_t3()
        {
            Random rnd = new Random();
            int arrayLength = rnd.Next(1, 10);
            double[] numbersList = FillDoubleArray(new double[arrayLength]);
            ArrayWrite(numbersList);
            double result = numbersList.Max() - numbersList.Min(); 
            Console.WriteLine(result);

        }

        public static double[] FillDoubleArray(double[] numbers)
        {
            Random rnd = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-10, 11) + rnd.NextDouble();
            }
            return numbers;
        }

        public static void ArrayWrite(double[] numbers)
        {   
            foreach (var num in numbers)
            {
                Console.Write(num.ToString() + " ");
            }
            Console.WriteLine(" ");
        }
    }
    
}