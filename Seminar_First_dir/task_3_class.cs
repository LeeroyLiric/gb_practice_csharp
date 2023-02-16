/*
    Задача 3: Напишите программу, которая на вход принимает число
    и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
using static PromptClass;
public static class task_3_class
{
    public static void ThirdTaskSolution()
    {
        int number = Prompt("Введите одно число для проверки на чётность:");
        if (number % 2 == 0) 
        {
            Console.WriteLine("Число чётное");
        }
        else 
            Console.WriteLine("Число НЕ чётное");
    }
    
}