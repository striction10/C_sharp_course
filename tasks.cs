using System;

public class begin32
{
    public static void Main()
    {
        double t;
        Console.WriteLine("Введите температуру по Цельсию: ");
        t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(t);
        Console.WriteLine("Ответ: {0:F2}", Change(t));
    }
    public static double Change(double t)
    {
        double tf;
        tf = t * (9.0 / 5.0) + 32;
        return tf;
    }
}