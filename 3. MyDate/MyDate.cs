using System;

namespace MyDate
{
    /// <summary>
    /// A class that references a date.
    /// </summary>
    class MyDate
    {
        private int year, month, day;

        public int Year
        {
            get { return year; }
        }

        public int Month
        {
            get { return month; }
        }

        public int Day
        {
            get { return day; }
        }

        public MyDate(int year, int month, int day)
        {
            if (year <= 0 || month <= 0 || day <= 0)
            {
                Console.WriteLine("The year, month or day cannot be negative or 0");
                return; // Temrinate the constructor
            }
            this.year = year;
            if (month > 12)
            {
                Console.WriteLine("The month must be between 1 and 12");
                return;
            }
            this.month = month;
            bool isLeapYear = (year % 100 != 0 || year % 400 == 0) &&
               (year % 4 == 0);
            int dayUpperLimit;
            switch (month)
            {
                case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                    dayUpperLimit = 31;
                    break;
                case 2:
                    if (isLeapYear) dayUpperLimit = 29;
                    else dayUpperLimit = 28;
                    //dayUpperLimit = isLeapYear ? 29 : 28; // Unofficial in CAB201
                    break;
                default:
                    dayUpperLimit = 30;
                    break;
            }
            if (day <= dayUpperLimit)
            {
                this.day = day;
            } else
            {
                Console.WriteLine("The day in month {0} cannot be greater than {1}", 
                    month, dayUpperLimit);
            }
        }
    }
}