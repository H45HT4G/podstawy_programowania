class Program

{
    static void Main(string[] args)
    {
        const double CHF = 1.12, EUR = 1.08, USD = 3.99, GBP = 1.24;
        double PLN;

        Console.WriteLine("Podaj kwotę do wymiany (PLN): ");
        PLN = Convert.ToDouble(Console.ReadLine());

        double conversion = PLN / USD;

        Console.WriteLine($"Kwota w walucie pośredniej USD: {conversion}");

        Console.WriteLine("Wybierz walutę, na którą chcesz wymienić: \n1.CHF\n2.EUR\n3.GBP");
        int current = Convert.ToInt32(Console.ReadLine());

        switch (current)
        {
            case 1:
                Console.WriteLine($"Kwota w CHF: {conversion * CHF}");
                break;

            case 2:
                Console.WriteLine($"Kwota w EUR: {conversion * EUR}");
                break;

            case 3:
                Console.WriteLine($"Kwota w GBP: {conversion * GBP}");
                break;

            default:
                Console.WriteLine("Nie wybrałeś poprawnej wymany walut.");
                break;
        }
    }
}