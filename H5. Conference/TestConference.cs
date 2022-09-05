using System;

namespace Conference
{

    /// <summary>
    /// A class to test the conferece.
    /// </summary>
    class TestConference
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Conference con = new Conference("World Wide Web", "https://www.www.com", "Brisbane");
            con.AddAttendee("Bill Gates", "bill@microsoft.com", 100, "Blue");
            con.AddAttendee("Sergey Brin", "sergey@google.com", 80, "White");
            con.AddAttendee("Steve Jobs", "jobs@apple.com", 120, "Black");

            Console.WriteLine("Conference " + con.Name + " held at " + con.Location + " with website " + con.Website + " attendees " + con.PrintAttendees());

        }
    }
}
