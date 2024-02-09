class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwsze zdanie: ");
        string firstSentence = Console.ReadLine();
        Console.WriteLine("Podaj drugie zdanie: ");
        string secondSentence = Console.ReadLine();

        string joinedSentences = String.Concat(firstSentence + secondSentence);
        Console.WriteLine($"Połączone zdania: {joinedSentences}");
    }
}