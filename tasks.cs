using System;

class Tasks
{
    static void Main()
    {
        double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
        double arg;
        Console.Write("Введите числа: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        num2 = Convert.ToDouble(Console.ReadLine());
        num3 = Convert.ToDouble(Console.ReadLine());
        num4 = Convert.ToDouble(Console.ReadLine());
        num5 = Convert.ToDouble(Console.ReadLine());
        num6 = Convert.ToDouble(Console.ReadLine());
        num7 = Convert.ToDouble(Console.ReadLine());
        num8 = Convert.ToDouble(Console.ReadLine());
        num9 = Convert.ToDouble(Console.ReadLine());
        num10 = Convert.ToDouble(Console.ReadLine());
        arg = num1 * num2 * num3 * num4 * num5 * num6 * num7 * num8 * num9 * num10;
        Console.WriteLine("Ответ: {0}", arg);
    }
}