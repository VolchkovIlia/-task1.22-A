using System;
public class Mainclass
{
public static void Main()
    {
        int x, y;
        Console.WriteLine("Введите Х:");
        x = int.Parse(Console.ReadLine());
        y = 7 * x * x - 3 * x + 6;
        Console.WriteLine("Значение функции {0}", y);
    }
}