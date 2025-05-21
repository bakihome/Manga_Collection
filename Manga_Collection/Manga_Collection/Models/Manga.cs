using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga_Collection.Models
{
    public class Manga : Collectibles
    {
        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public Manga (int id, string titel_deutsch, bool abgeschlossen, string medium, string autor) : base ( id, titel_deutsch,  abgeschlossen,  medium) 
        {
            Author = autor;
        }
    }
}
