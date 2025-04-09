using System;

class Tasks
{
    static void Main()
    {
        double x, x1, sum;
        Console.Write("Введите x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        sum = Sign(x) + Sign(x1);
        Console.Write("Сумма равна: {0}", sum);
    }
    static double Sign(double val)
    {
        if (val < 0) { return -1; }
        if (val > 0) { return 1; }
        else { return 0; }
    }
}