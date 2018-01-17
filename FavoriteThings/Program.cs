using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {

            var movies = new List<Movie>
            {
                new Movie { MovieTitle = "Fight Club", Favorite = true },
                new Movie { MovieTitle = "The Shawshank Redemption", Favorite = false },
                new Movie { MovieTitle = "Star Wars: The Force Awakens", Favorite = false }
            };

            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.MovieTitle}");
                Console.WriteLine(movie.DavidsFavoriteMovie());
            }

        }
    }
}
