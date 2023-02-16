/*
    Задача 1: Напишите программу, которая на вход принимает два числа
    и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
using static PromptClass;
class task_1_class : task_class
{
    public new void solution ()
    {
        int a, b;
        a = Prompt("Введите первое число:"); 
        b = Prompt("Введите второе число:"); 
        CheckMax(a, b);
        
    }

    private void CheckMax(int first, int second)
    {
        if (first > second)
        {
            Console.WriteLine($"\nПервое число {first} - большее, второе число {second} - меньшее\n");
        }
        else if (first < second)
        {
            Console.WriteLine($"\nПервое число {first} - меньшее, второе число {second} - большее\n");
        }
        else
        {
            Console.WriteLine($"\nОба числа {first} {second} равны\n");
        }
    }
}