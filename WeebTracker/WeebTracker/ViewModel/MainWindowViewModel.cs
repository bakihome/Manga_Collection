using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using WeebTracker.Command;
using WeebTracker.Views;

namespace WeebTracker.ViewModels
{

    public class CoverItemViewModel
    {
        public string CoverImagePath { get; set; }

        public string Title { get; set; }

        public CoverItemViewModel(string coverImagePath, string title)
        {
            CoverImagePath = coverImagePath;
            Title = title;
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private fields

        private bool _isMangaVisible = true;
        private bool _isAnimeVisible = false;

        #endregion

        #region Public Properties

        /// <summary>
        /// the collection of manga covers to display.
        /// </summary>
        public ObservableCollection<CoverItemViewModel> MangaItems { get; set; }

        /// <summary>
        /// the collection of anime covers to display.
        /// </summary>
        public ObservableCollection<CoverItemViewModel> AnimeItems { get; set; }

        /// <summary>
        /// if true, we show the manga list. If false, manga list is hidden.
        /// </summary>
        public bool IsMangaVisible
        {
            get => _isMangaVisible;
            set
            {
                if (_isMangaVisible != value)
                {
                    _isMangaVisible = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// if true, we show the anime list. If false, anime list is hidden.
        /// </summary>
        public bool IsAnimeVisible
        {
            get => _isAnimeVisible;
            set
            {
                if (_isAnimeVisible != value)
                {
                    _isAnimeVisible = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region Commands

        public ICommand ShowAddCommand { get; }
        public ICommand ShowStatsCommand { get; }
        public ICommand ShowMangaCommand { get; }
        public ICommand ShowAnimeCommand { get; }

        /// <summary>
        /// command is bound to each edit button under a cover item.
        /// </summary>
        public ICommand EditCommand { get; }

        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
            //empty for now
            MangaItems = new ObservableCollection<CoverItemViewModel>();
            AnimeItems = new ObservableCollection<CoverItemViewModel>();

            // initialize commands:
            ShowAddCommand = new RelayCommand(_ => ExecuteShowAdd());
            ShowStatsCommand = new RelayCommand(_ => ExecuteShowStats());
            ShowMangaCommand = new RelayCommand(_ => ExecuteShowManga());
            ShowAnimeCommand = new RelayCommand(_ => ExecuteShowAnime());

            EditCommand = new RelayCommand(item => ExecuteEdit(item));
        }

        #endregion

        #region Command Handlers

        private void ExecuteShowAdd()
        {
            // open the “AddItemWindow” as a extra window
            var addWindow = new AddItemWindow();
            addWindow.Owner = Application.Current.MainWindow;
            addWindow.ShowDialog();
        }

        private void ExecuteShowStats()
        {
            // open the “StatisticWindow” as extra window
            var statWindow = new StatisticWindow();
            statWindow.Owner = Application.Current.MainWindow;
            statWindow.ShowDialog();
        }

        private void ExecuteShowManga()
        {
            IsMangaVisible = true;
            IsAnimeVisible = false;
        }

        private void ExecuteShowAnime()
        {
            IsAnimeVisible = true;
            IsMangaVisible = false;
        }

        private void ExecuteEdit(object? parameter)
        {
            if (parameter is CoverItemViewModel cover)
            {
                MessageBox.Show($"Edit clicked for “{cover.Title}”.\n\n(You can replace this by opening a real “Edit” view.)",
                                "Bearbeiten",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
