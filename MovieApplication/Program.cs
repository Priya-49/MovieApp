using System;
using MovieApp;

namespace MovieApplication
{
    public class MovieManager
    {
        public static void Main(string[] args)
        {
            MovieCollection TeluguMovies = new MovieCollection();

            TeluguMovies.OnMovieAdded = (title) =>
            {
                Console.WriteLine($"{title} movie details entered successfully.");
            };

            while (true)
            {
                Console.WriteLine("\n---- Movie Menu ----");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Remove Movie");
                Console.WriteLine("3. Display Movies");
                Console.WriteLine("4. Movie Count");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Id: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Release Year: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.Write("Director: ");
                        string director = Console.ReadLine();

                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Rating: ");
                        double rating = double.Parse(Console.ReadLine());

                        TeluguMovies.AddMovie(id, title, year, director, genre, rating);
                        break;

                    case 2:
                        Console.Write("Enter Movie Id to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        TeluguMovies.RemoveMovie(removeId);
                        break;

                    case 3:
                        TeluguMovies.DisplayMovies();
                        break;

                    case 4:
                        Console.WriteLine($"Total Movies: {TeluguMovies.MovieCount()}");
                        break;

                    case 5:
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
