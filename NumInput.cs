using System;
using static System.Console;
namespace NumInput
{
    class Program
    {
        static void Main()
        {
            Write("Enter first number >>> ");
            float x = Convert.ToInt32(ReadLine());
            Write("Enter second number >>> ");
            float y = Convert.ToInt32(ReadLine());

            WriteLine("{0} + {1} = {2}", x, y, x + y);
            WriteLine("{0} - {1} = {2}", x, y, x - y);
            WriteLine("{0} * {1} = {2}", x, y, x * y);
            WriteLine("{0} / {1} = {2}", x, y, x / y);
            WriteLine("{0} Mod {1} = {2}", x, y, x % y);
        }
    }
}