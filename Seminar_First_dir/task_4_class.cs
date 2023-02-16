public static class task_4_class
{
    public static void FourthTaskSolution()
    {
        Console.WriteLine("Введите ваше число:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) Console.Write(i.ToString() + ", ");
        }
        Console.WriteLine();
    }
    
}