using System;

public class Integer11
{
    public static void Main()
    {
        int number, sum, arg, num_1, num_2, num_3;
        Console.WriteLine("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
        num_3 = Num3(number);
        num_2 = Num2(number);
        num_1 = Num1(number);
        sum = Sum(num_3, num_2, num_1);
        arg = Arg(num_3, num_2, num_1);
        Console.WriteLine("Получились числа: {0}, {1}, {2}", num_1, num_2, num_3);
        Console.WriteLine("Сумма равна: {0}", sum);
        Console.WriteLine("Произведение равно: {0}", arg);
    }
    public static int Num3(int num) 
    { 
        return num % 10; 
    }
    public static int Num2(int num)
    {
        return num % 100 / 10;
    }
    public static int Num1(int num)
    {
        return num / 100;
    }
    public static int Sum(int num_3,  int num_2, int num_1)
    {
        int sum;
        sum = num_3 + num_2 + num_1;
        return sum;
    }
    public static int Arg(int num_3, int num_2, int num_1)
    {
        int arg;
        arg = num_3 * num_2 * num_1;
        return arg;
    }
}