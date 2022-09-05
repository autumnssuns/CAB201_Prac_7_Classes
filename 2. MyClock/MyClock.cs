using System;

namespace MyClock
{
    /// <summary>
    /// A class to represent a clock.
    /// </summary>
    class MyClock 
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get { return hours; }
        }

        public int Minutes
        {
            get { return minutes; }
        }

        public int Seconds
        {
            get { return seconds; }
        }

        public MyClock(int hours, int minutes, int seconds)
        {
            if (hours >= 0 && hours < 24)
            {
                this.hours = hours;
            } else
            {
                Console.WriteLine("Invalid hours input");
            }
            if (minutes >= 0 && minutes < 60) 
            {
                this.minutes = minutes;
            }
            else
            {
                Console.WriteLine("Invalid minutes input");
            }
            if (seconds >= 0 && seconds < 60)
            {
                this.seconds = seconds;
            }
            else
            {
                Console.WriteLine("Invalid seconds input");
            }
        }
    }
}

