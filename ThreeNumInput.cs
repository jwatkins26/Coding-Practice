using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int x, y, z;

        Write("\nEnter the first number >>> ");
        x = Convert.ToInt32(ReadLine());
        Write("\nEnter the second number >>> ");
        y = Convert.ToInt32(ReadLine());
        Write("\nEnter the third number >>> ");
        z = Convert.ToInt32(ReadLine());

        WriteLine("\n<------------------------------------>");

        WriteLine("\nThe result of ({0} + {1}) x {2} = {3}", x, y, z, (x + y) * z);
        Write("\nThe result of {0}.{1} + {1}.{2} = {3}", x, y, z, (x * y) + (y * z));
    }
}