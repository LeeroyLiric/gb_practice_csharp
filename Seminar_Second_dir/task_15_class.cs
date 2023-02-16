/*
    Задача 15: Напишите программу, которая принимает на вход цифру,
    обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
using static PromptClass;
class task_15_class
{
    public static void s2_ThirdTaskSolution()
    {
        int dayNumber = Prompt("Введите номер дня недели (1-7):");
        if (dayNumber == 6 || dayNumber == 7)
            Console.WriteLine("Этот день выходной");
        else if (0 < dayNumber && dayNumber < 6) 
            Console.WriteLine("Этот день будний"); 
        else 
            Console.WriteLine("Такого дня нет");
    }
}