using System;

class begin32
{
    static void Main()
    {
        int number, sum, arg, num_1, num_2, num_3;
        Console.WriteLine("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
        num_3 = number % 10;
        num_2 = number % 100 / 10;
        num_1 = number / 100;
        sum = num_3 + num_2 + num_1;
        arg = num_3 * num_2 * num_1;
        Console.WriteLine("Получились числа: {0}, {1}, {2}", num_1, num_2, num_3);
        Console.WriteLine("Сумма равна: {0}", sum);
        Console.WriteLine("Произведение равно: {0}", arg);
    }
}