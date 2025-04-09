using System;

class Tasks
{
    static void Main()
    {
        int value, power = 1;
        Console.Write("Введите число: ");
        value = Convert.ToInt32(Console.ReadLine());
        while (power < value) { power *= 3; }
        if (value == power) { Console.WriteLine("Истина"); }
        else { Console.WriteLine("Ложь"); }
    }
}