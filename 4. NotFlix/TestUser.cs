using System;

namespace NotFlix
{


    /// <summary>
    /// A class to test the user class.
    /// </summary>
    class TestUser
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {

            User sam = new User("Sam");
            User bob = new User("Bob");

            sam.AddMovie("Rocky");
            sam.AddMovie("Rocky II");
            sam.AddMovie("Rocky IV");
            sam.WatchMovie("Rocky");
            sam.WatchMovie("Rocky");
            sam.WatchMovie("Rocky");
            sam.WatchMovie("Rocky");
            Console.WriteLine(sam.Name + " favourite movies " + sam.GetMovies());

            bob.AddMovie("Citizen Kane");
            bob.AddMovie("Gone with the Wind");
            bob.AddMovie("Roman Holiday");
            bob.WatchMovie("Roman Holiday");
            Console.WriteLine(bob.Name + " favourite movies " + bob.GetMovies());
        }
    }
}
