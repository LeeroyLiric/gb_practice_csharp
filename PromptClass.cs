public static class PromptClass
{
    public static int Prompt(string message)
    {
        Console.WriteLine(message);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
    }
}