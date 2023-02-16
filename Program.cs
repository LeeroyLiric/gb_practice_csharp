using static ExitNotificationClass;
using static SeminarFirstClass;
internal class Program
{
    
    private static void Main(string[] args)
    {
        const int notificationState = 0;
        bool exit_flag = false; 

        do
        {   
            ExitNotification(notificationState);
            Console.WriteLine("Введите номер семинара (1-2):");
            var seminarNumber = Console.ReadLine();
            switch (seminarNumber)
            {
                case "q":
                    exit_flag = true;
                    break;
                case "1":
                    FirstSeminarHW ();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
            }
        }
        while(!exit_flag);

    }

}
