using Microsoft.Win32;
using Models.DBModels;
using System.Windows;
using WeebTracker.EntityFramework;

namespace WeebTracker.Views
{
    public partial class AddItemWindow : Window
    {
        public AddItemWindow()
        {
            InitializeComponent();
        }

        private void OnBrowseImage_Click(object sender, RoutedEventArgs e)
        {
        }

        private void OnSave_Click(object sender, RoutedEventArgs e)
        {
            string title_deutsch = TxtTitelDeutsch.Text;
            string title_japanisch = TxtTitelJapanisch.Text;
            string autor = TxtAutorDirektor.Text;
            string medium = CmbMedium.Text;
            var newCollectible = new Collectible();


            if (string.IsNullOrWhiteSpace(title_deutsch) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(medium))
            {
                MessageBox.Show("Pflichtfelder dürfen nicht leer sein.");                
                return;
            }
            else
            {
                if (medium == "Manga")
                {
                    newCollectible = new Manga(title_deutsch, false, "Manga", autor, new List<EditionInfo>());
                }
                if (medium == "Anime (Film)")
                {
                    newCollectible = new Anime(title_deutsch, false, "Anime", "Film", autor, new List<EditionInfo>());
                }
                if (medium == "Anime (Serie)")
                {
                    newCollectible = new Anime(title_deutsch, false, "Anime", "Serie", autor, new List<EditionInfo>());
                }
                using (var ctx = new WeebTrackerDBContext())
                {
                    ctx.Collectibles.Add(newCollectible);
                    ctx.SaveChanges();
                }
                MessageBox.Show("Eintrag gespeichert!");
                this.Close();
            }
        }
        

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
