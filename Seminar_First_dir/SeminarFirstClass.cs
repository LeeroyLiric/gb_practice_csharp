using static ExitNotificationClass;
using static task_2_class;
using static task_3_class;
using static task_4_class;
public static class SeminarFirstClass
{
    public static void FirstSeminarHW ()
    {
        const int notificationState = 1;
        bool exit_flag = false;
        do
        {
            ExitNotification(notificationState);
            Console.WriteLine("Введите номер задачи из набора [1, 2, 3, 4]:");
            var number = Console.ReadLine();
            switch (number)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "b":
                    exit_flag = true;
                    break;
                case "1":
                    task_1_class my_first_task = new task_1_class();
                    my_first_task.solution();
                    break;
                case "2":
                    SecondTaskSolution();
                    break;
                case "3":
                    ThirdTaskSolution();
                    break;
                case "4":
                    FourthTaskSolution();
                    break;
                default:
                    Console.WriteLine("\nТакой задачи не существует\n");
                    break;
            }
        }
        while(!exit_flag);
    }
}