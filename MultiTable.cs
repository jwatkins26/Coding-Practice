using System;
using static System.Console;
namespace MultiTable
{
    class Program
    {
        static void Main()
        {
            int x;
            int answer;
            Write("Please enter a number: ");
            x = Convert.ToInt32(ReadLine());
            WriteLine("The Table is as Follows:");
            answer = x * 1;
            WriteLine("{0} x 1 = {1}", x, answer);
            answer = x * 2;
            WriteLine("{0} x 2 = {1}", x, answer);
            answer = x * 3;
            WriteLine("{0} x 3 = {1}", x, answer);
            answer = x * 4;
            WriteLine("{0} x 4 = {1}", x, answer);
            answer = x * 5;
            WriteLine("{0} x 5 = {1}", x, answer);
            answer = x * 6;
            WriteLine("{0} x 6 = {1}", x, answer);
            answer = x * 7;
            WriteLine("{0} x 7 = {1}", x, answer);
            answer = x * 8;
            WriteLine("{0} x 8 = {1}", x, answer);
            answer = x * 9;
            WriteLine("{0} x 9 = {1}", x, answer);
            answer = x * 10;
            WriteLine("{0} x 10 = {1}", x, answer);

        }
    }
}