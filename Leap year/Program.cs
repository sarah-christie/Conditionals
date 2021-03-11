using System;

namespace Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {

            int year;
            year = Convert.ToInt16(Console.ReadLine());

            if ((year % 4 == 0 && year % 400 == 0) || (year % 4 == 0 && !(year % 100 == 0)))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
                Console.WriteLine(year + " is NOT a leap year");
            
        }
    }
}
