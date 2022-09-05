using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate date = new MyDate(year: 1904, month: 2, day: 29);
            Console.WriteLine("The date was {0}/{1}/{2}", date.Day, date.Month, date.Year);
        }

        /// <summary>
        /// Method to check if a year is a leap year
        /// </summary>
        /// <param name="year">The input year</param>
        /// <returns>true if the year is a leap year, false otherwise</returns>
        static bool CheckLeapYear(int year)
        {
            return (year % 100 != 0 || year % 400 == 0) && 
                (year % 4 == 0);
        }
    }
}
