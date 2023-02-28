using static ExitNotificationClass;
using static s4_task_25_class;
using static s4_task_27_class;
using static s4_task_29_class;

public static class SeminarFourthClass
{
    public static void FourthSeminarHW()
    {
        const int notificationState = 1;
        bool exit_flag = false;
        do
        {
            ExitNotification(notificationState);
            Console.WriteLine("Введите номер задачи из набора [25, 27, 29]:");
            var number = Console.ReadLine();
            switch (number)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "b":
                    exit_flag = true;
                    break;
                case "25":
                    
                    break;
                case "27":
                    
                    break;
                case "29":
                    
                    break;
                default:
                    Console.WriteLine("\nТакой задачи не существует\n");
                    break;
            }
        }
        while (!exit_flag);
    }
}