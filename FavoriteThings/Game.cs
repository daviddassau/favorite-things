using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Game
    {
        public string GameTitle { get; set; }
        public bool OffensiveGame { get; set; }

        public string TheMoreOffensiveGame()
        {
            return OffensiveGame
                ? $"{GameTitle} is an offensive game. You should only play this if you're a terrible person."
                : $"{GameTitle} is a family game, meant for everyone.";
        }

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
