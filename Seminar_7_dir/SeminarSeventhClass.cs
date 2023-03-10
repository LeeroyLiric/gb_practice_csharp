using static ExitNotificationClass;

namespace gb_practice_csharp.Seminar_7_dir
{
    public static class SeminarSeventhClass
    {
        public static void SeventhSeminarHW()
        {
            const int notificationState = 1;
            bool exit_flag = false;
            do
            {
                ExitNotification(notificationState);
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
                        S7_task_1_Class.Solution_S7_T1();
                        break;
                    case "2":
                        Seminar_7_dir.TaskSecond.Solution();
                        break;
                    case "3":
                        
                        break;
                    default:
                        Console.WriteLine("\nТакой задачи не существует\n");
                        break;
                }
            }
            while (!exit_flag);
        }
    }
}