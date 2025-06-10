using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class MangaEditionInfo : EditionInfo
    {        
        public string Title { get; set; }
        public int StartChapter { get; set; }
        public int EndChapter { get; set; }
        public bool FirstEdition { get; set; }

        public MangaEditionInfo() { }

        public MangaEditionInfo(int volume, int amount, double price, string title, int startchapter, int endchapter, bool firstedition) : base( volume, amount, price)
        {
            Title = title;
            StartChapter = startchapter;
            EndChapter = endchapter;
            FirstEdition = firstedition;
        }

        public MangaEditionInfo(int volume, int amount, double price, string title, int startchapter, int endchapter, bool firstedition, string image) : base( volume, amount, price, image)
        {
            Title = title;
            StartChapter = startchapter;
            EndChapter = endchapter;
            FirstEdition = firstedition;
        }

    }
}
