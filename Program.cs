﻿using static ExitNotificationClass;
using static SeminarFirstClass;
using static SeminarSecondClass;
using static SemThirdClass;
internal class Program
{
    
    private static void Main(string[] args)
    {
        const int notificationState = 0;
        bool exit_flag = false; 

        do
        {   
            ExitNotification(notificationState);
            Console.WriteLine("Введите номер семинара (1-3):");
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
                    SecondSeminarHW();
                    break;
                case "3":
                    ThirdSeminarHW();
                    break;
                /*
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
                */
                default:
                    Console.WriteLine("Такого семинара не существует!\n");
                    break;
            }
        }
        while(!exit_flag);

    }

}
