
namespace Newspaper
{

    /// <summary>
    /// A class to test the newspapers.
    /// </summary>
    class TestNewspaper
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            Newspaper times = new Newspaper("The times", 2.5);
            times.AddArticle("Dewey Defeats Truman", "GOP Sweep Indicated in State", "Dewey", "dewey.jpg");
            times.AddArticle("Man on the Moon", "Its very pretty up here...a fine soft surface", "Man on Moon", "mom.jpg");
            times.AddArticle("Lincoln Shot", "Condition Considered Hopeless", "Lincoln (1809-1865) ", "lincoln.jpg");

        }
    }
}
