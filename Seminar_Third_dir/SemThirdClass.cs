
public static class SemThirdClass
{
    public static void ThirdSeminarHW()
    {
        const int notificationState = 1;
        bool exit_flag = false;
        do
        {
            ExitNotificationClass.ExitNotification(notificationState);
            Console.WriteLine("Введите номер задачи из набора [1, 2, 3]:");
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
                    s3_task_1_class.s3_FirstTaskSolution();
                    break;
                case "2":
                    s3_task_2_class.s3_SecondTaskSolution();
                    break;
                case "3":
                    s3_task_3_class.s3_ThirdTaskSolution();
                    break;
                default:
                    Console.WriteLine("\nТакой задачи не существует\n");
                    break;
            }
        }
        while(!exit_flag);

    }
}