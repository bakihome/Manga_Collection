using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using WeebTracker.Views;
using Common.Command;
using Models;
using System.Windows.Controls;


namespace WeebTracker.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region ------------------------- Fields, Constants, Delegates, Events ---------------------------------
        /// <summary>
        /// View that is currently bound to the ContentControl.
        /// </summary>
        private UserControl currentView;
        #endregion

        #region ------------------------- Constructors, Destructors, Dispose, Clone ----------------------------

        public MainWindowViewModel()
        {
            //empty for now
            //MangaItems = new ObservableCollection<CoverItemViewModel>();
            //AnimeItems = new ObservableCollection<CoverItemViewModel>();

            // initialize commands:
            ShowAddCommand = new ActionCommand(_ => ExecuteShowAdd(), CommandCanExecute);
            ShowStatsCommand = new ActionCommand(_ => ExecuteShowStats(), CommandCanExecute);
            ShowMangaCommand = new ActionCommand(_ => ExecuteShowManga(), CommandCanExecute);
            ShowAnimeCommand = new ActionCommand(_ => ExecuteShowAnime(), CommandCanExecute);

            EditCommand = new ActionCommand(item => ExecuteEdit(item), CommandCanExecute);

        }

        #endregion

        #region ------------------------- Properties, Indexes --------------------------------------------------

        
        public ICommand ShowAddCommand { get; private set; }
        public ICommand ShowStatsCommand { get; private set; }
        public ICommand ShowMangaCommand { get; private set; }
        public ICommand ShowAnimeCommand { get; private set; }

        /// <summary>
        /// command is bound to each edit button under a cover item.
        /// </summary>
        public ICommand EditCommand { get; private set; }
        ///// <summary>
        ///// the collection of manga covers to display.
        ///// </summary>
        //public ObservableCollection<CoverItemViewModel> MangaItems { get; set; }

        ///// <summary>
        ///// the collection of anime covers to display.
        ///// </summary>
        //public ObservableCollection<CoverItemViewModel> AnimeItems { get; set; }

        /// <summary>
        /// if true, we show the manga list. If false, manga list is hidden.
        /// </summary>

        public UserControl CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        
        #endregion

        #region ------------------------- Commands --------------------------------------------------------------

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
            MangaListView mangaListView = new MangaListView();
            MangaListViewModel mangaListViewModel = new MangaListViewModel();
            mangaListView.DataContext = mangaListViewModel;

            CurrentView = mangaListView;
            //IsMangaVisible = true;
            //IsAnimeVisible = false;
        }

        private void ExecuteShowAnime()
        {
            AnimeListView animeListView = new AnimeListView();
            AnimeListViewModel animeListViewModel = new AnimeListViewModel();
            animeListView.DataContext = animeListViewModel;

            CurrentView = animeListView;
            //IsAnimeVisible = true;
            //IsMangaVisible = false;
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

        private bool CommandCanExecute(object parameter)
        {
            return true;
        }

        #endregion

    }
}
