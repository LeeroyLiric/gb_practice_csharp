class task_15_class
{
    public static void s2_ThirdTaskSolution()
    {
        Console.WriteLine("Введите номер дня недели (1-7):");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        if (dayNumber == 6 || dayNumber == 7)
            Console.WriteLine("Этот день выходной");
        else if (0 < dayNumber && dayNumber < 6) 
            Console.WriteLine("Этот день будний"); 
        else 
            Console.WriteLine("Такого дня нет");
    }
}