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

            sam.AddMovie("Rocky", 100);
            sam.AddMovie("Rocky II", 120);
            sam.AddMovie("Rocky IV", 10);
            Console.WriteLine(sam.Name + " favourite movies " + sam.GetMovies());

            bob.AddMovie("Citizen Kane", 30);
            bob.AddMovie("Gone with the Wind", 60);
            bob.AddMovie("Roman Holiday", 70);
            Console.WriteLine(bob.Name + " favourite movies " + bob.GetMovies());
        }
    }
}
