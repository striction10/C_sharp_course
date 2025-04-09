using System;

class tasks
{
    static void Main()
    {
        int num_1, num_2, num_3;
        int min;
        Console.WriteLine("Введите три числа:");
        num_1 = Convert.ToInt32(Console.ReadLine());
        num_2 = Convert.ToInt32(Console.ReadLine());
        num_3 = Convert.ToInt32(Console.ReadLine());
        min = num_1;
        if (num_2 < min) { min = num_2; }
        if (num_3 < min) { min = num_3; }
        Console.WriteLine("Min: {0}", min);
    }
}