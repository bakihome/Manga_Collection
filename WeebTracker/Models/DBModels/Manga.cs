using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class Manga
    {
        public string Autor {  get; set; }
        public Collectible Collectibles { get; set; }
    }
}
