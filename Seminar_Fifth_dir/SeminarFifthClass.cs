using static ExitNotificationClass;

namespace gb_practice_csharp.SeminarFifthDir
{
    public static class SeminarFifthClass
    {
        public static void FifthSeminarHW()
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
                        s5_task_1_class.Solution_s5_t1();
                        break;
                    case "2":
                        s5_task_2_class.Solution_s5_t2();
                        break;
                    case "3":
                        s5_task_3_class.Solution_s5_t3();
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