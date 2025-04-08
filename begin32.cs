using System;

class begin32
{
    static void Main()
    {
        int a, b, c;
        Console.WriteLine("Введите три целых числа: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        if (a <= b && b <= c) Console.WriteLine("Истинно");
        else Console.WriteLine("Ложно");
    }
}