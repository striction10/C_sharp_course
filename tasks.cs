using System;

class Tasks
{
    static void Main()
    {
        int a, b;
        int arg = 1;
        Console.Write("Введите A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите B: ");
        b = Convert.ToInt32(Console.ReadLine());
        for (int i = a;  a <= b; a ++)
        {
            arg *= a;
        }
        Console.WriteLine("{0}", arg);
    }
}