namespace gb_practice_csharp.Seminar_9_dir
{
    public static class SeminarNinthClass
    {
        public static void NinthSeminarHW()
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
                        TaskFirstClass.Solution();
                        break;
                    case "2":
                        TaskSecondClass.Solution();
                        break;
                    case "3":
                        TaskThirdClass.Solution();
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