using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class Anime : Collectible
    {
        
        public string Director {  get; set; }
        public string Description { get; set; }
        public Collectible Collectibles { get; set; }

        public Anime() { }

        public Anime(string titel_deutsch, bool abgeschlossen, string medium, string description, string regisseur) : base(titel_deutsch, abgeschlossen, medium)
        {
            Director = regisseur;
            Description = description;
        }
        

        public Anime(string titel_deutsch, bool abgeschlossen, string medium, string description, string regisseur, List<EditionInfo> editionInfos) : base(titel_deutsch, abgeschlossen, medium, editionInfos)
        {
            Director = regisseur;
            Description = description;
        }

        public Anime(string titel_deutsch, bool abgeschlossen, string medium, string description, string regisseur, string image, List<EditionInfo> editionInfos) : base(titel_deutsch, abgeschlossen, medium, image, editionInfos)
        {
            Director = regisseur;
            Description = description;
        }
    }
}
