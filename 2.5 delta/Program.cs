class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        double result = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));

        Console.WriteLine(result);

        if (result == 0)
        {
            Console.WriteLine($"Funkcja ma jedno miejsce zerowe: x = {-b / (2 * a)}");
        }
        else if (result > 0)
        {
            Console.WriteLine($"Funkcja ma dwa miejsca zerowe: x1 = {(-b - result) / (2 * a)} x2 = {(-b + result) / (2 * a)}");
        }
        else
        {
            Console.WriteLine("Funkcja nie ma rozwiązań!");
        }
    }
}