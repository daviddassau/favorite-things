using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Game
    {
        protected string _cardsAgainstHumanity;
        public string CardsAgainstHumanity
        {
            get
            {
                return _cardsAgainstHumanity;
            }
            set
            {
                _cardsAgainstHumanity = value;
            }
        }

        protected string _uno;
        public string Uno
        {
            get
            {
                return _uno;
            }
            set
            {
                _uno = value;
            }
        }

        public Game()
        {
            this._cardsAgainstHumanity = "This game is for terrible people";
            this._uno = "This game is for everyone";
        }

        public string CardGamesThatAreOffensive(bool cardsAgainstHumanityIsOffensive)
        {
            if (cardsAgainstHumanityIsOffensive == true)
                return "This game is offensive and should only be played by terrible people";
            else
                return "As long as you are a terrible person, and not easily offended, go ahead and play Cards Against Humanity. You'll love it.";
        }
    }
}
