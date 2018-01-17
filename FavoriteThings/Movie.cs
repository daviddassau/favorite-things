using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Movie
    {

        public string MovieTitle { get; set; }
        public bool Favorite { get; set; }

        public string DavidsFavoriteMovie()
        {
            return Favorite
                ? $"{MovieTitle} is David's favorite movie."
                : $"{MovieTitle} is still a good movie, but it's not David's favorite.";
        }

        //public string ForgeASickNote()
        //{
        //    return Sick
        //        ? $"Please excuse {Name} from class today because they are very sick."
        //        : $"{Name}, you still have to go to school, quit faking. Love mom.";
        //}

        //protected string _starWars;
        //public string StarWars
        //{
        //    get
        //    {
        //        return _starWars;
        //    }
        //    set
        //    {
        //        _starWars = value;
        //    }
        //}

        //protected string _starTrek;
        //public string StarTrek
        //{
        //    get
        //    {
        //        return _starTrek;
        //    }
        //    set
        //    {
        //        _starTrek = value;
        //    }
        //}

        //public Movie()
        //{
        //    this._starWars = "5 stars";
        //    this._starTrek = "4 stars";
        //}

        //public string GetStarWarsCharacter(bool hanSoloIsDead)
        //{
        //    if (hanSoloIsDead == true)
        //        return "Han Solo died in The Force Awakens";
        //    else
        //        return "Han Solo is definitely still alive. Kylo Ren definitely didn't kill him.";
        //}
    }
}
