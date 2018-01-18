using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Music
    {

        public string BandName { get; set; }
        public bool Favorite { get; set; }

        public string DavidsFavoriteBand()
        {
            return Favorite
                ? $"{BandName} is David's favorite band. He's been listening to them for a long time."
                : $"David really enjoys listening to {BandName}, but it's not his FAVORITE band.";
        }

    }
}
