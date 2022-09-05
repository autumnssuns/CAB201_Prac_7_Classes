namespace NotFlix
{
    /// <summary>
    /// A representation of a movie.
    /// </summary>
    class Movie
    {
        /// <summary>
        /// The movie's name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The time that a movie have been watched.
        /// </summary>
        public int Time { get; private set; }

        /// <summary>
        /// A movie.
        /// </summary>
        /// <param name="name">The movie's name.</param>
        /// <param name="time">The time that a movie have been watched.</param>
        public Movie(string name, int time)
        {
            this.Name = name;
            this.Time = time;
        }

    }
}
