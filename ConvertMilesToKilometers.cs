using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
   double miles;
   double distance;
   Write("Please enter number of miles >> ");
   miles = Convert.ToInt32(ReadLine());
   distance = ConvertToKilometers(miles);
   WriteLine("{0}", distance);

   }
   public static double ConvertToKilometers(double miles)
   {
     const double kilometer = 1.60934;
     double kilometers = miles * kilometer;
     return kilometers;
   }
}
