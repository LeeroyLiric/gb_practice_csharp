class task_13_class
{
    public static void s2_SecondTaskSolution()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 99) 
            Console.WriteLine(number % 1000 / 100);
        else 
            Console.WriteLine("Третьей цифры нет");
    }
}