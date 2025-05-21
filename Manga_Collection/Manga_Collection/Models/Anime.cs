using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga_Collection.Models
{
    public class Anime : Collectibles
    {
        private string _director;
        // Film/Serie
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Director
        {
            get { return _director; }
            set { _director = value; } 
        }

       
        public Anime(int id, string titel_deutsch, bool abgeschlossen, string medium, string description, string regisseur) : base(id, titel_deutsch, abgeschlossen, medium)
        {
            Director = regisseur; 
            Description = description;
        }
    }
}
