using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga_Collection.Models
{
    public class MangaEditionInfo : EditionInfo
    {
        
        private string _title;
        private int _startchapter;
        private int _endchapter;
        private bool _firstedition;        

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int StartChapter
        {
            get { return _startchapter; }
            set { _startchapter = value; }
        }

        public int EndChapter
        {
            get { return _endchapter; }
            set { _endchapter = value; }
        }

        public bool FirstEdition
        {
            get { return _firstedition; }
            set { _firstedition = value; }
        }

        public MangaEditionInfo (int volume, int amount, double price, string title, int startchapter, int endchapter, bool firstedition) : base(volume, amount, price)
        {
            Title = title;
            StartChapter = startchapter;
            EndChapter = endchapter;
            FirstEdition = firstedition;
        }

        

    }
}
