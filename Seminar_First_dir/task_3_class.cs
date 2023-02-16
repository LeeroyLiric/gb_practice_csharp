public static class task_3_class
{
    public static void ThirdTaskSolution()
    {
        Console.WriteLine("Введите одно число для проверки на чётность:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0) 
        {
            Console.WriteLine("Число чётное");
        }
        else 
            Console.WriteLine("Число НЕ чётное");
    }
    
}