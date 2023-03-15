namespace gb_practice_csharp.Seminar_8_dir
{
    public static class SeminarEighthClass
    {
        public static void EighthSeminarHW()
        {
            const int notificationState = 1;
            bool exit_flag = false;
            do
            {
                ExitNotificationClass.ExitNotification(notificationState);
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
                        Seminar_8_dir.TaskFirst.Solution();
                        break;
                    case "2":
                        Seminar_8_dir.TaskSecond.Solution();
                        break;
                    case "3":
                        Seminar_8_dir.TaskThird.Solution();
                        break;
                    case "4":
                        Seminar_8_dir.TaskFourth.Solution();
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