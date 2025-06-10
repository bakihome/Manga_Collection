using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DBModels
{
    public class AnimeEditionInfo
    {
        [Key]
        [ForeignKey("EditionInfo")]
        public int EditionID { get; set; }
        public string StorageMedium { get; set; }
        public int Startepisode { get; set; }
        public int Endepisode { get; set; }
        public string? Notes {  get; set; }

        public EditionInfo EditionInfo { get; set; }
    }
}
