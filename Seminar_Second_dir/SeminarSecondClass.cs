using static ExitNotificationClass;
using static task_10_class;
using static task_13_class;
using static task_15_class;
public static class SeminarSecondClass
{
    public static void SecondSeminarHW ()
    {
        const int notificationState = 1;
        bool exit_flag = false;
        do
        {
            ExitNotification(notificationState);
            Console.WriteLine("Введите номер задачи из набора [10, 13, 15]:");
            var number = Console.ReadLine();
            switch (number)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "b":
                    exit_flag = true;
                    break;
                case "10":
                    s2_FirstTaskSolution();
                    break;
                case "13":
                    
                    break;
                case "15":
                    
                    break;
                default:
                    Console.WriteLine("\nТакой задачи не существует\n");
                    break;
            }
        }
        while(!exit_flag);
    }
}