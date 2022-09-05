using System;

namespace MyClock
{
    /// <summary>
    /// A class to test the my clock class.
    /// </summary>
    class TestMyClock
    {
        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {

            // Display a valid connection
            MyClock c1 = new MyClock(10, 30, 20);
            Console.WriteLine("The clock value is " + c1.Hour + " " + c1.Minute + " " + c1.Second);

            // These are invalid connections

            //            MyClock c2 = new MyClock(0, 1, 1);
            //            MyClock c3 = new MyClock(13, 1, 1);
            //            MyClock c4 = new MyClock(12, -1, 1);
            //            MyClock c5 = new MyClock(12, 60, 1);
            //            MyClock c6 = new MyClock(12, 59, -1);
            //            MyClock c7 = new MyClock(12, 59, 60);
        }
    }
}