using System;

namespace MyDate
{
    /// <summary>
    /// A class that references a date.
    /// </summary>
    class MyDate
    {
        private int year, month, day;
        public int Year { get { return year; } }
        public int Month { get { return month; } }
        public int Day { get { return day; } }

        public MyDate(int year, int month, int day)
        {
            if (year <= 0 || month <= 0 || day <= 0)
                Console.WriteLine("Year, month and day cannot be zero or less");
            else
            {
                this.year = year;
                if (month > 12) Console.WriteLine("The month cannot be greater than 12");
                else this.month = month;
                bool isLeapYear = (year % 100 != 0 || year % 400 == 0) && (year % 4 == 0);
                int dayLimit;
                switch (month)
                {
                    case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                        dayLimit = 31;
                        break;
                    case 2:
                        if (isLeapYear) dayLimit = 29;
                        else dayLimit = 28;
                        break;
                    default:
                        dayLimit = 30;
                        break;
                }
                if (day > dayLimit)
                    Console.WriteLine("Month {0} should have at max {1} days", month, dayLimit);
                else this.day = day;
            }
        }
    }
}