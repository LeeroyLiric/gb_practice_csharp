/*
    Задача 2: Напишите программу, которая принимает на вход три числа
    и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
static class task_2_class
{
    public static void SecondTaskSolution()
    {
        try 
        {
            int parsed;
            Console.WriteLine("Введите три числа в одной строке через пробел:");
            var inputs = Console.ReadLine();
            if (inputs != null)
            {
                int[] numbers = inputs.
                    Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries). // Я действительно пытался разобраться как это работает
                    Select(i => int.TryParse(i, out parsed) ? parsed : 0).ToArray();
                Console.WriteLine("Наибольшее из введённых чисел это: " + numbers.Max() + "\n");
            
            }
            else
            {
                Console.WriteLine("Вы не ввели числа! Запустите задачу заново и попробуйте ещё раз\n");
            } 
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Вы не ввели числа! Запустите задачу заново и попробуйте ещё раз\n");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Вы ввели слишком большие числа! Запустите задачу заново и попробуйте ещё раз\n");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Вы ввели слишком много чисел! Запустите задачу заново и попробуйте ещё раз\n");
        }
    }
}