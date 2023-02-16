class task_10_class
{
    public static void s2_FirstTaskSolution()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number % 100 / 10);
    }
}