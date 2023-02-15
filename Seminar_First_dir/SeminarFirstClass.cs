using static ExitNotificationClass;
public static class SeminarFirstClass
{
    public static void FirstSeminarHW ()
    {
        const int notificationState = 1;
        bool exit_flag = false;
        do
        {
            Console.WriteLine("Введите номер задачи из набора [1, 2, 3, 4]:");
            ExitNotification(notificationState);
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case -1:
                    exit_flag = true;
                    break;
                case 1:
                    task_1_class my_first_task = new task_1_class();
                    my_first_task.solution();
                    ExitNotification(notificationState);
                    break;
            }
        }
        while(!exit_flag);
    }
}