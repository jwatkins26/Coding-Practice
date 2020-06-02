using System;
using static System.Console;

    class program
    {
        static void Main()
        {
            Write("Please enter a temperature in farhenheit >> ");
            int farhenheit = Convert.ToInt32(ReadLine());
            double celsius = (farhenheit - 32) / 1.8;

            WriteLine($"The temperature in celsius is {celsius}");
        }
    }
