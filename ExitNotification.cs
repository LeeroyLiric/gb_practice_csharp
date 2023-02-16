public static class ExitNotificationClass
{
    public static void ExitNotification(int state)
    {
        if (state == 0) Console.WriteLine("Чтобы выйти введите 'q'");
        if (state == 1) Console.WriteLine("Чтобы вернуться к выбору семинара введите 'b' или введите 'q' для выхода");
    }
    
}