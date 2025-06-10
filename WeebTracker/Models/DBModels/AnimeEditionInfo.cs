using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class AnimeEditionInfo : EditionInfo 
    {        
        public string StorageMedium { get; set; }
        public int Startepisode { get; set; }
        public int Endepisode { get; set; }
        public string? Notes {  get; set; }

        public AnimeEditionInfo() { }

        public AnimeEditionInfo(int volume, int amount, double price, string storagemedium, int startepisode, int endepisode, string image) : base(volume, amount, price, image)
        {
            StorageMedium = storagemedium;
            Startepisode = startepisode;
            Endepisode = endepisode;
            
        }
        public AnimeEditionInfo(int volume, int amount, double price, string storagemedium, int startepisode, int endepisode, string notes, string image) : base( volume,  amount,  price, image)
        {
            StorageMedium = storagemedium;
            Startepisode = startepisode;
            Endepisode = endepisode;
            Notes = notes;
        }

        public AnimeEditionInfo(int volume, int amount, double price, string storagemedium, int startepisode, int endepisode) : base( volume, amount, price)
        {
            StorageMedium = storagemedium;
            Startepisode = startepisode;
            Endepisode = endepisode;

        }
        //public AnimeEditionInfo(int volume, int amount, double price, string storagemedium, int startepisode, int endepisode, string image) : base(volume, amount, price, image)
        //{
        //    StorageMedium = storagemedium;
        //    Startepisode = startepisode;
        //    Endepisode = endepisode;
        //}
    }
}
