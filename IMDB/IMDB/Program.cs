using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    internal class Program
    {
        private static string name;
        private static float rating;

        static void Main(string[] args)
        {
            List<movie> movieList = new List<movie>();
            bool addMore = true;
            while (addMore)
            {
                Console.WriteLine("enter movies name");
                name = Console.ReadLine();

                Console.WriteLine("choose rating between 1 and 9");
                while (!float.TryParse(Console.ReadLine(), out rating) || rating < 1 || rating > 9)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                }
                movie newMovie = new movie { movie_name = name, IMDB = rating };
                movieList.Add(newMovie);

                Console.WriteLine("do you want to add another movie");
                string response = Console.ReadLine().ToLower();
                addMore = (response == "yes" || response == "y");

            }


            Console.WriteLine("all movies: ")
            foreach (var m in  movieList)
            {
                Console.WriteLine($"Name: {m.movie_name}, IMDB rating: {m.IMDB}");
            }

            Console.WriteLine("movies filtered with IMDB rating between 4 and 9: ");
            foreach (var m in movieList)
            {
                if (m.IMDB >= 4 && m.IMDB <= 9)
                Console.WriteLine($"Name: {m.movie_name}, IMDB rating: {m.IMDB}");
            }

            Console.WriteLine("movies  filtered that starts w ith letter A: ");
            foreach (var m in movieList)
            {
                if (!string.IsNullOrEmpty(m.movie_name) && m.movie_name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"Name: {m.movie_name}, IMDB rating: {m.IMDB}");
            }



        }

        
    }
}
