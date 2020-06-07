using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int x, y;

        Write("Enter first number: ");
        x = Convert.ToInt32(ReadLine());
        Write("Enter second number: ");
        y = Convert.ToInt32(ReadLine());

        if (x == y)
        WriteLine($"{x} and {y} are equal!");
        else
        WriteLine($"{x} and {y} aren't equal...");
    }
}