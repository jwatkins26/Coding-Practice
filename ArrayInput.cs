using System;
using static System.Console;
class ArrayInput
{
    public static void Main()
    {
        int[] input = new int[10];
        int i;

        WriteLine("Please enter ten numbers:");

        for (i = 0; i < 10; i++)
        {
            Write("Number {0}: ", i);
            input[i] = Convert.ToInt32(ReadLine());
        }

        WriteLine("\nThe Array is:");

        for (i = 0; i < 10; i++)
        {
            WriteLine("\n{0}", input[i]);

        }

        


    }
}