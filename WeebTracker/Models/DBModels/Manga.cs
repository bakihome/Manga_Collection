using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class Manga : Collectible
    {
        
        public string Autor {  get; set; }
        public Collectible Collectibles { get; set; }

        public Manga() { }

        public Manga( string titel_deutsch, bool abgeschlossen, string medium, string autor) : base(titel_deutsch, abgeschlossen, medium)
        {
            Autor = autor;
        }
    }
}
