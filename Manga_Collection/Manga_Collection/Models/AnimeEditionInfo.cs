using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga_Collection.Models
{
    public class AnimeEditionInfo : EditionInfo
    {

        // DVD/BlueRay/Digital(Sicherungskopie)
        private string _storagemedium;        
        private int _startepisode;
        private int _endepisode;
        private string _notes;
        

        public string Storagemedium
        {
            get { return _storagemedium; }
            set { _storagemedium = value; }
        }
        

        public int Startepisode
        {
            get { return _startepisode; }
            set { _startepisode = value; }
        }

        public int Endepisode
        {
            get { return _endepisode; }
            set { _endepisode = value; }
        }

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        public AnimeEditionInfo(int volume, int amount, double price, string storagemedium, int startepisode, int endepisode, string notes) : base(volume, amount, price)
        {
            Storagemedium = storagemedium;            
            Startepisode = startepisode;
            Endepisode = endepisode;
            Notes = notes;
        }
        public AnimeEditionInfo(int volume, int amount, double price, string storagemedium,  int startepisode, int endepisode) : base(volume, amount, price)
        {
            Storagemedium = storagemedium;            
            Startepisode = startepisode;
            Endepisode = endepisode;
            
        }
    }
}
