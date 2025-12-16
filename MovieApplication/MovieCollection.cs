using System;
using System.Collections.Generic;

namespace MovieApp
{
    public class MovieCollection
    {
        private Dictionary<int, Movie> MovieList;

        public Action<string> OnMovieAdded;

        public MovieCollection()
        {
            MovieList = new Dictionary<int, Movie>();
        }

        public void AddMovie(int id, string title, int releaseYear, string director, string genre, double rating)
        {
            if (MovieList.ContainsKey(id))
            {
                Console.WriteLine("Movie with same Id already exists.");
                return;
            }

            Movie movie = new Movie(id, title, releaseYear, director, genre, rating);
            MovieList.Add(id, movie);
            OnMovieAdded?.Invoke(title);
        }

        public void RemoveMovie(int id)
        {
            if (MovieList.Remove(id))
                Console.WriteLine("Movie removed successfully.");
            else
                Console.WriteLine("Movie not found.");
        }

        public int MovieCount()
        {
            return MovieList.Count;
        }

        public void DisplayMovies()
        {
            if (MovieList.Count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            foreach (Movie movie in MovieList.Values)
            {
                movie.Display();
            }
        }
    }
}


