public static class ExitNotificationClass
{
    public static void ExitNotification(int state)
    {
        if (state == 0) Console.WriteLine("Чтобы выйти введите 'q' или нажмите Ctrl + C");
        if (state == 1) Console.WriteLine("Чтобы вернуться к выбору семинара введите 'q' или нажмите Ctrl + C для прерывания программы");
        if (state == 2) Console.WriteLine("Чтобы вернуться к выбору задачи введите 'q' или нажмите Ctrl + C для прерывания программы");
    }
    
}