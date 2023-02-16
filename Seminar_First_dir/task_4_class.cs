/*
    Задача 4: Напишите программу, которая на вход принимает число (N),
    а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
using static PromptClass;
public static class task_4_class
{
    public static void FourthTaskSolution()
    {
        int number = Prompt("Введите ваше число:");
        // Внёс изменения в соответствии с замечанием
        for (int i = 2; i <= number; i += 2)
        {
            Console.Write(i.ToString() + ", ");
        }
        Console.WriteLine();
    }
    
}