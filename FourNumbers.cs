using System;
using static System.Console;
namespace FourNumbers 
{
    class Program
    {
        static void Main()
        {
            
            Write("Enter first number... ");
            double a = Convert.ToInt32(ReadLine());
            Write("Enter second number... ");
            double b = Convert.ToInt32(ReadLine());
            Write("Enter third number... ");
            double c = Convert.ToInt32(ReadLine());
            Write("Enter fourth number... ");
            double d = Convert.ToInt32(ReadLine());

            double average = (a + b + c + d) / 4;
            WriteLine($"The average of {a}, {b}, {c}, and {d} is {average}");


        }
    }
}