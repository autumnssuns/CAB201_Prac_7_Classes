using System;

namespace MyClock
{
    /// <summary>
    /// A class to represent a clock.
    /// </summary>
    class MyClock
    {
        /// <summary>
        /// The hour.
        /// </summary>
        private int hour;

        /// <summary>
        /// The minute.
        /// </summary>
        private int minute;

        /// <summary>
        /// The second.
        /// </summary>
        private int second;

        /// <summary>
        /// The hour.
        /// </summary>
        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                if ((value > 23) || (value < 0))
                {
                    Console.WriteLine("Error");
                    Environment.Exit(-1);
                }
                hour = value;
            }
        }

        /// <summary>
        /// The minute.
        /// </summary>
        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                if ((value > 59) || (value < 0))
                {
                    Console.WriteLine("Error");
                    Environment.Exit(-1);
                }
                minute = value;
            }
        }

        /// <summary>
        /// The second.
        /// </summary>
        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                if ((value > 59) || (value < 0))
                {
                    Console.WriteLine("Error");
                    Environment.Exit(-1);
                }
                second = value;
            }

        }

        /// <summary>
        /// Create a clock.
        /// </summary>
        /// <param name="hour">The hour.</param>
        /// <param name="minute">The minute.</param>
        /// <param name="second">The second.</param>
        public MyClock(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}

