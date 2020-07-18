using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
    static void Main()
    {
        Write("Enter length of the room in feet >> ");
        int length = Convert.ToInt32(ReadLine());
        Write("Enter width of room in feet >> ");
        int width = Convert.ToInt32(ReadLine());
        double TotalPrice = ComputeCost(length, width);
        WriteLine("Cost of job for {0} x {1} foot room is {2}", length, width, TotalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    public static double ComputeCost(int length, int width)     
    {
        const int height = 9;
        const int price = 6;
        int sqL = length * height;
        int sqW = width * height;
        int TotalSqFt = (sqL * 2) + (sqW * 2); 
        double value = TotalSqFt * price;
        return value;
    }
}
