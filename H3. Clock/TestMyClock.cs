namespace MyClock
{

    /// <summary>
    /// A class to test the clock.
    /// </summary>
    class TestClock
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            MyClock c1 = new MyClock(5000);
            c1.DisplayClock();

            MyClock c2 = new MyClock(01, 23, 20);
            c2.DisplayClock();


        }
    }
}
