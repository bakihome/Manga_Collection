using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class Anime
    {
        public string Director {  get; set; }
        public string Description { get; set; }
        public Collectible Collectibles { get; set; }

    }
}
