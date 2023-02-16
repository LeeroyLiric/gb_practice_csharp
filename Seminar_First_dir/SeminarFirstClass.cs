using static ExitNotificationClass;
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
                    exit_flag = true;
                    break;
                case "1":
                    task_1_class my_first_task = new task_1_class();
                    my_first_task.solution();
                    break;
            }
        }
        while(!exit_flag);
    }

    private static void SecondTask()
    {

    }
}