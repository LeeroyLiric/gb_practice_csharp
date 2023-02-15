internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер задачи из набора [1, 2, 3, 4]:");
        var number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                task_1_class my_first_task = new task_1_class();
                my_first_task.solution();
                break;
        }

    }
}
