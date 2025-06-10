using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class Collectible
    {
        [Key]
        public int CollectiblesID { get; set; }
        public string Title_German { get; set; }
        public string? Title_Japanese { get; set; }
        public bool Finalised { get; set; }
        public string Medium {  get; set; }
        public string Image {  get; set; } = "Image/placeholder.jpg";

        public Manga? Manga { get; set; }

        public Anime? Anime { get; set; }

        public ICollection<EditionInfo> EditionInfo { get; set; }

    }
}
