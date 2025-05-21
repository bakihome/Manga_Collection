using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga_Collection.Models
{
    public class EditionInfo
    {
        private int _volume;
        private int _amount;
        private double _price;

        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public EditionInfo(int volume, int amount, double price) 
        {
            _volume = volume;
            _amount = amount;
            _price = price;
        }

        
    }
}
