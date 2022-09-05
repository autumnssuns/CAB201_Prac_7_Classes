﻿using System;
using System.Collections.Generic;
using System.Text;

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
        public string Name { get; private set;}
        
        /// <summary>
        /// The list of DVD Rentals.
        /// </summary>
        private List<Movie> dvdRentals;

        /// <summary>
        /// The user.
        /// </summary>
        /// <param name="name">The user's name.</param>
        public User(string name)
        {
            this.Name = name;
            dvdRentals = new List<Movie>();
        }

        /// <summary>
        /// A method that adds a DVD movie for a user.
        /// </summary>
        /// <param name="dvdname">The DVD's name.</param>
        public void AddMovie(string dvdname)
        {
            dvdRentals.Add(new Movie(dvdname));
        }

        /// <summary>
        /// Gets the list of DVD movies.
        /// </summary>
        /// <returns>A list of DVD movies.</returns>
        public string GetMovies()
        {
            string movies = "";
            for(int i=0; i<dvdRentals.Count; i++)
            {
                movies += String.Format("{0}:{1}, ", 
                    dvdRentals[i].MovieName, dvdRentals[i].WatchCount);
            }
            movies  = movies.Trim(',');
            return movies;
        }

        /// <summary>
        /// Increase the watch count of a movie by one given its name
        /// </summary>
        /// <param name="name">The name of the movie</param>
        public void WatchMovie(string name)
        {
            for (int i = 0; i < dvdRentals.Count; i++)
            {
                if (dvdRentals[i].MovieName == name)
                {
                    dvdRentals[i].IncreaseWatchCount();
                }
            }
        }
    }
}
