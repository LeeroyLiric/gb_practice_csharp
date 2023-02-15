using static ExitNotificationClass;
internal class Program
{
    
    private static void Main(string[] args)
    {
        const int notificationState = 0;
        bool exit_flag = false; 

        do
        {
            Console.WriteLine("Введите номер семинара (1-2):");
            ExitNotification(notificationState);
            int seminarNumber = Convert.ToInt32(Console.ReadLine());
            switch (seminarNumber)
            {
                case -1:
                    exit_flag = true;
                    break;
                case 1:
                    FirstSeminarHW ();
                    ExitNotification(notificationState);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }
        while(!exit_flag);

    }

    

    private static void FirstSeminarHW ()
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
