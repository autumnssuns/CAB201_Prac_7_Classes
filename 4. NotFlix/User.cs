using System.Collections.Generic;

namespace NotFlix
{

    /// <summary>
    /// A class that represents a user class for a NotFlix representation. 
    /// </summary>
    class User
    {

        /// <summary>
        /// The user's name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The user's list of movies.
        /// </summary>
        private List<Movie> movies;

        /// <summary>
        /// The user.
        /// </summary>
        /// <param name="name">The user's name.</param>
        public User(string name)
        {
            this.Name = name;
            this.movies = new List<Movie>();
        }

        /// <summary>
        /// A method that adds a movie for a user.
        /// </summary>
        /// <param name="dvdname">The movie's name.</param>
        /// <param name="time">The movie's time that someone has watched it.</param>
        public void AddMovie(string movieName, int time)
        {
            Movie movie = new Movie(movieName, time);
            movies.Add(movie);
        }

        /// <summary>
        /// Gets the list of movies.
        /// </summary>
        /// <returns>A list of movies.</returns>
        public string GetMovies()
        {
            string movieNames = "";
            for (int i = 0; i < movies.Count; i++)
            {
                movieNames += movies[i].Name + ",";
            }
            movieNames = movieNames.Trim(',');
            return movieNames;
        }

    }
}
