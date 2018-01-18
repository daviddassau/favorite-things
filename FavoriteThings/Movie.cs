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

        protected string _starwars;
        public string starwars
        {
            get
            {
                return _starwars;
            }
            set
            {
                _starwars = value;
            }
        }

        protected string _startrek;
        public string startrek
        {
            get
            {
                return _startrek;
            }
            set
            {
                _startrek = value;
            }
        }

        public movie()
        {
            this._starwars = "5 stars";
            this._startrek = "4 stars";
        }

        public string getstarwarscharacter(bool hansoloisdead)
        {
            if (hansoloisdead == true)
                return "han solo died in the force awakens";
            else
                return "han solo is definitely still alive. kylo ren definitely didn't kill him.";
        }
    }
}
