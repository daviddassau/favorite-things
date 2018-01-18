using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Book
    {
        public string BookTitle { get; set; }
        public bool Favorite { get; set; }

        public string DavidsFavoriteBook()
        {
            return Favorite
                ? $"{BookTitle} is David's favorite book"
                : $"{BookTitle} is a great book. However, it is not David's favorite book.";
        }

        protected string _fightClub;
        public string FightClub
        {
            get
            {
                return _fightClub;
            }
            set
            {
                _fightClub = value;
            }
        }

        protected string _theGreatGatsby;
        public string TheGreatGatsby
        {
            get
            {
                return _theGreatGatsby;
            }
            set
            {
                _theGreatGatsby = value;
            }
        }

        public Book()
        {
            this._fightClub = "Release date: 1999";
            this._theGreatGatsby = "Release date: 1925";
        }

        public string BookReleaseDate(bool fightClubCameAfterGatsby)
        {
            if (fightClubCameAfterGatsby == true)
                return "The book Fight Club was published after The Great Gatsby";
            else
                return "You must be dyslexic, because The Great Gatsby came out like 100 years ago, bro.";
        }
    }
}
