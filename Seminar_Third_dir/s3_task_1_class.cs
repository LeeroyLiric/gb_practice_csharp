/*
    Задача 1

    Напишите программу, которая принимает на вход пятизначное число и
    проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
public static class s3_task_1_class
{
    public static void s3_FirstTaskSolution()
    {
        int number = PromptClass.Prompt("Введите пятизначное число:");
        if (FiveDigitCheck(number))
        {

        }
        else
        {
            Console.WriteLine("Вы ввели не пятизначное число!");
        }

    }

    private static bool FiveDigitCheck(int number)
    {
        if (number < 10000 || 99999 < number)
            return false;
        else
            return true;
    }
}