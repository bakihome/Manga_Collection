
using Common;
using Common.Command;
using System.ComponentModel;

namespace Models
{
    public class CoverItemViewModel :  NotifyPropertyChanged
    {        
        public string CoverImagePath { get; set; }

        public string Title { get; set; }

        public CoverItemViewModel(string coverImagePath, string title)
        {
            CoverImagePath = coverImagePath;
            Title = title;
        }        
    }

}
