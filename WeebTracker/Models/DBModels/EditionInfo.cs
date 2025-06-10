using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class EditionInfo
    {
        [ForeignKey("Collectible")]
        public int CollectiblesID { get; set; }
        [Key]
        public int EditionID { get; set; }
        public int Volume { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string Image { get; set; } = "Image/placeholder.jpg";

        public Collectible Collectibles { get; set; }

        public AnimeEditionInfo? AnimeEditionInfo { get; set; }

        public MangaEditionInfo? MangaEditionInfo { get; set; }
    }
}
