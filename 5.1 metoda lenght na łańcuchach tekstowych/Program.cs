class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj nazwe miasta: ");
        string city = Console.ReadLine();
        Console.WriteLine("Podaj nazwe województwa: ");
        string voivodeship = Console.ReadLine();

        int cityLength = city.Length;
        int voivodeshipLength = voivodeship.Length;

        Console.WriteLine($"Nazwa miasta {city} zawiera {cityLength} liter. Nazwa województwa {voivodeship} zawiera {voivodeshipLength} liter.");
    }
}