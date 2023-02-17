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
            if(IsPalindrome(number))
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");
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

    private static bool IsPalindrome(int number)
    {
        int firstDigit = number % 10;
        int secondDigit = number % 100 / 10;
        int fourthDigit = number / 1000 % 10;
        int fifthDigit =  number / 10000;
        if (firstDigit == fifthDigit && secondDigit == fourthDigit)
            return true;
        else
            return false;
    }
}