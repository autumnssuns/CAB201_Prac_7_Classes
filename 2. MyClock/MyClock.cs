using System;

namespace MyClock
{
    /// <summary>
    /// A class to represent a clock.
    /// </summary>
    class MyClock
    {
        private int hours, minutes, seconds;
        public int Hours { get { return hours; } }
        public int Minutes { get { return minutes; } }
        public int Seconds { get { return seconds; } }
        public MyClock(int hours, int minutes, int seconds)
        {
            if (hours < 0 || minutes < 0 || seconds < 0) Console.WriteLine("Hours, minutes and " + 
                "seconds cannot be less than 0");
            else
            {
                if (hours >= 24) Console.WriteLine("The hours must be less than 24");
                else this.hours = hours;
                if (minutes >= 60) Console.WriteLine("The minutes must be less than 60");
                else this.minutes = minutes;
                if (seconds >= 60) Console.WriteLine("The seconds must be less than 60");
                else this.seconds = seconds;
            }
        }
    }
}

