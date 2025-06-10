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

        public ICollection<EditionInfo> EditionInfo { get; set; }

        public Collectible(){}

        public Collectible(string titel_deutsch, bool abgeschlossen, string medium)
        {
            
            Title_German = titel_deutsch;
            Finalised = abgeschlossen;
            Medium = medium;
        }

        public Collectible(string titel_deutsch, bool abgeschlossen, string medium, List<EditionInfo> editionInfos)
        {

            Title_German = titel_deutsch;
            Finalised = abgeschlossen;
            Medium = medium;
            EditionInfo = editionInfos;
        }

        public Collectible(string titel_deutsch, bool abgeschlossen, string medium, string image)
        {
            
            Title_German = titel_deutsch;
            Finalised = abgeschlossen;
            Medium = medium;
            Image = image;
        }

        public Collectible(string titel_deutsch, bool abgeschlossen, string medium, string image, List<EditionInfo> editionInfos)
        {

            Title_German = titel_deutsch;
            Finalised = abgeschlossen;
            Medium = medium;
            Image = image;
            EditionInfo = editionInfos;
        }

        public Collectible(string titel_deutsch, string titel_jap, bool abgeschlossen, string medium)
        {
            
            Title_German = titel_deutsch;
            Title_Japanese = titel_jap;
            Finalised = abgeschlossen;
            Medium = medium;
            
        }

        public Collectible(string titel_deutsch, string titel_jap, bool abgeschlossen, string medium, List<EditionInfo> editionInfos)
        {

            Title_German = titel_deutsch;
            Title_Japanese = titel_jap;
            Finalised = abgeschlossen;
            Medium = medium;
            EditionInfo = editionInfos;

        }

        public Collectible(string titel_deutsch, string titel_jap, bool abgeschlossen, string medium, string image)
        {
            
            Title_German = titel_deutsch;
            Title_Japanese= titel_jap;
            Finalised = abgeschlossen;
            Medium = medium;
            Image = image;
        }

        public Collectible(string titel_deutsch, string titel_jap, bool abgeschlossen, string medium, string image, List<EditionInfo> editionInfos)
        {

            Title_German = titel_deutsch;
            Title_Japanese = titel_jap;
            Finalised = abgeschlossen;
            Medium = medium;
            Image = image;
            EditionInfo = editionInfos;
        }

    }
}
