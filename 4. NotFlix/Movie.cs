using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotFlix
{
    internal class Movie
    {
        private string movieName;
        private int watchCount;
        public Movie(string movieName)
        {
            this.movieName = movieName;
            watchCount = 0;
        }
        public int WatchCount
        {
            get { return watchCount; }
        }
        public string MovieName
        {
            get { return movieName; }
        }
        // This is absolutely fine - just 
        // add some validation
        //public int WatchCount
        //{
        //    get { return watchCount; }
        //    set { watchCount = value; }
        //}
        public void IncreaseWatchCount()
        {
            watchCount++;
        }
    }
}
