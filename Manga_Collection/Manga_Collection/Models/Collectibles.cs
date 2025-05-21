using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga_Collection.Models
{
    public class Collectibles
    {
        private int _collectibleID;
        private string _titel_german;
        private string _titel_japanese;
        private bool _finalised;
        // Manga/Anime
        private string _medium;

        public int CollectibleID
        {
            get { return _collectibleID; }
            set { _collectibleID = value; } 
        }

        public string Titel_German
        {
            get { return _titel_german; }
            set { _titel_german = value; }
        }

        public string Titel_Japanese
        {
            get { return _titel_japanese; }
            set { _titel_japanese = value; }
        }

        public bool Finalised
        {
            get { return _finalised; }
            set { _finalised = value; }
        }

        public string Medium
        {
            get { return _medium; }
            set { _medium = value; }
        }

        public Collectibles(int id, string titel_deutsch, bool abgeschlossen, string medium)
        {
            CollectibleID = id;
            Titel_German = titel_deutsch;            
            Finalised = abgeschlossen;
            Medium = medium;
        }
    }
}
