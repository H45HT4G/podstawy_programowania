using System.Text;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine($"LOKALIZACJA PLIKU 'library.txt': {Directory.GetCurrentDirectory()}\n");
        Console.WriteLine("Podaj tytuł książki: ");
        string bookTitle = $"Tytuł książki: {Console.ReadLine()}";
        Console.WriteLine("Podaj autora książki: ");
        string bookAuthor = $"Autor książki: {Console.ReadLine()}";

        string[] lines = { bookTitle, bookAuthor };

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "library.txt")))
        {
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
        }

        using (var sr = new StreamReader("library.txt"))
        {
            Console.WriteLine();
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}