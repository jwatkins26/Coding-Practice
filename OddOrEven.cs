using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int num, mod;
        Write("\nPlease enter a number >>> ");
        num = Convert.ToInt32(ReadLine());
        mod = num % 2;
        if(mod == 0)
            WriteLine("{0} is even!", num);
        else
            WriteLine("{0} is odd!", num);
    }
}