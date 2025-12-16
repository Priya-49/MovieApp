using System;
using System.Collections.Generic;
using System.Text;


namespace MovieApp
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public Movie(int id, string title, int releaseYear, string director, string genre, double rating)
        {
            Id = id;
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Genre = genre;
            Rating = rating;

        }
        public void Display()
        {
            Console.WriteLine(
                $"Id: {Id}, Title: {Title}, Year: {ReleaseYear}, Director: {Director}, Genre: {Genre}, Rating: {Rating}"
            );
        }
    }

}

