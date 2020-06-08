using System;
using static System.Console;
namespace MultiTable
{
    class Program
    {
        static void Main()
        {
            int x;
            int y;
            Write("Please enter a number: ");
            x = Convert.ToInt32(ReadLine());
            
            for(y = 1; y <= 12; y++)
            WriteLine("{0} x {1} = {2}", x, y, x * y);

        }
    }
}