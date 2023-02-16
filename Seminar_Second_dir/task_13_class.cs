/*
    Задача 13: Напишите программу, которая выводит третью цифру заданного
    числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/

using static PromptClass;
class task_13_class
{
    public static void s2_SecondTaskSolution()
    {
        int number = Prompt("Введите число:");
        if (number > 99) 
            Console.WriteLine("Третья цифра: " + ThirdNumber(number));
        else 
            Console.WriteLine("Третьей цифры нет");
    }

    private static int ThirdNumber(int number)
    {
        while (number > 999)
        {
            number /= 10;
        }
        return number % 10;
    }
}