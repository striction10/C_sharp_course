using System;

class begin32
{
    static void Main()
    {
        double t, tf;
        Console.WriteLine("Введите температуру по Цельсию: ");
        t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(t);
        tf = t * (9.0 / 5.0) + 32;
        Console.WriteLine("Ответ: {0}", tf);
    }
}