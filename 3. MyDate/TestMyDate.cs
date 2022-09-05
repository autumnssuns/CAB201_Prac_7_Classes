using System;

namespace MyDate
{
    /// <summary>
    /// A class to test the my date class.
    /// </summary>
    class TestMyDate
    {
        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            // Valid constructors

            MyDate d1 = new MyDate(28, 2, 1959);
            Console.WriteLine(d1.Day + "/" + d1.Month + "/" + d1.Year);
            MyDate d2 = new MyDate(28, 2, 1960);
            Console.WriteLine(d2.Day + "/" + d2.Month + "/" + d2.Year);
            MyDate d3 = new MyDate(28, 2, 2000);
            Console.WriteLine(d3.Day + "/" + d3.Month + "/" + d3.Year);

            // Invalid constructors

            //MyDate d4 = new MyDate(32, 12, 1959);
            //MyDate d5 = new MyDate(30, 13, 1959);
            //MyDate d6 = new MyDate(31, 4, 1959);
            //MyDate d7 = new MyDate(31, 6, 1959);
            //MyDate d8 = new MyDate(31, 9, 1959);
            //MyDate d9 = new MyDate(31, 11, 1959);
            //MyDate d10 = new MyDate(31, 2, 1959);
            //MyDate d11 = new MyDate(29, 2, 1959);
            //MyDate d12 = new MyDate(29, 2, 1900);
        }
    }
}
