using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeebTracker.ViewModel
{
    public class StatisticsViewModel : BaseViewModel
    {
        public int MangaCount { get; set; }
        public int MangaCompleted { get; set; }
        public int MangaVolumes { get; set; }
        public string MangaCost { get; set; }

        public int AnimeMovies { get; set; }
        public int AnimeSeries { get; set; }
        public string DvdCost { get; set; }

        public string TotalCost { get; set; }
    }

}
