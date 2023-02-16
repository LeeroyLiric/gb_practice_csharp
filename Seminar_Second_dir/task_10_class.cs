/*
    Задача 10: Напишите программу, которая принимает на вход трёхзначное
    число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/
using static PromptClass;
class task_10_class
{
    public static void s2_FirstTaskSolution()
    {
        
        int number = Prompt("Введите трёхзначное число:");
        if (number < 100 || 999 < number)
            Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова");
        else
        {
            Console.WriteLine($"Введённое число {number}");
            int secondRank = number % 100 / 10;
            Console.WriteLine($"Вторая цифра {secondRank}");
        }
            
    }
}