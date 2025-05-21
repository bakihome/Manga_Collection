using Manga_Collection.Models;

bool check = false;
string input = "";
PrivateCollection currentCollection = new PrivateCollection();
currentCollection.GenerateData();
do
{
    Console.Clear();
    Console.WriteLine("*****Manga Collection*****");
    Console.WriteLine("[1] Hinzufügen");
    Console.WriteLine("[2] Manga");
    Console.WriteLine("[3] Anime");
    Console.WriteLine("[4] Statistik");
    input = Console.ReadLine();
    switch (input)
    {
        case ("1"):
            
            break;
        case ("2"):
            currentCollection.ShowMangaCollection();            
            Console.WriteLine("ID eingeben um die verfügbaren Bände anzuzeigen:");
            input = Console.ReadLine();
            currentCollection.ShowEditionInfoByID(int.Parse(input));
            Console.ReadLine();
            break;
        case ("3"):
            currentCollection.ShowAnimeCollection();
            Console.WriteLine("ID eingeben um die verfügbaren Bände anzuzeigen:");
            input = Console.ReadLine();
            currentCollection.ShowEditionInfoByID(int.Parse(input));
            Console.ReadLine();
            break;
        case ("4"):
            currentCollection.ShowStatistic();
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Wähle eine der Optionen 1 - 4");
            break;
    }    
} while (!check);
