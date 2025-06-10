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
        [Key]
        public int EditionID { get; set; }               
        public int CollectiblesID { get; set; }        
        public int Volume { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string Image { get; set; } = "Image/placeholder.jpg";

        [ForeignKey("CollectiblesID")]
        public Collectible Collectibles { get; set; }

        public EditionInfo() { }

        public EditionInfo(int volume, int amount, double price)
        {            
            Volume = volume;
            Amount = amount;
            Price = price;
        }
        public EditionInfo(int volume, int amount, double price, string image)
        {            
            Volume = volume;
            Amount = amount;
            Price = price;
            Image = image;
        }


    }
}
