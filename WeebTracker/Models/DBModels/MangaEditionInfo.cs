using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class MangaEditionInfo
    {
        [Key]
        [ForeignKey("EditionInfo")]
        public int EditionID { get; set; }
        public string Title { get; set; }
        public int Startchapter { get; set; }
        public int Endchapter { get; set; }
        public bool FirstEdition { get; set; }

        public EditionInfo EditionInfo { get; set; }
    }
}
