using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class EditionInfo
    {
        public int Volume { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public Collectible Collectibles { get; set; }

        public AnimeEditionInfo? AnimeEditionInfo { get; set; }

        public MangaEditionInfo? MangaEditionInfo { get; set; }
    }
}
