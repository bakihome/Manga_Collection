using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class Manga
    {
        [Key]
        [ForeignKey("Collectible")]
        public int CollectiblesID { get; set; }
        public string Autor {  get; set; }
        public Collectible Collectibles { get; set; }
    }
}
