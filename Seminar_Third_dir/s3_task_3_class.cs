/*
    Задача 3

    Напишите программу, которая принимает на вход число (N)
    и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
using static PromptClass;

public static class s3_task_3_class
{
    public static void s3_ThirdTaskSolution()
    {
        double exponent = 3;
        int n = Prompt("Введите ваше число:");
        for (int i = 1; i <= n; i++)
        {
            string result = Math.Pow(i, exponent).ToString() + (i == n ? "\n" : ", ");
            Console.Write(result);
        }
        
    }
}