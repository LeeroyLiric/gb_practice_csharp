class task_1_class : task_class
{
    public new void solution ()
    {
        int a, b;
        Console.WriteLine("Введите первое число:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToInt32(Console.ReadLine());
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