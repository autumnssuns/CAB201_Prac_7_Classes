
namespace NotFlix
{
    internal class Movie
    {
        private string movieName;
        private int watchCount;

        public string MovieName { get { return movieName; } }
        public int WatchCount { get { return watchCount; } }

        public Movie(string name)
        {
            movieName = name;
            watchCount = 0;
        }

        public void IncreaseWatchCount()
        {
            watchCount++;
        }
    }
}