using System.Text;
class Program

{
    static void Main(string[] args)
    {
        string filePath = "library.txt";

        Console.WriteLine("Podaj tytuł książki: ");
        var bookTitle = $"Tytuł książki: {Console.ReadLine()}";
        Console.WriteLine("Podaj autora książki: ");
        var bookAuthor = $"Autor książki: { Console.ReadLine()}";

        File.WriteAllText(filePath, $"{bookTitle}\n{bookAuthor}");

        var readFile = File.ReadAllLines(filePath);

        for (int i = 0; i < readFile.Length; i++)
        {
            Console.WriteLine($"{readFile[i]}");
        }
    }
}