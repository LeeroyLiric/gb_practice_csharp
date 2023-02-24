/*
    Задача 2

    Напишите программу, которая принимает на вход координаты двух точек
    и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
public static class s3_task_2_class
{
    public static void s3_SecondTaskSolution()
    {
        double parsed;
        List<double> coordinates = new List<double>();
        Console.WriteLine("Введите координаты точек в одной строке по маске:\nA (x,y,z); B (x1,y1,z1);");
        var inputs = Console.ReadLine();
        if (inputs != null)
        {
            string[] splittedInput = inputs.Split(new[] { ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach ( var input in splittedInput ) 
            {
                if (double.TryParse(input, out parsed)) coordinates.Add(parsed);
            }

            if (coordinates.Count() != 6)
            {
                Console.WriteLine("Вы ввели некорректные числа! Запустите задачу заново и попробуйте ещё раз\n");
                return;
            }
            
            double distance = Math.Sqrt(
                Math.Pow(coordinates[0] - coordinates[3], 2) + // x - x1
                Math.Pow(coordinates[1] - coordinates[4], 2) + // y - y1
                Math.Pow(coordinates[2] - coordinates[5], 2)); // z - z1

            Console.WriteLine(Math.Round(distance, 2).ToString());
        }
        else
        {
            Console.WriteLine("Вы не ввели числа! Запустите задачу заново и попробуйте ещё раз\n");
        }

    }
}