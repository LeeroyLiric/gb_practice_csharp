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

    private static int CheckMax(int first, int second)
    {
        if (first > second)
        {
            Console.WriteLine($"Первое число {first} - большее, второе число {second} - меньшее");
        }
        else if (first < second)
        {
            return second;
        }
        else
        {
            return first;
        }
    }
}