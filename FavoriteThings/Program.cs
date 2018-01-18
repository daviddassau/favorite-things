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
                Console.WriteLine(movie.DavidsFavoriteMovie());
            }


            var books = new List<Book>
            {
                new Book { BookTitle = "Haunted", Favorite = true },
                new Book { BookTitle = "Invisible Monsters", Favorite = false },
                new Book { BookTitle = "Beautiful You", Favorite = false }
            };

            foreach (var book in books)
            {
                Console.WriteLine(book.DavidsFavoriteBook());
            }


            var games = new List<Game>
            {
                new Game { GameTitle = "Cards Against Humanity", OffensiveGame = true },
                new Game { GameTitle = "Uno", OffensiveGame = false },
                new Game { GameTitle = "Phase 10", OffensiveGame = false }
            };

            foreach (var game in games)
            {
                Console.WriteLine(game.TheMoreOffensiveGame());
            }


            var bands = new List<Music>
            {
                new Music { BandName = "Blink 182", Favorite = true },
                new Music { BandName = "New Found Glory", Favorite = false },
                new Music { BandName = "A Day To Remember", Favorite = false }
            };

            foreach (var band in bands)
            {
                Console.WriteLine(band.DavidsFavoriteBand());
            }

        }
    }
}
